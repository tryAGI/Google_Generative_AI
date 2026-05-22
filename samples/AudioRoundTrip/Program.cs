using Google.Gemini;
using Microsoft.Extensions.AI;

var apiKey = Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY")
    ?? throw new InvalidOperationException(
        "Set the GOOGLE_GEMINI_API_KEY environment variable.");

var prompt = args.Length > 0
    ? string.Join(' ', args)
    : $"{GeminiAudioTags.Cheerful} Hello! {GeminiAudioTags.Excited} This is Gemini 3.1 Flash TTS speaking. " +
      $"{GeminiAudioTags.Calm} Let's see how well I sound when transcribed back.";

var voice = Environment.GetEnvironmentVariable("GOOGLE_GEMINI_VOICE") is { Length: > 0 } v
    ? v
    : GeminiVoices.Puck;

using var client = new GeminiClient(apiKey);

// 1) Synthesize speech with Gemini 3.1 Flash TTS.
Console.WriteLine($"Synthesizing with voice '{voice}'...");
Console.WriteLine($"  Prompt: {prompt}");

AudioResult tts;
try
{
    tts = await client.SpeakAsync(text: prompt, voiceName: voice);
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

var pcmData = tts.AudioData!;
var sampleRate = tts.SampleRateHz ?? 24000;
Console.WriteLine($"  {pcmData.Length:N0} bytes PCM @ {sampleRate} Hz ({pcmData.Length / (double)(sampleRate * 2):F1}s)");

// 2) Save as WAV next to the executable so the user can play it.
var wavPath = Path.Combine(Directory.GetCurrentDirectory(), "audio_round_trip.wav");
WriteWavFile(wavPath, pcmData, sampleRate: sampleRate, bitsPerSample: 16, channels: 1);
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

static void WriteWavFile(string path, byte[] pcmData, int sampleRate, int bitsPerSample, int channels)
{
    var byteRate = sampleRate * channels * bitsPerSample / 8;
    var blockAlign = channels * bitsPerSample / 8;

    using var fs = System.IO.File.Create(path);
    using var writer = new BinaryWriter(fs);

    writer.Write("RIFF"u8);
    writer.Write(36 + pcmData.Length);
    writer.Write("WAVE"u8);

    writer.Write("fmt "u8);
    writer.Write(16);
    writer.Write((short)1);
    writer.Write((short)channels);
    writer.Write(sampleRate);
    writer.Write(byteRate);
    writer.Write((short)blockAlign);
    writer.Write((short)bitsPerSample);

    writer.Write("data"u8);
    writer.Write(pcmData.Length);
    writer.Write(pcmData);
}
