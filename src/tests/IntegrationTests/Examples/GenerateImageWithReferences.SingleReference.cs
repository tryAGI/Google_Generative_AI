/*
order: 210
title: Generate Image With References Single Reference
slug: generate-image-with-references-single-reference
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImageWithReferences_SingleReference()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            // This example uses native image output and therefore requires
            // a Paid Tier Gemini API project and API key.
            // First generate a reference image
            var reference = await client.GenerateImageAsync(
                prompt: "A simple red square",
                imageSize: "1K");

            reference.HasImage.Should().BeTrue("need a reference image");

            var result = await client.GenerateImageWithReferencesAsync(
                prompt: "Create a similar shape but in blue",
                referenceImages: [(reference.ImageData!, reference.MimeType ?? "image/png")],
                imageSize: "1K");

            result.HasImage.Should().BeTrue();
            result.ImageData.Should().NotBeNullOrEmpty();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
