namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FilesList_ReturnsResponse()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.FilesListAsync();

        // Should return a valid response even if no files exist
        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task MediaUpload_AndFilesGet_AndFilesDelete()
    {
        using var client = GetAuthenticatedClient();

        // Upload a file via the metadata API
        var uploadResponse = await client.MediaUploadAsync(
            file: new File
            {
                DisplayName = "test-file.txt",
            });

        uploadResponse.Should().NotBeNull();
        uploadResponse.File.Should().NotBeNull();
        uploadResponse.File!.Name.Should().NotBeNullOrWhiteSpace();

        var fileName = uploadResponse.File.Name!;
        var fileId = fileName.Replace("files/", string.Empty);

        // Get the file metadata
        var getResponse = await client.FilesGetAsync(filesId: fileId);
        getResponse.Should().NotBeNull();
        getResponse.Name.Should().Be(fileName);

        // Delete the file
        await client.FilesDeleteAsync(filesId: fileId);
    }
}
