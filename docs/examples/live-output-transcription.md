# Live Output Transcription



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Enables output audio transcription to receive text alongside audio.
    var config = CreateLiveConfig();
    config.OutputAudioTranscription = new LiveOutputAudioTranscription();

    await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

    // Send a text message and collect transcription events.
    await session.SendTextAsync("Say the word hello", cts.Token);

    bool receivedTranscription = false;
    bool receivedAudio = false;
    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
        {
            receivedAudio = true;
        }

        if (message.ServerContent?.OutputTranscription?.Text is { Length: > 0 })
        {
            receivedTranscription = true;
        }

        if (message.ServerContent?.TurnComplete == true)
        {
            break;
        }
    }

}
catch (WebSocketException ex)
{
}
catch (OperationCanceledException)
{
}
```