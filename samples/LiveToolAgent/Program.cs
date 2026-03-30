using System.Text.Json;
using Google.Gemini;

// Get API key from environment variable
var apiKey = Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY")
    ?? throw new InvalidOperationException(
        "Set the GOOGLE_GEMINI_API_KEY environment variable.");

// --text flag switches to text-only mode (no audio tools needed)
var textMode = args.Contains("--text", StringComparer.OrdinalIgnoreCase);

using var client = new GeminiClient(apiKey);
using var cts = new CancellationTokenSource();

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    cts.Cancel();
};

// Define tools the model can call
var tools = new Tool
{
    FunctionDeclarations =
    [
        new FunctionDeclaration
        {
            Name = "get_weather",
            Description = "Get the current weather for a city",
            Parameters = new Schema
            {
                Type = SchemaType.Object,
                Properties = new Dictionary<string, Schema>
                {
                    ["city"] = new Schema
                    {
                        Type = SchemaType.String,
                        Description = "The city name (e.g., London, Tokyo, New York)",
                    },
                },
                Required = ["city"],
            },
        },
        new FunctionDeclaration
        {
            Name = "get_time",
            Description = "Get the current time in a timezone",
            Parameters = new Schema
            {
                Type = SchemaType.Object,
                Properties = new Dictionary<string, Schema>
                {
                    ["timezone"] = new Schema
                    {
                        Type = SchemaType.String,
                        Description = "The IANA timezone (e.g., America/New_York, Europe/London, Asia/Tokyo)",
                    },
                },
                Required = ["timezone"],
            },
        },
        new FunctionDeclaration
        {
            Name = "calculate",
            Description = "Evaluate a simple math expression",
            Parameters = new Schema
            {
                Type = SchemaType.Object,
                Properties = new Dictionary<string, Schema>
                {
                    ["expression"] = new Schema
                    {
                        Type = SchemaType.String,
                        Description = "The math expression (e.g., 2+2, 15*3, 100/4)",
                    },
                },
                Required = ["expression"],
            },
        },
    ],
};

// Configure the Live API session with tools
// In text mode, use gemini-2.0-flash with Text modality (no audio needed).
// In audio mode, use native-audio model with Audio modality + transcription.
var config = new LiveSetupConfig
{
    Model = textMode
        ? "models/gemini-2.0-flash"
        : "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = textMode
            ? [GenerationConfigResponseModalitie.Text]
            : [GenerationConfigResponseModalitie.Audio],
    },
    Tools = [tools],
    SystemInstruction = new Content
    {
        Parts = [new Part
        {
            Text = """
                You are a helpful assistant with access to tools.
                Use the get_weather tool when asked about weather.
                Use the get_time tool when asked about the current time.
                Use the calculate tool for math questions.
                Always use the appropriate tool rather than guessing.
                Keep responses concise.
                """,
        }],
    },
};

// Add transcription in audio mode
if (!textMode)
{
    config.OutputAudioTranscription = new LiveOutputAudioTranscription();
}

var modeLabel = textMode ? "text" : "audio";
Console.WriteLine($"Connecting to Gemini Live API ({modeLabel} mode)...");
await using var session = await client.ConnectResilientLiveAsync(config, cancellationToken: cts.Token);
Console.WriteLine("Connected! This agent has tools: get_weather, get_time, calculate");
Console.WriteLine("Try: \"What's the weather in Tokyo?\" or \"What time is it in London?\"");
if (!textMode)
    Console.WriteLine("Tip: Run with --text for text-only mode (no audio tools needed).");
Console.WriteLine("Type messages and press Enter. Ctrl+C to quit.\n");

