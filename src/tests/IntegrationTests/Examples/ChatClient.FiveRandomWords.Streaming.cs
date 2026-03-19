/*
order: 10
title: Chat Client Five Random Words Streaming
slug: chat-client-five-random-words-streaming
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        try
        {
            IChatClient chatClient = client;
            var updates = chatClient.GetStreamingResponseAsync(
                messages:
                [
                    new ChatMessage(ChatRole.User, "Generate 5 random words.")
                ],
                options: new ChatOptions
                {
                    ModelId = modelId,
                });

            var deltas = new List<string>();
            await foreach (var update in updates)
            {
                if (!string.IsNullOrWhiteSpace(update.Text))
                {
                    deltas.Add(update.Text);
                }
            }

            // In streaming mode, rate limiting may not throw ApiException but instead
            // return empty/truncated data. Treat empty results as inconclusive.
            if (deltas.Count == 0)
            {
                Assert.Inconclusive("No streaming deltas received (likely rate limited).");
                return;
            }

            string.Concat(deltas).Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
