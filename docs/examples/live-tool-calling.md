# Live Tool Calling



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

try
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

    // Connects to the Live API with a tool and handles a function call.
    // Use ParametersJsonSchema when you need to send raw JSON Schema features
    // such as additionalProperties, exact property ordering, or nested metadata.
    var weatherSchema = JsonDocument.Parse("""
        {
          "type": "object",
          "additionalProperties": false,
          "propertyOrdering": ["location", "units", "preferences"],
          "properties": {
            "location": {
              "type": "string",
              "description": "The city name"
            },
            "units": {
              "type": "string",
              "enum": ["celsius", "fahrenheit"],
              "description": "Preferred temperature unit"
            },
            "preferences": {
              "type": "object",
              "description": "Optional weather display preferences",
              "additionalProperties": false,
              "propertyOrdering": ["includeHumidity"],
              "properties": {
                "includeHumidity": {
                  "type": "boolean",
                  "description": "Whether to include humidity in the response"
                }
              }
            }
          },
          "required": ["location"]
        }
        """).RootElement.Clone();

    var config = CreateLiveConfig();
    config.Tools =
    [
        new Tool
        {
            FunctionDeclarations =
            [
                new FunctionDeclaration
                {
                    Name = "get_weather",
                    Description = "Get the current weather for a location",
                    ParametersJsonSchema = weatherSchema,
                },
            ],
        },
    ];

    await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

    // Ask about weather to trigger the tool call.
    await session.SendTextAsync("What is the weather in London? Use the get_weather tool.", cts.Token);

    // Read until we get a tool call or turn complete.
    LiveToolCall? toolCall = null;
    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        if (message.ToolCall is not null)
        {
            toolCall = message.ToolCall;
            break;
        }

        if (message.ServerContent?.TurnComplete == true)
        {
            break;
        }
    }

    // Send a tool response.
    await session.SendToolResponseAsync(
    [
        new FunctionResponse
        {
            Name = "get_weather",
            Id = toolCall.FunctionCalls[0].Id,
            Response = new { temperature = "15C", condition = "cloudy" },
        },
    ], cts.Token);

    // Read until turn is complete.
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