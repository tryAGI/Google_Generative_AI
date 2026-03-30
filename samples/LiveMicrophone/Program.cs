using System.Diagnostics;
using System.Runtime.InteropServices;
using Google.Gemini;

// Get API key from environment variable
var apiKey = Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY")
    ?? throw new InvalidOperationException(
        "Set the GOOGLE_GEMINI_API_KEY environment variable.");

// --text flag switches to text-only mode (no audio capture/playback tools needed)
var textMode = args.Contains("--text", StringComparer.OrdinalIgnoreCase);

using var client = new GeminiClient(apiKey);
using var cts = new CancellationTokenSource();

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    cts.Cancel();
};

// Configure the Live API session
var config = textMode
    ? new LiveSetupConfig
    {
        Model = "models/gemini-2.0-flash",
        GenerationConfig = new GenerationConfig
        {
            ResponseModalities = [GenerationConfigResponseModalitie.Text],
        },
        SystemInstruction = new Content
        {
            Parts = [new Part { Text = "You are a helpful assistant. Keep responses concise — under 2 sentences." }],
        },
    }
    : new LiveSetupConfig
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

var modeLabel = textMode ? "text" : "audio";
Console.WriteLine($"Connecting to Gemini Live API ({modeLabel} mode)...");
await using var session = await client.ConnectResilientLiveAsync(config, cancellationToken: cts.Token);
Console.WriteLine("Connected!");

if (textMode)
{
    // Text mode: simple keyboard input loop
    Console.WriteLine("Type messages and press Enter. Ctrl+C to quit.\n");

    while (!cts.Token.IsCancellationRequested)
    {
        Console.Write("You: ");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
            continue;

        await session.SendTextAsync(input, cts.Token);

        Console.Write("Gemini: ");
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { } parts)
            {
                foreach (var part in parts)
                {
                    if (part.Text is { } partText)
                        Console.Write(partText);
                }
            }

            if (message.ServerContent?.TurnComplete == true)
                break;
        }
        Console.WriteLine("\n");
    }
}
else
{
    // Audio mode: microphone capture + speaker playback
    var (recProcess, recDescription) = StartMicrophoneCapture();
    if (recProcess == null)
    {
        Console.WriteLine("No supported audio capture tool found.");
        Console.WriteLine("Install one of: sox (rec), arecord (Linux), or ffmpeg.");
        Console.WriteLine("  macOS:  brew install sox");
        Console.WriteLine("  Linux:  sudo apt install sox / alsa-utils");
        Console.WriteLine("  Any:    brew/apt/choco install ffmpeg");
        Console.WriteLine("\nTip: Run with --text for text-only mode (no audio tools needed).");
        return;
    }

    Console.WriteLine($"Microphone: {recDescription}");

    // Start audio playback process (sox play, ffplay, or aplay)
    var (playProcess, playDescription) = StartAudioPlayback();
    if (playProcess != null)
    {
        Console.WriteLine($"Speaker: {playDescription}");
    }
    else
    {
        Console.WriteLine("Speaker: none (install sox or ffplay for real-time playback)");
    }

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

            // Play audio response in real-time
            if (message.ServerContent?.ModelTurn?.Parts is { } parts)
            {
                foreach (var part in parts)
                {
                    if (part.InlineData?.Data is { Length: > 0 } audioData)
                    {
                        PlayAudioChunk(playProcess, audioData);
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
                var tokens = usage.TotalTokenCount ?? usage.ResponseTokenCount;
                if (tokens > 0)
                    Console.WriteLine($"  [Tokens: {tokens}]");
            }
        }
    }
    catch (OperationCanceledException) { }

    // Cleanup
    try { recProcess.Kill(); } catch { }
    recProcess.Dispose();
    if (playProcess != null)
    {
        try { playProcess.StandardInput.BaseStream.Close(); } catch { }
        try { playProcess.Kill(); } catch { }
        playProcess.Dispose();
    }
    await micTask;
}

Console.WriteLine("\nSession ended.");

/// <summary>
/// Writes an audio chunk to the playback process stdin (real-time audio output).
/// </summary>
static void PlayAudioChunk(Process? playProcess, byte[] audioData)
{
    if (playProcess == null)
        return;

    try
    {
        playProcess.StandardInput.BaseStream.Write(audioData, 0, audioData.Length);
        playProcess.StandardInput.BaseStream.Flush();
    }
    catch
    {
        // Playback process may have exited
    }
}

/// <summary>
/// Starts a platform-appropriate audio playback process accepting 16-bit PCM at 24kHz mono on stdin.
/// </summary>
static (Process? process, string description) StartAudioPlayback()
{
    // Try sox (play) — cross-platform, most common
    var playPath = FindExecutable("play");
    if (playPath != null)
    {
        var process = StartProcess(playPath, [
            "-q",                    // quiet
            "-r", "24000",           // 24kHz (Gemini output rate)
            "-b", "16",              // 16-bit
            "-c", "1",               // mono
            "-e", "signed-integer",  // signed PCM
            "-t", "raw",             // raw input
            "-",                     // from stdin
        ], redirectStdin: true);
        return (process, "sox (play)");
    }

    // Try ffplay — cross-platform via ffmpeg
    var ffplayPath = FindExecutable("ffplay");
    if (ffplayPath != null)
    {
        var process = StartProcess(ffplayPath, [
            "-nodisp",               // no video window
            "-autoexit",
            "-f", "s16le",           // 16-bit signed little-endian
            "-ar", "24000",          // 24kHz
            "-ac", "1",              // mono
            "-loglevel", "error",
            "-i", "pipe:0",          // from stdin
        ], redirectStdin: true);
        return (process, "ffplay");
    }

    // Try aplay — Linux ALSA
    if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        var aplayPath = FindExecutable("aplay");
        if (aplayPath != null)
        {
            var process = StartProcess(aplayPath, [
                "-q",                // quiet
                "-f", "S16_LE",      // 16-bit signed little-endian
                "-r", "24000",       // 24kHz
                "-c", "1",           // mono
                "-t", "raw",         // raw input
                "--",
            ], redirectStdin: true);
            return (process, "aplay (ALSA)");
        }
    }

    return (null, "none");
}

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
            "-c", "1",              // mono
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

static Process? StartProcess(string fileName, string[] args, bool redirectStdin = false)
{
    var psi = new ProcessStartInfo
    {
        FileName = fileName,
        RedirectStandardOutput = !redirectStdin,
        RedirectStandardInput = redirectStdin,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true,
    };
    foreach (var arg in args)
        psi.ArgumentList.Add(arg);

    if (!redirectStdin)
        psi.RedirectStandardOutput = true;

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
