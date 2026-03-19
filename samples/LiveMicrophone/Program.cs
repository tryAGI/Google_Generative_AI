using System.Diagnostics;
using System.Runtime.InteropServices;
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
        SpeechConfig = new SpeechConfig
        {
            VoiceConfig = new VoiceConfig
            {
                PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                {
                    VoiceName = "Kore",
                },
            },
        },
    },
    OutputAudioTranscription = new LiveOutputAudioTranscription(),
    InputAudioTranscription = new LiveInputAudioTranscription(),
    SystemInstruction = new Content
    {
        Parts = [new Part { Text = "You are a helpful voice assistant. Keep responses concise — under 2 sentences." }],
    },
};

Console.WriteLine("Connecting to Gemini Live API...");
await using var session = await client.ConnectResilientLiveAsync(config, cancellationToken: cts.Token);
Console.WriteLine("Connected!");

// Detect and start the platform microphone capture process
var (recProcess, recDescription) = StartMicrophoneCapture();
if (recProcess == null)
{
    Console.WriteLine("No supported audio capture tool found.");
    Console.WriteLine("Install one of: sox (rec), arecord (Linux), or ffmpeg.");
    Console.WriteLine("  macOS:  brew install sox");
    Console.WriteLine("  Linux:  sudo apt install sox / alsa-utils");
    Console.WriteLine("  Any:    brew/apt/choco install ffmpeg");
    return;
}

Console.WriteLine($"Microphone: {recDescription}");
Console.WriteLine("Speak into your microphone. Ctrl+C to quit.\n");

// Stream microphone audio to Gemini in a background task
var micTask = Task.Run(async () =>
{
    var buffer = new byte[3200]; // 100ms of 16kHz 16-bit mono PCM
    var stream = recProcess.StandardOutput.BaseStream;

    try
    {
        while (!cts.Token.IsCancellationRequested)
        {
            var bytesRead = await stream.ReadAtLeastAsync(buffer, buffer.Length, throwOnEndOfStream: false, cts.Token);
            if (bytesRead == 0)
                break;

            await session.SendAudioAsync(buffer.AsMemory(0, bytesRead), cts.Token);
        }
    }
    catch (OperationCanceledException) { }
}, cts.Token);

// Collect audio response for WAV saving
var turnNumber = 0;

// Read events from the server
try
{
    await foreach (var message in session.ReadEventsAsync(cts.Token))
    {
        // Input transcription — what you said
        if (message.ServerContent?.InputTranscription?.Text is { } inputText)
        {
            Console.Write($"\r\x1b[KYou: {inputText}");
        }

        // Output transcription — what the model said
        if (message.ServerContent?.OutputTranscription?.Text is { } outputText)
        {
            Console.Write($"\r\x1b[KGemini: {outputText}");
        }

        // Collect audio response and save as WAV
        if (message.ServerContent?.ModelTurn?.Parts is { } parts)
        {
            foreach (var part in parts)
            {
                if (part.InlineData?.Data is { Length: > 0 } audioData)
                {
                    // Save each turn's audio to a WAV file
                    var currentTurn = Interlocked.Increment(ref turnNumber);
                    var wavPath = Path.Combine(Directory.GetCurrentDirectory(), $"mic_response_{currentTurn:D3}.wav");
                    WriteWavFile(wavPath, audioData, sampleRate: 24000, bitsPerSample: 16, channels: 1);
                }
            }
        }

        if (message.ServerContent?.Interrupted == true)
        {
            Console.Write(" [interrupted]");
        }

        if (message.ServerContent?.TurnComplete == true)
        {
            Console.WriteLine();
        }

        if (message.UsageMetadata is { } usage)
        {
            Console.WriteLine($"  [Tokens: {usage.TotalTokenCount}]");
        }
    }
}
catch (OperationCanceledException) { }

// Cleanup
try { recProcess.Kill(); } catch { }
recProcess.Dispose();
await micTask;

