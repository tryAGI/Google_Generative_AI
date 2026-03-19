# LiveAudioPlayback

A console app that saves Gemini Live API audio responses as WAV files you can play back.

## Features

- Text input with audio response saved to disk as `.wav` files
- Output transcription displayed in the console alongside audio
- Voice selection (Kore by default)
- Auto-reconnect via `ResilientLiveSession`

## Setup

1. Set your API key:
   ```bash
   export GOOGLE_GEMINI_API_KEY="your-api-key"
   ```

2. Run the app:
   ```bash
   dotnet run --project samples/LiveAudioPlayback/LiveAudioPlayback.csproj
   ```

3. Type messages and press Enter. Audio responses are saved as `response_001.wav`, `response_002.wav`, etc. in the current directory.

4. Play the WAV files with any audio player:
   ```bash
   # macOS
   afplay response_001.wav

   # Linux
   aplay response_001.wav

   # Windows
   start response_001.wav
   ```

## Audio Format

- Output: 16-bit PCM, 24kHz, mono (as received from the Gemini Live API)
- Files are standard WAV format, playable by any audio application
