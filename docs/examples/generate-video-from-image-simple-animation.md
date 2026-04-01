# Generate Video From Image Simple Animation



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var image = await client.GenerateImageAsync(
        prompt: "A still landscape with mountains and a lake",
        imageSize: "1K");

    var result = await client.GenerateVideoFromImageAsync(
        prompt: "Animate the clouds moving slowly across the sky",
        imageData: image.ImageData!,
        mimeType: image.MimeType ?? "image/png");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```