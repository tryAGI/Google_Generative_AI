# Embedding Generator Single Input



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetEmbeddingModelId();

try
{
    IEmbeddingGenerator<string, Embedding<float>> generator = client;
    var result = await generator.GenerateAsync(
        values: ["Hello, world!"],
        options: new EmbeddingGenerationOptions
        {
            ModelId = modelId,
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```