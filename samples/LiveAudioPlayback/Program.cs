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

// Configure the Live API session with audio output
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
        SpeechConfig = new SpeechConfig
        {
            VoiceConfig = new VoiceConfig
            {
                PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                {
                    VoiceName = "Kore", // Aoede, Charon, Fenrir, Kore, Puck, etc.
                },
            },
        },
    },
    OutputAudioTranscription = new LiveOutputAudioTranscription(),
    SystemInstruction = new Content
    {
        Parts = [new Part { Text = "You are a friendly assistant. Keep responses under 2 sentences." }],
    },
};

Console.WriteLine("Connecting to Gemini Live API...");
await using var session = await client.ConnectResilientLiveAsync(config, cancellationToken: cts.Token);
Console.WriteLine("Connected! Type messages and press Enter. Ctrl+C to quit.");
Console.WriteLine("Audio responses are saved as WAV files in the current directory.\n");

var turnNumber = 0;

while (!cts.Token.IsCancellationRequested)
{
    Console.Write("You: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
        continue;

    turnNumber++;
    await session.SendTextAsync(input, cts.Token);

    Console.Write("Gemini: ");

    // Collect all audio chunks for this turn
    using var audioStream = new MemoryStream();
    var transcription = string.Empty;

    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        // Collect audio data from model response
        if (message.ServerContent?.ModelTurn?.Parts is { } parts)
        {
            foreach (var part in parts)
            {
                if (part.InlineData?.Data is { Length: > 0 } audioData)
                {
                    audioStream.Write(audioData, 0, audioData.Length);
                }
            }
        }

        // Collect transcription text
        if (message.ServerContent?.OutputTranscription?.Text is { } text)
        {
            transcription += text;
            Console.Write(text);
        }

        if (message.ServerContent?.Interrupted == true)
        {
            Console.Write(" [interrupted]");
        }

        if (message.ServerContent?.TurnComplete == true)
            break;
    }

    Console.WriteLine();

    // Save audio as WAV file if we received any audio data
    if (audioStream.Length > 0)
    {
        var pcmData = audioStream.ToArray();
        var wavPath = Path.Combine(Directory.GetCurrentDirectory(), $"response_{turnNumber:D3}.wav");
        new AudioResult { AudioData = pcmData }.WriteWavFile(wavPath, sampleRate: 24000);
        Console.WriteLine($"  Audio saved: {wavPath} ({pcmData.Length:N0} bytes PCM, {pcmData.Length / 48000.0:F1}s)\n");
    }
    else
    {
        Console.WriteLine("  (no audio received)\n");
    }
}

Console.WriteLine("\nSession ended.");
