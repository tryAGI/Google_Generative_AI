# LiveMicrophone

A real-time voice conversation app that captures microphone audio, streams it to the Gemini Live API, and saves audio responses as WAV files.

## Features

- Real-time microphone capture via `sox`, `arecord`, or `ffmpeg`
- Bidirectional audio streaming (send mic audio, receive model audio)
- Input transcription (what you said) and output transcription (what the model said)
- Audio responses saved as WAV files for playback
- Voice selection and auto-reconnect via `ResilientLiveSession`

## Prerequisites

Install one of the supported audio capture tools:

| Tool | Platform | Install |
|------|----------|---------|
| `sox` (rec) | macOS, Linux, Windows | `brew install sox` / `apt install sox` |
| `arecord` | Linux | `apt install alsa-utils` |
| `ffmpeg` | All | `brew install ffmpeg` / `apt install ffmpeg` |

## Setup

1. Set your API key:
   ```bash
   export GOOGLE_GEMINI_API_KEY="your-api-key"
   ```

2. Run the app:
   ```bash
   dotnet run --project samples/LiveMicrophone/LiveMicrophone.csproj
   ```

3. Speak into your microphone. The model's transcribed responses appear in the console, and audio responses are saved as `mic_response_001.wav`, `mic_response_002.wav`, etc.

4. Press `Ctrl+C` to quit.

## Playback

```bash
# macOS
afplay mic_response_001.wav

# Linux
aplay mic_response_001.wav

# Windows
start mic_response_001.wav
```

## Audio Format

- **Input:** 16-bit PCM, 16kHz, mono (captured from microphone)
- **Output:** 16-bit PCM, 24kHz, mono (from Gemini Live API, saved as WAV)
