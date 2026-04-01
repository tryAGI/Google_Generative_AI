/*
order: 240
title: Interpolate Frames Two Images
slug: interpolate-frames-two-images
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(120_000)]
    public async Task InterpolateFrames_TwoImages()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var startFrame = await client.GenerateImageAsync(
                prompt: "A red circle on a white background",
                imageSize: "1K");

            var endFrame = await client.GenerateImageAsync(
                prompt: "A blue square on a white background",
                imageSize: "1K");

            startFrame.HasImage.Should().BeTrue("need a start frame");
            endFrame.HasImage.Should().BeTrue("need an end frame");

            var result = await client.InterpolateFramesAsync(
                startFrame: startFrame.ImageData!,
                endFrame: endFrame.ImageData!,
                prompt: "Smoothly transition between the two shapes");

            result.HasVideo.Should().BeTrue();
            result.VideoData.Should().NotBeNullOrEmpty();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
        {
            Assert.Inconclusive("Video generation not supported: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
