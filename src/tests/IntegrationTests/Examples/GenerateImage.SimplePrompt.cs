/*
order: 190
title: Generate Image Simple Prompt
slug: generate-image-simple-prompt
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage_SimplePrompt()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            // Native image output models such as gemini-2.5-flash-image currently
            // require a Paid Tier Gemini API project and API key.
            var result = await client.GenerateImageAsync(
                prompt: "A simple red circle on a white background",
                imageSize: "1K");

            result.HasImage.Should().BeTrue();
            result.ImageData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
