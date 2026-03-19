/*
order: 170
title: File Management
slug: file-management
*/

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
}
