namespace Google.Gemini.IntegrationTests;

using System.Diagnostics;

public partial class Tests
{
    [TestMethod]
    public async Task CloudLiveAvatar_AuthorizedVideoPlaybackAndInterruption()
    {
        if (System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_AVATAR_E2E") is not "true")
        {
            throw new AssertInconclusiveException(
                "Set GOOGLE_CLOUD_AVATAR_E2E=true for the metered Google Cloud Live Avatar test.");
        }

        var projectId = System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_AVATAR_PROJECT") is { Length: > 0 } project
            ? project : throw new AssertInconclusiveException("GOOGLE_CLOUD_AVATAR_PROJECT is required.");
        var location = System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_AVATAR_LOCATION") is { Length: > 0 } region
            ? region : throw new AssertInconclusiveException("GOOGLE_CLOUD_AVATAR_LOCATION is required.");
        var avatarName = System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_AVATAR_NAME") is { Length: > 0 } avatar
            ? avatar : "Ben";
        var voiceName = System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_AVATAR_VOICE") is { Length: > 0 } voice
            ? voice : "Puck";

        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(3));
        var setup = GeminiCloudLiveClient.CreateAvatarSetup(avatarName, voiceName);
        await using var session = await GeminiCloudLiveClient.ConnectResilientAsync(
            projectId, location, GetGcloudTokenAsync, setup, cancellationToken: timeout.Token);

        var videoPath = Path.Combine(Path.GetTempPath(), $"gemini-avatar-{Guid.NewGuid():N}.mp4");
        try
        {
            await using (var video = System.IO.File.Create(videoPath))
            {
                await session.SendTextAsync("Say hello in one short sentence.", timeout.Token);
                var chunks = 0;
                var completed = false;
                await foreach (var message in session.ReadEventsAsync(timeout.Token))
                {
                    if (message.ServerContent is not { } content)
                    {
                        continue;
                    }

                    foreach (var chunk in content.GetVideoChunks())
                    {
                        await video.WriteAsync(chunk.Data!, timeout.Token);
                        chunks++;
                    }

                    if (content.TurnComplete is true)
                    {
                        completed = true;
                        break;
                    }
                }

                Assert.IsTrue(completed, "The avatar turn did not complete.");
                Assert.IsGreaterThan(0, chunks, "The avatar returned no MP4 chunks.");
            }

            await VerifyVideoStreamAsync(videoPath, timeout.Token);

            await session.SendTextAsync("Count slowly from one to fifty.", timeout.Token);
            var interruptionSent = false;
            var interruptionObserved = false;
            await foreach (var message in session.ReadEventsAsync(timeout.Token))
            {
                if (message.ServerContent is not { } content)
                {
                    continue;
                }

                if (content.Interrupted is true)
                {
                    interruptionObserved = true;
                }

                if (!interruptionSent && content.GetVideoChunks().Any())
                {
                    await session.SendTextAsync("Stop counting and say goodbye.", timeout.Token);
                    interruptionSent = true;
                }

                if (interruptionSent && interruptionObserved && content.TurnComplete is true)
                {
                    break;
                }
            }

            Assert.IsTrue(interruptionSent, "The long avatar turn produced no video to interrupt.");
            Assert.IsTrue(interruptionObserved, "The server did not signal interruption.");
        }
        finally
        {
            System.IO.File.Delete(videoPath);
        }
    }

    private static async Task<string> GetGcloudTokenAsync(CancellationToken cancellationToken)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("gcloud")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };
        process.StartInfo.ArgumentList.Add("auth");
        process.StartInfo.ArgumentList.Add("print-access-token");
        try
        {
            process.Start();
        }
        catch (System.ComponentModel.Win32Exception)
        {
            throw new AssertInconclusiveException("gcloud is required for the authorized Avatar test.");
        }

        var token = await process.StandardOutput.ReadToEndAsync(cancellationToken);
        await process.WaitForExitAsync(cancellationToken);
        if (process.ExitCode != 0 || string.IsNullOrWhiteSpace(token))
        {
            throw new AssertInconclusiveException("gcloud did not provide an access token.");
        }

        return token.Trim();
    }

    private static async Task VerifyVideoStreamAsync(string path, CancellationToken cancellationToken)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("ffprobe")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };
        foreach (var argument in new[] { "-v", "error", "-show_entries", "stream=codec_type", "-of", "csv=p=0", path })
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        try
        {
            process.Start();
        }
        catch (System.ComponentModel.Win32Exception)
        {
            throw new AssertInconclusiveException("ffprobe is required to verify Avatar MP4 playback.");
        }

        var streams = await process.StandardOutput.ReadToEndAsync(cancellationToken);
        await process.WaitForExitAsync(cancellationToken);
        Assert.AreEqual(0, process.ExitCode, "ffprobe could not decode the assembled MP4 stream.");
        StringAssert.Contains(streams, "video");
    }
}
