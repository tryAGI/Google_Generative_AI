# Transcribe Generated Audio



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // First generate audio to transcribe
    var audio = await client.SpeakAsync(
        text: "Read aloud: The quick brown fox jumps over the lazy dog.");

    var transcription = await client.TranscribeAsync(
        audioData: audio.AudioData!,
        mimeType: audio.MimeType ?? "audio/wav");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```