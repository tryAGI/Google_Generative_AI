/*
order: 150
title: Embedding Generator Get Service Returns Self
slug: embedding-generator-get-service-returns-self
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var self = generator.GetService<GeminiClient>();

        self.Should().BeSameAs(client);
    }
}
