# Generate Image With Aspect Ratio



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.GenerateImageAsync(
        prompt: "A landscape with mountains",
        imageSize: "1K",
        aspectRatio: "16:9");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```