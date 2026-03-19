# Chat Client Five Random Words



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    IChatClient chatClient = client;
    var response = await chatClient.GetResponseAsync(
        messages:
        [
            new ChatMessage(ChatRole.User, "Generate 5 random words.")
        ],
        options: new ChatOptions
        {
            ModelId = modelId,
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```