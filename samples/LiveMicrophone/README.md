# LiveMicrophone

A real-time voice conversation app that captures microphone audio, streams it to the Gemini Live API, and plays back audio responses through your speakers.

## Features

- Real-time microphone capture via `sox` (rec), `arecord`, or `ffmpeg`
- Real-time audio playback via `sox` (play), `ffplay`, or `aplay`
- Bidirectional audio streaming (mic in, speaker out)
- Input transcription (what you said) and output transcription (what the model said)
- Voice selection and auto-reconnect via `ResilientLiveSession`

## Prerequisites

Install audio tools for capture and playback:

| Tool | Platform | Install | Provides |
|------|----------|---------|----------|
| `sox` | macOS, Linux, Windows | `brew install sox` / `apt install sox` | `rec` (capture) + `play` (playback) |
| `arecord`/`aplay` | Linux | `apt install alsa-utils` | Capture + playback |
| `ffmpeg`/`ffplay` | All | `brew install ffmpeg` / `apt install ffmpeg` | Capture + playback |

**Recommended:** Install `sox` — it provides both `rec` and `play` in one package.

## Setup

1. Set your API key:
   ```bash
   export GOOGLE_GEMINI_API_KEY="your-api-key"
   ```

2. Run the app:
   ```bash
   dotnet run --project samples/LiveMicrophone/LiveMicrophone.csproj
   ```

3. Speak into your microphone. You'll hear the model's response through your speakers and see transcriptions in the console.

4. Press `Ctrl+C` to quit.

## Audio Format

- **Input:** 16-bit PCM, 16kHz, mono (captured from microphone)
- **Output:** 16-bit PCM, 24kHz, mono (from Gemini Live API, played through speakers)
