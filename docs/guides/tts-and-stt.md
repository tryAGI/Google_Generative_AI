# Text-to-Speech and Speech-to-Text

`GeminiClient` exposes Gemini's audio surface in two complementary forms:

| Surface                            | Entry point                                                                                 |
|------------------------------------|---------------------------------------------------------------------------------------------|
| Text-to-speech (TTS)               | `client.SpeakAsync(text, voiceName, modelId, languageCode)`                                 |
| Speech-to-text (STT, MEAI)         | `((Microsoft.Extensions.AI.ISpeechToTextClient)client).GetTextAsync(stream, options)`        |
| Speech-to-text (convenience)       | `client.TranscribeAsync(audioData, mimeType, modelId, prompt)`                              |

The default TTS model is `gemini-3.1-flash-tts-preview`, which supports inline
audio-control tags (200+) and 70+ languages.

## Synthesizing speech

```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);

var result = await client.SpeakAsync(
    text: $"{GeminiAudioTags.Cheerful} Hello! {GeminiAudioTags.Excited} This is Gemini.",
    voiceName: GeminiVoices.Puck);

if (result.HasAudio)
{
    var rate = result.SampleRateHz ?? 24000;           // parsed from audio/L16;…;rate=24000
    Console.WriteLine($"{result.AudioData!.Length} bytes PCM @ {rate} Hz");
}
```

Useful helpers shipped alongside `SpeakAsync`:

- `GeminiAudioTags` — strongly-typed constants for emotion / style / delivery / pacing tags.
- `GeminiVoices` — 30 prebuilt voice names, plus `GeminiVoices.All` for iteration.
- `client.ListTtsModelsAsync()` — live discovery of every TTS-capable model.
- `AudioResult.SampleRateHz` / `AudioResult.ParseSampleRateHz(mime)` — extract the
  sample rate from the response MIME type without string-mangling in caller code.

## Transcribing through MEAI

`GeminiClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`, so anything
that consumes that interface can swap providers without code changes.

```csharp
using Microsoft.Extensions.AI;

ISpeechToTextClient stt = client;
using var wavStream = File.OpenRead("speech.wav");
var response = await stt.GetTextAsync(wavStream);

Console.WriteLine(response.Text);
```

The implementation auto-sniffs WAV / Ogg / FLAC / MP3 magic bytes and falls back
to `audio/wav`. Pass a custom MIME type via
`SpeechToTextOptions.RawRepresentationFactory` when you know the format already.

## Round-trip walk-through

The full **TTS → save WAV → STT** flow is wired up in
[`samples/AudioRoundTrip`](https://github.com/tryAGI/Google.Gemini/tree/main/samples/AudioRoundTrip),
which you can run with:

```bash
export GOOGLE_GEMINI_API_KEY=...
dotnet run --project samples/AudioRoundTrip/AudioRoundTrip.csproj -- \
    "[cheerful] Hi there! [whispers] Round-trip incoming."
```

The sample:

1. Synthesizes speech with `SpeakAsync`, defaulting to `GeminiVoices.Puck`.
2. Wraps the returned PCM in a WAV header (`audio_round_trip.wav`) so you can
   play it back locally.
3. Calls `ISpeechToTextClient.GetTextAsync` on the WAV stream and prints the
   transcribed text — proving the new STT interface plugs into any MEAI-aware
   pipeline.

> **Free-tier quota:** Gemini's free tier currently allows ~10 TTS requests
> per day per model. The sample handles HTTP 429 cleanly and prints an
> explanatory message instead of throwing.

## Live-API counterpart

For real-time bidirectional voice over WebSocket (instead of REST round-trips),
see [`samples/LiveAudioPlayback`](https://github.com/tryAGI/Google.Gemini/tree/main/samples/LiveAudioPlayback).
It uses `gemini-3.1-flash-live-preview`, captures the streamed PCM chunks
into per-turn WAV files via the same `AudioResult.WriteWavFile` helper, and
prints text transcriptions alongside the audio. The Live-API surface is
covered in depth in the [Live API guide](live-api.md).
