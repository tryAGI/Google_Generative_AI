# Chat Client Five Random Words Streaming



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
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
        return;
    }

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```