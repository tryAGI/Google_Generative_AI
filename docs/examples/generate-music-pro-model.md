# Generate Music Pro Model



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Generate a longer music piece using the Lyria 3 Pro model.
    var result = await client.GenerateMusicAsync(
        prompt: "Epic orchestral soundtrack with strings, brass, and timpani, building from soft to powerful, D minor, 100 BPM",
        modelId: "lyria-3-pro-preview");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```