/*
order: 200
title: Generate Image With Aspect Ratio
slug: generate-image-with-aspect-ratio
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage_WithAspectRatio()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var result = await client.GenerateImageAsync(
                prompt: "A landscape with mountains",
                imageSize: "1K",
                aspectRatio: "16:9");

            result.HasImage.Should().BeTrue();
            result.ImageData.Should().NotBeNullOrEmpty();
        }
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
    }
}
