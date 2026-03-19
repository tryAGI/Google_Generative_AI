/*
order: 163
title: Embedding Generator Task Type
slug: embedding-generator-task-type
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_TaskType()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetEmbeddingModelId();

        try
        {
            IEmbeddingGenerator<string, Embedding<float>> generator = client;

            //// Use RETRIEVAL_QUERY task type for search queries
            var queryResult = await generator.GenerateAsync(
                values: ["How do I reset my password?"],
                options: new EmbeddingGenerationOptions
                {
                    ModelId = modelId,
                    AdditionalProperties = new AdditionalPropertiesDictionary
                    {
                        ["TaskType"] = "RETRIEVAL_QUERY",
                    },
                });

            queryResult.Should().ContainSingle();
            queryResult[0].Vector.Length.Should().BeGreaterThan(0);

            //// Use RETRIEVAL_DOCUMENT task type with a Title for documents
            var docResult = await generator.GenerateAsync(
                values: ["To reset your password, go to Settings > Security > Change Password."],
                options: new EmbeddingGenerationOptions
                {
                    ModelId = modelId,
                    AdditionalProperties = new AdditionalPropertiesDictionary
                    {
                        ["TaskType"] = "RETRIEVAL_DOCUMENT",
                        ["Title"] = "Password Reset Guide",
                    },
                });

            docResult.Should().ContainSingle();
            docResult[0].Vector.Length.Should().BeGreaterThan(0);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
