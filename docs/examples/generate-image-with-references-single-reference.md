# Generate Image With References Single Reference



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // This example uses native image output and therefore requires
    // a Paid Tier Gemini API project and API key.
    // First generate a reference image
    var reference = await client.GenerateImageAsync(
        prompt: "A simple red square",
        imageSize: "1K");

    var result = await client.GenerateImageWithReferencesAsync(
        prompt: "Create a similar shape but in blue",
        referenceImages: [(reference.ImageData!, reference.MimeType ?? "image/png")],
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```