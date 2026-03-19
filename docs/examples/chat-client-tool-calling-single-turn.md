# Chat Client Tool Calling Single Turn



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

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```