# Generate Music With Lyrics



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Generate music with vocals using structure tags and lyrics.
    var result = await client.GenerateMusicAsync(
        prompt: """
            Pop ballad, female vocal, piano accompaniment, 90 BPM, C major

            [Verse]
            Walking through the morning light,
            Everything feels warm and bright.

            [Chorus]
            This is where I want to be,
            Under skies so wide and free.
            """);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```