Console.WriteLine("\nSession ended.");

/// <summary>
/// Starts a platform-appropriate microphone capture process outputting 16-bit PCM at 16kHz mono to stdout.
/// </summary>
static (Process? process, string description) StartMicrophoneCapture()
{
    // Try sox (rec) — cross-platform, most common
    var recPath = FindExecutable("rec");
    if (recPath != null)
    {
        var process = StartProcess(recPath, [
            "-q",                    // quiet
            "-r", "16000",           // 16kHz
            "-b", "16",              // 16-bit
            "-c", "1",               // mono
            "-e", "signed-integer",  // signed PCM
            "-t", "raw",             // raw output
            "-",                     // to stdout
        ]);
        return (process, "sox (rec)");
    }

    // Try arecord — Linux ALSA
    if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        var arecordPath = FindExecutable("arecord");
        if (arecordPath != null)
        {
            var process = StartProcess(arecordPath, [
                "-q",                // quiet
                "-f", "S16_LE",      // 16-bit signed little-endian
                "-r", "16000",       // 16kHz
                "-c", "1",           // mono
                "-t", "raw",         // raw output
                "--",
            ]);
            return (process, "arecord (ALSA)");
        }
    }

    // Try ffmpeg — cross-platform fallback
    var ffmpegPath = FindExecutable("ffmpeg");
    if (ffmpegPath != null)
    {
        string inputDevice;
        string inputFormat;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            inputFormat = "avfoundation";
            inputDevice = ":0"; // default audio input
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            inputFormat = "dshow";
            inputDevice = "audio=Microphone"; // may need adjustment
        }
        else
        {
            inputFormat = "pulse";
            inputDevice = "default";
        }

        var process = StartProcess(ffmpegPath, [
            "-f", inputFormat,
            "-i", inputDevice,
            "-ar", "16000",         // 16kHz
            "-ac", "1",             // mono
            "-f", "s16le",          // 16-bit signed little-endian PCM
            "-loglevel", "error",
            "pipe:1",               // to stdout
        ]);
        return (process, $"ffmpeg ({inputFormat})");
    }

    return (null, "none");
}

static Process? StartProcess(string fileName, string[] args)
{
    var psi = new ProcessStartInfo
    {
        FileName = fileName,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true,
    };
    foreach (var arg in args)
        psi.ArgumentList.Add(arg);

    return Process.Start(psi);
}

static string? FindExecutable(string name)
{
    try
    {
        var psi = new ProcessStartInfo
        {
            FileName = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "where" : "which",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        psi.ArgumentList.Add(name);

        using var process = Process.Start(psi);
        var output = process?.StandardOutput.ReadToEnd().Trim();
        process?.WaitForExit();
        return process?.ExitCode == 0 && !string.IsNullOrEmpty(output) ? output.Split('\n')[0].Trim() : null;
    }
    catch
    {
        return null;
    }
}

/// <summary>
/// Writes raw PCM audio data as a WAV file.
/// </summary>
static void WriteWavFile(string path, byte[] pcmData, int sampleRate, int bitsPerSample, int channels)
{
    var byteRate = sampleRate * channels * bitsPerSample / 8;
    var blockAlign = channels * bitsPerSample / 8;

    using var fs = System.IO.File.Create(path);
    using var writer = new BinaryWriter(fs);

    // RIFF header
    writer.Write("RIFF"u8);
    writer.Write(36 + pcmData.Length);
    writer.Write("WAVE"u8);

    // fmt sub-chunk
    writer.Write("fmt "u8);
    writer.Write(16);
    writer.Write((short)1);
    writer.Write((short)channels);
    writer.Write(sampleRate);
    writer.Write(byteRate);
    writer.Write((short)blockAlign);
    writer.Write((short)bitsPerSample);

    // data sub-chunk
    writer.Write("data"u8);
    writer.Write(pcmData.Length);
    writer.Write(pcmData);
}
