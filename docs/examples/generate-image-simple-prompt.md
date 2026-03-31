# Generate Image Simple Prompt



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Native image output models such as gemini-2.5-flash-image currently
    // require a Paid Tier Gemini API project and API key.
    var result = await client.GenerateImageAsync(
        prompt: "A simple red circle on a white background",
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```