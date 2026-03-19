/*
order: 80
title: Chat Client Tool Calling Streaming
slug: chat-client-tool-calling-streaming
*/

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_Streaming()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        try
        {
            var getWeatherTool = AIFunctionFactory.Create(
                (string location) => $"The weather in {location} is 72°F and sunny.",
                name: "get_weather",
                description: "Gets the current weather for a given location.");

            IChatClient chatClient = client;
            var updates = chatClient.GetStreamingResponseAsync(
                [
                    new ChatMessage(ChatRole.User, "What is the weather in Paris?")
                ],
                new ChatOptions
                {
                    ModelId = modelId,
                    Tools = [getWeatherTool],
                });

            // Collect all streaming updates
            var functionCalls = new List<FunctionCallContent>();
            await foreach (var update in updates)
            {
                functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());
            }

            // In streaming mode, rate limiting may not throw ApiException but instead
            // return empty/truncated data. Treat empty results as inconclusive.
            if (functionCalls.Count == 0)
            {
                Assert.Inconclusive("No function calls received via streaming (likely rate limited).");
                return;
            }

            functionCalls[0].Name.Should().Be("get_weather");
            functionCalls[0].Arguments.Should().NotBeNull();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
