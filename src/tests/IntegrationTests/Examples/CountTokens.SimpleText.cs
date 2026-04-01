/*
order: 100
title: Count Tokens Simple Text
slug: count-tokens-simple-text
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CountTokens_SimpleText()
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
                        Parts = [new Part { Text = "Hello, world! This is a test of token counting." }],
                    },
                ]);

            response.TotalTokens.Should().BeGreaterThan(0);
        }
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
    }
}
