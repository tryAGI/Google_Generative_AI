# Live Audio Round Trip



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Sends PCM audio and verifies audio parts are received in the response.
    await using var session = await client.ConnectLiveAsync(CreateLiveConfig(), cancellationToken: cts.Token);

    // Generate a short 16-bit PCM 16kHz sine wave (0.5s of 440Hz tone).
    var sampleRate = 16000;
    var samples = (int)(sampleRate * 0.5);
    var pcmBytes = new byte[samples * 2];
    for (int i = 0; i < samples; i++)
    {
        var sample = (short)(Math.Sin(2 * Math.PI * 440 * i / sampleRate) * 8000);
        pcmBytes[i * 2] = (byte)(sample & 0xFF);
        pcmBytes[i * 2 + 1] = (byte)((sample >> 8) & 0xFF);
    }

    await session.SendAudioAsync(pcmBytes, cts.Token);

    // Also send text to ensure a response is triggered.
    await session.SendTextAsync("Repeat what you heard", cts.Token);

    bool receivedAudioParts = false;
    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        if (message.ServerContent?.ModelTurn?.Parts is { } parts)
        {
            foreach (var part in parts)
            {
                if (part.InlineData?.Data is { Length: > 0 })
                {
                    receivedAudioParts = true;
                }
            }
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