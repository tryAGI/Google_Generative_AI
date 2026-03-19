# Chat Client Tool Calling Streaming



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
        return;
    }

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```