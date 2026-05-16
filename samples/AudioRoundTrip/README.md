# AudioRoundTrip

A console app demonstrating Gemini's REST audio surface: TTS via `SpeakAsync` and STT via the MEAI `ISpeechToTextClient` interface that `GeminiClient` implements.

## What it does

1. Synthesizes speech with `gemini-3.1-flash-tts-preview`, using inline `GeminiAudioTags` for expression and `GeminiVoices.Puck` by default.
2. Saves the raw PCM response as `audio_round_trip.wav` next to the executable so it can be played directly.
3. Transcribes the same audio back through `Microsoft.Extensions.AI.ISpeechToTextClient` (provider-agnostic) and prints the result.

## Setup

```bash
export GOOGLE_GEMINI_API_KEY="your-api-key"

# Optional overrides
export GOOGLE_GEMINI_VOICE="Kore"

dotnet run --project samples/AudioRoundTrip/AudioRoundTrip.csproj -- \
    "[cheerful] Hi there! [whispers] Round-trip incoming."
```

If no prompt argument is supplied, a built-in audio-tag demo prompt is used.

## Notes

- The TTS response is raw PCM; sample rate is parsed from the response's MIME type (e.g. `audio/L16;codec=pcm;rate=24000`).
- The STT step proves the new `ISpeechToTextClient` works in any MEAI-aware pipeline — drop in another provider's client and the same code runs.
- `MEAI001` (the eval-API diagnostic on `ISpeechToTextClient`) is suppressed at the project level.
