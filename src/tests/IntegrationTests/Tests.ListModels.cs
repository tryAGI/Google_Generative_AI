namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        using var client = GetAuthenticatedClient();

        ListModelsResponse response = await client.ListModelsAsync();
        
        foreach (var model in response.Models ?? [])
        {
            Console.WriteLine(model.Name);
        }
        
        response.Models.Should().NotBeNullOrEmpty();
    }
}
