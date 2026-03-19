/*
order: 130
title: Embedding Generator Get Service Returns Embedding Generator Metadata
slug: embedding-generator-get-service-returns-embedding-generator-metadata
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsEmbeddingGeneratorMetadata()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var metadata = generator.GetService<EmbeddingGeneratorMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(GeminiClient));
    }
}
