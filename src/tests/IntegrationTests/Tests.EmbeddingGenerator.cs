using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    private static string GetEmbeddingModelId()
    {
        LoadDotEnv();

        return Environment.GetEnvironmentVariable("GOOGLE_GEMINI_EMBEDDING_MODEL_ID") ?? "gemini-embedding-001";
    }

    [TestMethod]
    public async Task EmbeddingGenerator_SingleInput()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetEmbeddingModelId();

        IEmbeddingGenerator<string, Embedding<float>> generator = client;
        var result = await generator.GenerateAsync(
            values: ["Hello, world!"],
            options: new EmbeddingGenerationOptions
            {
                ModelId = modelId,
            });

        result.Should().ContainSingle();
        result[0].Vector.Length.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task EmbeddingGenerator_BatchInput()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetEmbeddingModelId();

        IEmbeddingGenerator<string, Embedding<float>> generator = client;
        var result = await generator.GenerateAsync(
            values: ["Hello, world!", "Goodbye, world!"],
            options: new EmbeddingGenerationOptions
            {
                ModelId = modelId,
            });

        result.Should().HaveCount(2);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        result[1].Vector.Length.Should().BeGreaterThan(0);
        result[0].Vector.Length.Should().Be(result[1].Vector.Length);
    }
}
