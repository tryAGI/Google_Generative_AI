# Speak Different Voice



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.SpeakAsync(
        text: "Say calmly: Testing with a different voice. This should sound professional.",
        voiceName: "Kore");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```