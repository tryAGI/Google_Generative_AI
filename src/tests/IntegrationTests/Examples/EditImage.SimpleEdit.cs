/*
order: 110
title: Edit Image Simple Edit
slug: edit-image-simple-edit
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EditImage_SimpleEdit()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            // This example uses native image output and therefore requires
            // a Paid Tier Gemini API project and API key.
            // First generate an image to edit
            var original = await client.GenerateImageAsync(
                prompt: "A plain white background",
                imageSize: "1K");

            original.HasImage.Should().BeTrue("need a source image to edit");

            var edited = await client.EditImageAsync(
                prompt: "Add a red circle in the center",
                imageData: original.ImageData!,
                mimeType: original.MimeType ?? "image/png",
                imageSize: "1K");

            edited.HasImage.Should().BeTrue();
            edited.ImageData.Should().NotBeNullOrEmpty();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
