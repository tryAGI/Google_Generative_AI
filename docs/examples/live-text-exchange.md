# Live Text Exchange



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Connects to the Gemini Live API, sends text, receives audio response.
    await using var session = await client.ConnectLiveAsync(CreateLiveConfig(), cancellationToken: cts.Token);

    // Send a simple text message.
    await session.SendTextAsync("Say hello", cts.Token);

    // Read events until the model turn is complete.
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