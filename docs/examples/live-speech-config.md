# Live Speech Config



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Connects with a speech config to select a specific voice.
    var config = CreateLiveConfig();
    config.GenerationConfig!.SpeechConfig = new SpeechConfig
    {
        VoiceConfig = new VoiceConfig
        {
            PrebuiltVoiceConfig = new PrebuiltVoiceConfig
            {
                VoiceName = "Kore",
            },
        },
    };

    await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

    // Send a message — voice selection is applied at setup time.
    await session.SendTextAsync("Say hello", cts.Token);

    bool receivedResponse = false;
    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
        {
            receivedResponse = true;
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