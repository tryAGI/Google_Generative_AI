/*
order: 90
title: Count Tokens Multiple Messages
slug: count-tokens-multiple-messages
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CountTokens_MultipleMessages()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        try
        {
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
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
