# AudioRoundTrip

A console app demonstrating Gemini's REST audio surface: TTS via `SpeakAsync` and STT via the MEAI `ISpeechToTextClient` interface that `GeminiClient` implements.

## What it does

1. Synthesizes speech with `gemini-3.8-flash-lite-tts`, using turn-level style and `GeminiVoices.Puck` by default.
2. Saves the returned WAV response as `audio_round_trip.wav` next to the executable.
3. Transcribes the same audio back through `Microsoft.Extensions.AI.ISpeechToTextClient` (provider-agnostic) and prints the result.

## Setup

```bash
export GOOGLE_GEMINI_API_KEY="your-api-key"

# Optional overrides
export GOOGLE_GEMINI_VOICE="Kore"

dotnet run --project samples/AudioRoundTrip/AudioRoundTrip.csproj -- \
    "Hi there! Round-trip incoming."
```

If no prompt argument is supplied, a built-in sample transcript is used.

## Notes

- Gemini 3.8 TTS returns WAV by default. `WriteWavFile` copies WAV data as is and wraps raw `audio/L16` output when requested explicitly.
- The STT step proves the new `ISpeechToTextClient` works in any MEAI-aware pipeline — drop in another provider's client and the same code runs.
- `MEAI001` (the eval-API diagnostic on `ISpeechToTextClient`) is suppressed at the project level.
