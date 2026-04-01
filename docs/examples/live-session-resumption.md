# Live Session Resumption



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(60));

    // Connects with session resumption enabled, exchanges a message,
    // then reconnects using the resumption handle via ReconnectLiveAsync.
    var config = CreateLiveConfig();
    config.SessionResumption = new LiveSessionResumptionConfig();

    // First session: send a message and collect the resumption handle.
    // The handle arrives asynchronously — keep reading after turnComplete.
    string? resumptionHandle;
    await using (var session1 = await client.ConnectLiveAsync(config, cancellationToken: cts.Token))
    {
        await session1.SendTextAsync("Remember: the secret word is banana.", cts.Token);

        bool turnDone = false;
        await foreach (var message in session1.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.TurnComplete == true)
            {
                turnDone = true;
            }

            // Once turn is done AND we have a handle, stop
            if (turnDone && session1.LastSessionResumptionHandle is { Length: > 0 })
            {
                break;
            }
        }

        resumptionHandle = session1.LastSessionResumptionHandle;
    }

    if (string.IsNullOrEmpty(resumptionHandle))
    {
    }

    // Second session: reconnect using ReconnectLiveAsync.
    var config2 = CreateLiveConfig();
    config2.SessionResumption = new LiveSessionResumptionConfig
    {
        Handle = resumptionHandle,
    };

    await using var session2 = await client.ConnectLiveAsync(config2, cancellationToken: cts.Token);

    await session2.SendTextAsync("What was the secret word?", cts.Token);

    bool receivedResponse = false;
    await foreach (var message in session2.ReadEventsAsync(cts.Token))
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