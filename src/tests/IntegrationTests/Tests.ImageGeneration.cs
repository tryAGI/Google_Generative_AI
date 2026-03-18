namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage_SimplePrompt()
    {
        using var client = GetAuthenticatedClient();

        var result = await client.GenerateImageAsync(
            prompt: "A simple red circle on a white background",
            imageSize: "1K");

        result.HasImage.Should().BeTrue();
        result.ImageData.Should().NotBeNullOrEmpty();
        result.MimeType.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task GenerateImage_WithAspectRatio()
    {
        using var client = GetAuthenticatedClient();

        var result = await client.GenerateImageAsync(
            prompt: "A landscape with mountains",
            imageSize: "1K",
            aspectRatio: "16:9");

        result.HasImage.Should().BeTrue();
        result.ImageData.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task GenerateImage_WithTextResponse()
    {
        using var client = GetAuthenticatedClient();

        var result = await client.GenerateImageAsync(
            prompt: "A blue square with the text 'Hello'",
            imageSize: "1K",
            includeTextResponse: true);

        result.HasImage.Should().BeTrue();
    }

    [TestMethod]
    public async Task EditImage_SimpleEdit()
    {
        using var client = GetAuthenticatedClient();

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

    [TestMethod]
    public async Task GenerateImageWithReferences_SingleReference()
    {
        using var client = GetAuthenticatedClient();

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
}