// Main conversation loop
while (!cts.Token.IsCancellationRequested)
{
    Console.Write("You: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
        continue;

    await session.SendTextAsync(input, cts.Token);

    // Process response, handling tool calls in a loop
    await ProcessResponseAsync(session, textMode, cts.Token);
    Console.WriteLine();
}

Console.WriteLine("\nSession ended.");

async Task ProcessResponseAsync(ResilientLiveSession liveSession, bool isTextMode, CancellationToken ct)
{
    Console.Write("Gemini: ");

    await foreach (var message in liveSession.ReadEventsAsync(ct))
    {
        // Text mode: model responds with text parts directly
        if (isTextMode && message.ServerContent?.ModelTurn?.Parts is { } textParts)
        {
            foreach (var part in textParts)
            {
                if (part.Text is { } partText)
                {
                    Console.Write(partText);
                }
            }
        }

        // Audio mode: use output transcription for readable text
        if (!isTextMode && message.ServerContent?.OutputTranscription?.Text is { } transcript)
        {
            Console.Write(transcript);
        }

        // Handle tool calls
        if (message.ToolCall is { FunctionCalls: { } calls })
        {
            Console.WriteLine();
            var responses = new List<FunctionResponse>();

            foreach (var call in calls)
            {
                Console.WriteLine($"  [Tool: {call.Name}({FormatArgs(call.Args)})]");

                var result = ExecuteTool(call.Name!, call.Args);
                Console.WriteLine($"  [Result: {result}]");

                responses.Add(new FunctionResponse
                {
                    Name = call.Name,
                    Id = call.Id,
                    Response = JsonSerializer.Deserialize<object>(result),
                });
            }

            // Send all tool responses
            await liveSession.SendToolResponseAsync(responses, ct);
            Console.Write("Gemini: ");

            // Continue reading — model will generate a response using tool results
            continue;
        }

        // Handle tool call cancellations
        if (message.ToolCallCancellation is { Ids: { } ids })
        {
            Console.Write($"\n  [Tool calls cancelled: {string.Join(", ", ids)}]");
        }

        if (message.ServerContent?.Interrupted == true)
        {
            Console.Write(" [interrupted]");
        }

        if (message.UsageMetadata is { } usage)
        {
            var tokens = usage.TotalTokenCount ?? usage.ResponseTokenCount;
            if (tokens > 0)
                Console.Write($"\n  [Tokens: {tokens}]");
        }

        if (message.ServerContent?.TurnComplete == true)
        {
            break;
        }
    }
}

/// <summary>
/// Executes a tool call and returns the JSON result.
/// </summary>
string ExecuteTool(string name, object? args)
{
    var argsJson = args is JsonElement je ? je : default;

    return name switch
    {
        "get_weather" => GetWeather(argsJson.GetProperty("city").GetString() ?? "Unknown"),
        "get_time" => GetTime(argsJson.GetProperty("timezone").GetString() ?? "UTC"),
        "calculate" => Calculate(argsJson.GetProperty("expression").GetString() ?? "0"),
        _ => JsonSerializer.Serialize(new { error = $"Unknown tool: {name}" }),
    };
}

string GetWeather(string city)
{
    // Simulated weather data — in a real app, call a weather API
    var random = new Random(city.GetHashCode());
    var conditions = new[] { "sunny", "cloudy", "rainy", "partly cloudy", "overcast", "clear" };
    var temp = random.Next(-5, 40);
    var condition = conditions[random.Next(conditions.Length)];
    var humidity = random.Next(30, 95);

    return JsonSerializer.Serialize(new
    {
        city,
        temperature = $"{temp}°C",
        condition,
        humidity = $"{humidity}%",
    });
}

string GetTime(string timezone)
{
    try
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById(timezone);
        var time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
        return JsonSerializer.Serialize(new
        {
            timezone,
            time = time.ToString("HH:mm:ss"),
            date = time.ToString("yyyy-MM-dd"),
        });
    }
    catch
    {
        return JsonSerializer.Serialize(new
        {
            timezone,
            error = "Unknown timezone. Use IANA format like America/New_York.",
        });
    }
}

string Calculate(string expression)
{
    try
    {
        // Simple expression evaluator for basic math
        var result = EvaluateSimpleExpression(expression);
        return JsonSerializer.Serialize(new { expression, result });
    }
    catch
    {
        return JsonSerializer.Serialize(new { expression, error = "Could not evaluate expression" });
    }
}

double EvaluateSimpleExpression(string expr)
{
    // Simple evaluator supporting +, -, *, / with two operands
    expr = expr.Trim();

    foreach (var op in new[] { '+', '-', '*', '/' })
    {
        // Find operator that's not at the start (to handle negative numbers)
        var idx = expr.LastIndexOf(op);
        if (idx > 0)
        {
            var left = double.Parse(expr[..idx].Trim());
            var right = double.Parse(expr[(idx + 1)..].Trim());
            return op switch
            {
                '+' => left + right,
                '-' => left - right,
                '*' => left * right,
                '/' => left / right,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    return double.Parse(expr);
}

static string FormatArgs(object? args)
{
    if (args is JsonElement je)
    {
        var parts = new List<string>();
        foreach (var prop in je.EnumerateObject())
        {
            parts.Add($"{prop.Name}: {prop.Value}");
        }
        return string.Join(", ", parts);
    }
    return args?.ToString() ?? "";
}
