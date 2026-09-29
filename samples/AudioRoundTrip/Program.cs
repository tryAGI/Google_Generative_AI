using Google.Gemini;
using Microsoft.Extensions.AI;

var apiKey = System.Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY")
    ?? throw new InvalidOperationException(
        "Set the GOOGLE_GEMINI_API_KEY environment variable.");

var prompt = args.Length > 0
    ? string.Join(' ', args)
    : "Hello! This is Gemini 3.8 Flash-Lite TTS speaking. Let's see how well I sound when transcribed back.";

var voice = System.Environment.GetEnvironmentVariable("GOOGLE_GEMINI_VOICE") is { Length: > 0 } v
    ? v
    : GeminiVoices.Puck;

using var client = new GeminiClient(apiKey);

// 1) Synthesize speech with Gemini 3.8 Flash-Lite TTS.
Console.WriteLine($"Synthesizing with voice '{voice}'...");
Console.WriteLine($"  Prompt: {prompt}");

AudioResult tts;
try
{
    tts = await client.SpeakAdvancedAsync(text: prompt, voiceName: voice, style: "calm and friendly");
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests
                                              or System.Net.HttpStatusCode.ServiceUnavailable)
{
    Console.Error.WriteLine($"Gemini API rate-limited or unavailable: {ex.StatusCode}");
    Console.Error.WriteLine("  (Free tier allows ~10 TTS requests per day. Retry later or upgrade plan.)");
    return 2;
}

if (!tts.HasAudio)
{
    Console.Error.WriteLine("No audio returned. Aborting.");
    return 1;
}

Console.WriteLine($"  {tts.AudioData!.Length:N0} bytes of {tts.MimeType} audio");

// 2) Save as WAV next to the executable so the user can play it.
var wavPath = Path.Combine(Directory.GetCurrentDirectory(), "audio_round_trip.wav");
tts.WriteWavFile(wavPath);
Console.WriteLine($"  Saved: {wavPath}");

// 3) Round-trip the audio through the MEAI ISpeechToTextClient interface
//    that GeminiClient implements. Anything that consumes ISpeechToTextClient
//    can swap providers without code changes.
ISpeechToTextClient stt = client;
using var wavStream = System.IO.File.OpenRead(wavPath);

Console.WriteLine("Transcribing via ISpeechToTextClient...");
var response = await stt.GetTextAsync(wavStream);

Console.WriteLine($"  Model: {response.ModelId}");
Console.WriteLine($"  Text:  {response.Text}");

return 0;
