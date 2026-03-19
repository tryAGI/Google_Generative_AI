# LiveVoiceAssistant

A console app demonstrating the Gemini Live API for real-time voice interactions.

## Features

- Text input with audio response (with transcription)
- Automatic reconnection on server GoAway via `ResilientLiveSession`
- Context window compression for longer sessions
- Interruption handling, tool call monitoring, usage tracking

## Setup

1. Set your API key:
   ```bash
   export GOOGLE_GEMINI_API_KEY="your-api-key"
   ```

2. Run the app:
   ```bash
   dotnet run --project samples/LiveVoiceAssistant/LiveVoiceAssistant.csproj
   ```

3. Type messages and press Enter. Press `Ctrl+C` to quit.

## Notes

- Uses `gemini-2.5-flash-native-audio-latest` model with audio response modality
- Audio chunks are counted but not played — see the `LiveAudioPlayback` sample for WAV output
- Session resumption is handled automatically by `ResilientLiveSession`
