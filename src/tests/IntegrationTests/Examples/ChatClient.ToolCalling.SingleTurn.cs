/*
order: 70
title: Chat Client Tool Calling Single Turn
slug: chat-client-tool-calling-single-turn
*/

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_SingleTurn()
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
            var response = await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User, "What is the weather in Paris?")
                ],
                new ChatOptions
                {
                    ModelId = modelId,
                    Tools = [getWeatherTool],
                });

            // The model should request a tool call
            var functionCall = response.Messages
                .SelectMany(m => m.Contents)
                .OfType<FunctionCallContent>()
                .FirstOrDefault();

            functionCall.Should().NotBeNull();
            functionCall!.Name.Should().Be("get_weather");
            functionCall.Arguments.Should().NotBeNull();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
