# Edit Image Simple Edit



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // First generate an image to edit
    var original = await client.GenerateImageAsync(
        prompt: "A plain white background",
        imageSize: "1K");

    var edited = await client.EditImageAsync(
        prompt: "Add a red circle in the center",
        imageData: original.ImageData!,
        mimeType: original.MimeType ?? "image/png",
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```