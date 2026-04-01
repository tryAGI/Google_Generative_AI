# Live Resilient Session



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Connects using ResilientLiveSession and verifies basic text exchange works.
    var config = CreateLiveConfig();

    await using var session = await client.ConnectResilientLiveAsync(
        config,
        cancellationToken: cts.Token);

    // Send a text message through the resilient session.
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