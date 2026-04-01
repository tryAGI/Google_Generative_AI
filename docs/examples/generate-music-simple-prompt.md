# Generate Music Simple Prompt



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Generate a short music clip from a text prompt using the Lyria 3 Clip model.
    var result = await client.GenerateMusicAsync(
        prompt: "A cheerful acoustic guitar melody with a light percussion beat, major key, 120 BPM");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```