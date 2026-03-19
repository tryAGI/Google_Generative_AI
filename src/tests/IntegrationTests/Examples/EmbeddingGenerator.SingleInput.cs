/*
order: 160
title: Embedding Generator Single Input
slug: embedding-generator-single-input
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_SingleInput()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetEmbeddingModelId();

        try
        {
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
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
