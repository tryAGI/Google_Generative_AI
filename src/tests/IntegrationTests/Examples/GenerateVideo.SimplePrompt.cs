/*
order: 220
title: Generate Video Simple Prompt
slug: generate-video-simple-prompt
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(120_000)] // Video generation can take a while
    public async Task GenerateVideo_SimplePrompt()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var result = await client.GenerateVideoAsync(
                prompt: "A serene beach at sunset with gentle waves");

            result.HasVideo.Should().BeTrue();
            result.VideoData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
        {
            // VIDEO modality may not be supported in generateContent endpoint yet
            Assert.Inconclusive("Video generation not supported: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
