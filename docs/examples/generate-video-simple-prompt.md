# Generate Video Simple Prompt



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.GenerateVideoAsync(
        prompt: "A serene beach at sunset with gentle waves");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
    // VIDEO modality may not be supported in generateContent endpoint yet
}
```