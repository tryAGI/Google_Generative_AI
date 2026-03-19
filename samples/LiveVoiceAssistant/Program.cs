using Google.Gemini;

// Get API key from environment variable
var apiKey = Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY")
    ?? throw new InvalidOperationException(
        "Set the GOOGLE_GEMINI_API_KEY environment variable.");

using var client = new GeminiClient(apiKey);
using var cts = new CancellationTokenSource();

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    cts.Cancel();
};

// Configure the Live API session
var config = new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    // Get text transcriptions of audio responses
    OutputAudioTranscription = new LiveOutputAudioTranscription(),
    // Compress context for longer sessions
    ContextWindowCompression = new LiveContextWindowCompression
    {
        SlidingWindow = new LiveSlidingWindow { TargetTokens = 2048 },
    },
    SystemInstruction = new Content
    {
        Parts = [new Part { Text = "You are a helpful voice assistant. Keep responses concise." }],
    },
};

Console.WriteLine("Connecting to Gemini Live API...");

// Use ResilientLiveSession for automatic reconnection on GoAway
await using var session = await client.ConnectResilientLiveAsync(
    config,
    cancellationToken: cts.Token);

session.GoAwayReceived += (_, goAway) =>
    Console.WriteLine($"\n  [Server closing in {goAway.TimeLeft}, reconnecting...]");
session.Reconnected += (_, _) =>
    Console.WriteLine("  [Reconnected successfully]");

Console.WriteLine("Connected! Type messages and press Enter. Ctrl+C to quit.\n");

// Main conversation loop
while (!cts.Token.IsCancellationRequested)
{
    Console.Write("You: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
        continue;

    // Send user text
    await session.SendTextAsync(input, cts.Token);

    // Read the model's response
    Console.Write("Gemini: ");
    var audioChunks = 0;

    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        // Print text transcription of audio response
        if (message.ServerContent?.OutputTranscription?.Text is { } text)
        {
            Console.Write(text);
        }

        // Count audio chunks (in a real app, you'd play these)
        if (message.ServerContent?.ModelTurn?.Parts is { } parts)
        {
            foreach (var part in parts)
            {
                if (part.InlineData?.Data is { Length: > 0 })
                    audioChunks++;
            }
        }

        // Handle interruption
        if (message.ServerContent?.Interrupted == true)
        {
            Console.Write(" [interrupted]");
        }

        // Handle tool calls (if any tools were configured)
        if (message.ToolCall is { } toolCall)
        {
            Console.Write($"\n  [Tool call: {toolCall.FunctionCalls?[0].Name}]");
        }

        // Handle tool call cancellations
        if (message.ToolCallCancellation is { } cancellation)
        {
            Console.Write($"\n  [Tool calls cancelled: {string.Join(", ", cancellation.Ids!)}]");
        }

        // Track token usage
        if (message.UsageMetadata is { } usage)
        {
            Console.Write($"\n  [Tokens: {usage.TotalTokenCount}]");
        }

        if (message.ServerContent?.TurnComplete == true)
            break;
    }

    if (audioChunks > 0)
    {
        Console.Write($" ({audioChunks} audio chunks)");
    }

    Console.WriteLine();

    if (session.ReconnectCount > 0)
    {
        Console.WriteLine($"  [Reconnections: {session.ReconnectCount}]");
    }
}

Console.WriteLine("\nSession ended.");
if (session.LastSessionResumptionHandle is { Length: > 0 } handle)
{
    Console.WriteLine($"Resumption handle: {handle[..Math.Min(20, handle.Length)]}...");
}
