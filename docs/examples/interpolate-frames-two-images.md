# Interpolate Frames Two Images



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var startFrame = await client.GenerateImageAsync(
        prompt: "A red circle on a white background",
        imageSize: "1K");

    var endFrame = await client.GenerateImageAsync(
        prompt: "A blue square on a white background",
        imageSize: "1K");

    var result = await client.InterpolateFramesAsync(
        startFrame: startFrame.ImageData!,
        endFrame: endFrame.ImageData!,
        prompt: "Smoothly transition between the two shapes");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```