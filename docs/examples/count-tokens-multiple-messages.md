# Count Tokens Multiple Messages



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var response = await client.ModelsCountTokensAsync(
        modelsId: modelId,
        contents:
        [
            new Content
            {
                Role = "user",
                Parts = [new Part { Text = "What is the meaning of life?" }],
            },
            new Content
            {
                Role = "model",
                Parts = [new Part { Text = "The meaning of life is a philosophical question." }],
            },
            new Content
            {
                Role = "user",
                Parts = [new Part { Text = "Can you elaborate?" }],
            },
        ]);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```