namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CountTokens_SimpleText()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        var response = await client.ModelsCountTokensAsync(
            modelsId: modelId,
            contents:
            [
                new Content
                {
                    Parts = [new Part { Text = "Hello, world! This is a test of token counting." }],
                },
            ]);

        response.TotalTokens.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task CountTokens_MultipleMessages()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        var response = await client.ModelsCountTokensAsync(
            modelsId: modelId,
            contents:
            [
                new Content
                {
                    Role = "user",
                    Parts = [new Part { Text = "What is the meaning of life?" }],
                },
                new Content
                {
                    Role = "model",
                    Parts = [new Part { Text = "The meaning of life is a philosophical question." }],
                },
                new Content
                {
                    Role = "user",
                    Parts = [new Part { Text = "Can you elaborate?" }],
                },
            ]);

        response.TotalTokens.Should().BeGreaterThan(0);
    }
}
