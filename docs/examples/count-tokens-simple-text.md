# Count Tokens Simple Text



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
                Parts = [new Part { Text = "Hello, world! This is a test of token counting." }],
            },
        ]);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```