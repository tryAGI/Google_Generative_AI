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

    [TestMethod]
    public async Task ChatClient_ToolCalling_MultiTurn()
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
            var messages = new List<ChatMessage>
            {
                new(ChatRole.User, "What is the weather in Paris?"),
            };

            // First turn: model requests tool call
            var response = await chatClient.GetResponseAsync(
                messages,
                new ChatOptions
                {
                    ModelId = modelId,
                    Tools = [getWeatherTool],
                });

            var functionCall = response.Messages
                .SelectMany(m => m.Contents)
                .OfType<FunctionCallContent>()
                .FirstOrDefault();

            functionCall.Should().NotBeNull("the model should request a tool call");

            // Add assistant message with function call and tool result
            messages.AddRange(response.Messages);
            var toolResult = await getWeatherTool.InvokeAsync(
                functionCall!.Arguments is { } args ? new AIFunctionArguments(args) : null);
            messages.Add(new ChatMessage(ChatRole.Tool,
            [
                new FunctionResultContent(functionCall.CallId, toolResult),
            ]));

            // Second turn: model should produce a final text response
            var finalResponse = await chatClient.GetResponseAsync(
                messages,
                new ChatOptions
                {
                    ModelId = modelId,
                    Tools = [getWeatherTool],
                });

            finalResponse.Text.Should().NotBeNullOrWhiteSpace();
            finalResponse.Text.Should().Contain("72", "the response should include information from the tool result");
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }

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

            functionCalls.Should().NotBeEmpty("the model should request a tool call via streaming");
            functionCalls[0].Name.Should().Be("get_weather");
            functionCalls[0].Arguments.Should().NotBeNull();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
