# Speak Simple Text



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.SpeakAsync(
        text: "Say cheerfully: Hello, this is a test of text to speech. Have a wonderful day!",
        voiceName: "Puck");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```