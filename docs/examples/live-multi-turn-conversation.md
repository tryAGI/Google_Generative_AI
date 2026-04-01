# Live Multi-Turn Conversation



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Demonstrates a multi-turn conversation using sequential text exchanges.
    await using var session = await client.ConnectLiveAsync(CreateLiveConfig(), cancellationToken: cts.Token);

    // First turn: tell the model a fact.
    await session.SendTextAsync("My name is Alice", cts.Token);

    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        if (message.ServerContent?.TurnComplete == true)
        {
            break;
        }
    }

    // Second turn: ask the model to recall the fact.
    await session.SendTextAsync("What is my name?", cts.Token);

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