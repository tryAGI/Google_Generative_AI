# Text-to-Speech and Speech-to-Text

`GeminiClient` exposes Gemini's audio surface in two complementary forms:

| Surface                            | Entry point                                                                                 |
|------------------------------------|---------------------------------------------------------------------------------------------|
| Text-to-speech (TTS)               | `client.SpeakAsync(text, voiceName, modelId, languageCode)` or `SpeakAdvancedAsync`          |
| Voice library and custom voices    | `GeminiNextGenClient.Voices`                                                                |
| Speech-to-text (STT, MEAI)         | `((Microsoft.Extensions.AI.ISpeechToTextClient)client).GetTextAsync(stream, options)`        |
| Speech-to-text (convenience)       | `client.TranscribeAsync(audioData, mimeType, modelId, prompt)`                              |
| Gemini 3.5 Transcribe              | `client.Transcribe35FileAsync(fileUri, mimeType, transcriptionConfig)` or `Transcribe35Async` |

The default TTS model is `gemini-3.8-flash-lite-tts`. Set `modelId` to
`gemini-3.8-flash-tts` for studio narration and complex multi-speaker work.
Both models accept turn-level `SpeechMetadata.Style` and prebuilt, designed,
or replicated voices. The 3.1 preview remains available by passing its model ID.

## Synthesizing speech

```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);

var result = await client.SpeakAdvancedAsync(
    text: "Hello! This is Gemini.",
    voiceName: GeminiVoices.Puck,
    style: "cheerful and friendly");

if (result.HasAudio)
{
    result.WriteWavFile("speech.wav"); // Gemini 3.8 returns WAV by default
}
```

Useful helpers shipped alongside `SpeakAsync`:

- `GeminiAudioTags` — strongly-typed constants for emotion / style / delivery / pacing tags.
- `GeminiVoices` — 30 prebuilt voice names, plus `GeminiVoices.All` for iteration.
- `client.ListTtsModelsAsync()` — live discovery of every TTS-capable model.
- `AudioResult.SampleRateHz` / `AudioResult.ParseSampleRateHz(mime)` — extract the
  sample rate from raw PCM MIME types when one is present.
- `SpeakAdvancedAsync` — add a style, use a `voice_...` or `voicekey_...`, or
  request raw PCM via `AudioResponseFormatMimeType.AudioL16`.
- `GeminiNextGenClient.Voices` — list, create, inspect, and delete stored voices.

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

For the dedicated Gemini 3.5 Transcribe model, upload a file with the Files API
and pass its URI to `Transcribe35FileAsync`. The returned `GenerateContentResponse`
retains word timestamps and speaker annotations. For example:

```csharp
var response = await client.Transcribe35FileAsync(
    new Uri(fileUri), "audio/wav",
    new AudioTranscriptionConfig
    {
        Mode = AudioTranscriptionConfigMode.Verbatim,
        WordTimestamp = true,
    });
var text = response.Candidates?[0].Content?.Parts?.FirstOrDefault(p => p.Text is not null)?.Text;
```

Use `Mode = AudioTranscriptionConfigMode.Smart` for cleanup and formatting;
Google does not allow Smart mode together with word timestamps or diarization.

## Round-trip walk-through

The full **TTS → save WAV → STT** flow is wired up in
[`samples/AudioRoundTrip`](https://github.com/tryAGI/Google.Gemini/tree/main/samples/AudioRoundTrip),
which you can run with:

```bash
export GOOGLE_GEMINI_API_KEY=...
dotnet run --project samples/AudioRoundTrip/AudioRoundTrip.csproj -- \
    "Hi there! Round-trip incoming."
```

The sample:

1. Synthesizes speech with `SpeakAsync`, defaulting to `GeminiVoices.Puck`.
2. Saves the returned WAV audio (`audio_round_trip.wav`) so you can play it
   back locally. The helper adds a header only for raw PCM output.
3. Calls `ISpeechToTextClient.GetTextAsync` on the WAV stream and prints the
   transcribed text — proving the new STT interface plugs into any MEAI-aware
   pipeline.

The sample handles HTTP 429 and service unavailability with an explanatory
message.

## Live-API counterpart

For real-time bidirectional voice over WebSocket (instead of REST round-trips),
see [`samples/LiveAudioPlayback`](https://github.com/tryAGI/Google.Gemini/tree/main/samples/LiveAudioPlayback).
It uses `gemini-3.1-flash-live-preview`, captures the streamed PCM chunks
into per-turn WAV files via the same `AudioResult.WriteWavFile` helper, and
prints text transcriptions alongside the audio. The Live-API surface is
covered in depth in the [Live API guide](live-api.md).
