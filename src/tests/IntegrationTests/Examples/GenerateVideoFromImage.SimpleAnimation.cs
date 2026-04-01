/*
order: 230
title: Generate Video From Image Simple Animation
slug: generate-video-from-image-simple-animation
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(120_000)]
    public async Task GenerateVideoFromImage_SimpleAnimation()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var image = await client.GenerateImageAsync(
                prompt: "A still landscape with mountains and a lake",
                imageSize: "1K");

            image.HasImage.Should().BeTrue("need a source image");

            var result = await client.GenerateVideoFromImageAsync(
                prompt: "Animate the clouds moving slowly across the sky",
                imageData: image.ImageData!,
                mimeType: image.MimeType ?? "image/png");

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
