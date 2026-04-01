/*
order: 280
title: Transcribe Generated Audio
slug: transcribe-generated-audio
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Transcribe_GeneratedAudio()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            // First generate audio to transcribe
            var audio = await client.SpeakAsync(
                text: "Read aloud: The quick brown fox jumps over the lazy dog.");

            audio.HasAudio.Should().BeTrue("need audio to transcribe");

            var transcription = await client.TranscribeAsync(
                audioData: audio.AudioData!,
                mimeType: audio.MimeType ?? "audio/wav");

            transcription.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                                      ex.Message.Contains("only be used for TTS"))
        {
            Assert.Inconclusive("TTS model rejected input: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
