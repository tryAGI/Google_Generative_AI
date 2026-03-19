# LiveMicrophone

A real-time voice conversation app that captures microphone audio, streams it to the Gemini Live API, and plays back audio responses through your speakers.

Also supports a `--text` mode for environments without audio capture tools.

## Features

- Real-time microphone capture via `sox` (rec), `arecord`, or `ffmpeg`
- Real-time audio playback via `sox` (play), `ffplay`, or `aplay`
- Bidirectional audio streaming (mic in, speaker out)
- Input transcription (what you said) and output transcription (what the model said)
- Voice selection and auto-reconnect via `ResilientLiveSession`
- `--text` mode: keyboard input with text responses (no audio tools needed)

## Prerequisites

Audio tools are only needed for audio mode (the default). Text mode has no extra dependencies.

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
   # Audio mode (default) — real-time mic + speaker
   dotnet run --project samples/LiveMicrophone/LiveMicrophone.csproj

   # Text mode — no audio tools needed, uses gemini-2.0-flash
   dotnet run --project samples/LiveMicrophone/LiveMicrophone.csproj -- --text
   ```

3. In audio mode, speak into your microphone. In text mode, type messages and press Enter.

4. Press `Ctrl+C` to quit.

## Audio Format

- **Input:** 16-bit PCM, 16kHz, mono (captured from microphone)
- **Output:** 16-bit PCM, 24kHz, mono (from Gemini Live API, played through speakers)
