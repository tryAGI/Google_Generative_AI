/*
order: 120
title: Embedding Generator Batch Input
slug: embedding-generator-batch-input
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_BatchInput()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetEmbeddingModelId();

        try
        {
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
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
