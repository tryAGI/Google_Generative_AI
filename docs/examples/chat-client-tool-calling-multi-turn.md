# Chat Client Tool Calling Multi Turn



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
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

    // Verify thought signature is preserved on function call content
    // (Gemini API requires it to be echoed back in subsequent turns)
    if (functionCall!.AdditionalProperties?.TryGetValue("gemini.thoughtSignature", out var sig) == true)
    {
    }

    // Add assistant message with function call and tool result
    messages.AddRange(response.Messages);
    var toolResult = await getWeatherTool.InvokeAsync(
        functionCall.Arguments is { } args ? new AIFunctionArguments(args) : null);
    messages.Add(new ChatMessage(ChatRole.Tool,
    [
        new FunctionResultContent(functionCall.CallId, toolResult),
    ]));

    // Second turn: model should produce a final text response
    // (this verifies the thought signature round-trip works — the API
    // rejects requests with missing thought signatures)
    var finalResponse = await chatClient.GetResponseAsync(
        messages,
        new ChatOptions
        {
            ModelId = modelId,
            Tools = [getWeatherTool],
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```