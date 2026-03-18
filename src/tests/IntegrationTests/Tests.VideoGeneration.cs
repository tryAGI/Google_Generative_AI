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
