# Live API (Real-time Voice/Video)

The SDK supports the [Gemini Live API](https://ai.google.dev/gemini-api/docs/live-api) for real-time bidirectional voice and video interactions over WebSocket.

## Overview

The Live API enables:

- **Real-time audio conversations** with voice activity detection (VAD)
- **Video frame streaming** for live visual understanding
- **Tool calling** during live sessions
- **Session resumption** for reconnection without losing context
- **Auto-reconnect** via `ResilientLiveSession` for production use

!!! info "Model requirements"
    The Live API requires a Live-compatible model (e.g., `models/gemini-3.1-flash-live-preview`) and `Audio` response modality.

## Quick Start

```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);

await using var session = await client.ConnectLiveAsync(new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
});

// Send text, receive audio
await session.SendTextAsync("Hello, how are you?");

await foreach (var message in session.ReadEventsAsync())
{
    // Audio data in message.ServerContent.ModelTurn.Parts[].InlineData
    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

## Session Types

### `GeminiLiveSession`

The basic session class for direct WebSocket communication:

```csharp
await using var session = await client.ConnectLiveAsync(config);
```

### `ResilientLiveSession`

A wrapper that automatically reconnects when the server sends a GoAway message (e.g., for maintenance). Recommended for production use:

```csharp
await using var session = await client.ConnectResilientLiveAsync(config);

session.GoAwayReceived += (sender, goAway) =>
    Console.WriteLine($"Server closing in {goAway.TimeLeft}, reconnecting...");
session.Reconnected += (sender, _) =>
    Console.WriteLine("Reconnected!");

// Events flow transparently across reconnections
await foreach (var message in session.ReadEventsAsync())
{
    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

## Sending Input

### Text

```csharp
// Sends text as a complete user turn (triggers model response)
await session.SendTextAsync("What's the weather?");
```

### Audio

```csharp
// Send PCM audio (16-bit, 16kHz, little-endian, mono)
await session.SendAudioAsync(pcmBytes);

// Send with custom MIME type
await session.SendAudioAsync(audioBytes, "audio/pcm;rate=24000");
```

### Video

```csharp
// Send a JPEG frame
await session.SendVideoAsync(jpegBytes, "image/jpeg");

// Stream video at ~10 fps
foreach (var frame in videoFrames)
{
    await session.SendVideoAsync(frame, "image/jpeg");
    await Task.Delay(100);
}
```

### Multi-turn Conversation

Use sequential `SendTextAsync` calls (wait for `TurnComplete` between turns):

```csharp
// First turn
await session.SendTextAsync("My name is Alice");
await foreach (var msg in session.ReadEventsAsync())
{
    if (msg.ServerContent?.TurnComplete == true) break;
}

// Second turn — the model remembers context
await session.SendTextAsync("What's my name?");
```

## Receiving Events

All responses come through `ReadEventsAsync()`:

```csharp
await foreach (var message in session.ReadEventsAsync())
{
    // Audio/text model response
    if (message.ServerContent?.ModelTurn?.Parts is { } parts)
    {
        foreach (var part in parts)
        {
            if (part.InlineData?.Data is { } audioData)
                PlayAudio(audioData); // 24kHz PCM

            if (part.Text is { } text)
                Console.Write(text);
        }
    }

    // Output transcription (text version of audio response)
    if (message.ServerContent?.OutputTranscription?.Text is { } transcript)
        Console.Write(transcript);

    // Input transcription (text version of audio you sent)
    if (message.ServerContent?.InputTranscription?.Text is { } inputText)
        Console.Write($"[You said: {inputText}]");

    // Model was interrupted by new user input
    if (message.ServerContent?.Interrupted == true)
        Console.Write("[interrupted]");

    // Tool call request
    if (message.ToolCall is { } toolCall)
        HandleToolCall(toolCall);

    // Tool call was cancelled (user interrupted)
    if (message.ToolCallCancellation is { } cancellation)
        Console.Write($"Cancelled: {string.Join(", ", cancellation.Ids!)}");

    // Token usage (3.1+ uses ResponseTokenCount instead of CandidatesTokenCount)
    if (message.UsageMetadata is { } usage)
        Console.Write($"[Tokens: {usage.TotalTokenCount ?? usage.ResponseTokenCount}]");

    // Server requesting disconnect (handled automatically by ResilientLiveSession)
    if (message.GoAway is { } goAway)
        Console.Write($"[Server closing in {goAway.TimeLeft}]");

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

## Configuration Options

### Voice Selection

```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
        SpeechConfig = new SpeechConfig
        {
            VoiceConfig = new VoiceConfig
            {
                PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                {
                    VoiceName = "Kore", // Aoede, Charon, Fenrir, Kore, Puck, etc.
                },
            },
        },
    },
};
```

### System Instruction

```csharp
var config = new LiveSetupConfig
{
    // ...
    SystemInstruction = new Content
    {
        Parts = [new Part { Text = "You are a friendly pirate. Always respond in pirate speak." }],
    },
};
```

### Transcription

```csharp
var config = new LiveSetupConfig
{
    // ...
    // Get text alongside audio responses
    OutputAudioTranscription = new LiveOutputAudioTranscription(),
    // Get text for audio you send
    InputAudioTranscription = new LiveInputAudioTranscription(),
};
```

### Context Window Compression

For longer sessions that might exceed the context window:

```csharp
var config = new LiveSetupConfig
{
    // ...
    ContextWindowCompression = new LiveContextWindowCompression
    {
        SlidingWindow = new LiveSlidingWindow
        {
            TargetTokens = 1024, // tokens to retain after compression
        },
    },
};
```

### Session Resumption

Reconnect without losing conversation context:

```csharp
var config = new LiveSetupConfig
{
    // ...
    SessionResumption = new LiveSessionResumptionConfig(),
};

await using var session1 = await client.ConnectLiveAsync(config);
// ... interact ...
var handle = session1.LastSessionResumptionHandle;

// Later, reconnect with the handle
var config2 = new LiveSetupConfig
{
    // ... same config ...
    SessionResumption = new LiveSessionResumptionConfig { Handle = handle },
};
await using var session2 = await client.ConnectLiveAsync(config2);
```

!!! tip
    `ResilientLiveSession` handles this automatically when GoAway is received.

## Tool Calling

```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    Tools = [new Tool { FunctionDeclarations = [myFunction] }],
};

await using var session = await client.ConnectLiveAsync(config);
await session.SendTextAsync("What's the weather in London?");

await foreach (var message in session.ReadEventsAsync())
{
    if (message.ToolCall is { } toolCall)
    {
        await session.SendToolResponseAsync([new FunctionResponse
        {
            Name = toolCall.FunctionCalls![0].Name,
            Id = toolCall.FunctionCalls[0].Id,
            Response = new { temperature = "15C" },
        }]);
    }

    if (message.ToolCallCancellation is { } cancellation)
    {
        Console.WriteLine($"Tool calls cancelled: {string.Join(", ", cancellation.Ids!)}");
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

### Choosing `Parameters` vs `ParametersJsonSchema`

Use `FunctionDeclaration.Parameters` when your tool schema is simple and fits naturally into the SDK's typed `Schema` model.

Use `FunctionDeclaration.ParametersJsonSchema` when you want to pass raw JSON Schema directly, especially for cases like:

- `additionalProperties: false`
- exact `propertyOrdering`
- nested schema metadata or an existing JSON Schema document you want to preserve as-is

`Parameters` and `ParametersJsonSchema` are mutually exclusive. The SDK's `IChatClient` bridge already uses `ParametersJsonSchema` for this reason.

```csharp
using System.Text.Json;

var weatherSchema = JsonDocument.Parse("""
{
  "type": "object",
  "additionalProperties": false,
  "propertyOrdering": ["location", "units", "preferences"],
  "properties": {
    "location": {
      "type": "string",
      "description": "The city name"
    },
    "units": {
      "type": "string",
      "enum": ["celsius", "fahrenheit"]
    },
    "preferences": {
      "type": "object",
      "additionalProperties": false,
      "propertyOrdering": ["includeHumidity"],
      "properties": {
        "includeHumidity": {
          "type": "boolean"
        }
      }
    }
  },
  "required": ["location"]
}
""").RootElement.Clone();

var myFunction = new FunctionDeclaration
{
    Name = "get_weather",
    Description = "Get the current weather for a location",
    ParametersJsonSchema = weatherSchema,
};
```

## Session Limits

| Scenario | Duration |
|----------|----------|
| Audio only | ~15 minutes |
| Audio + video | ~2 minutes (without compression) |
| Connection lifetime | ~10 minutes (use session resumption or `ResilientLiveSession`) |

## Samples

- **[LiveVoiceAssistant](https://github.com/tryAGI/Google_Generative_AI/tree/main/samples/LiveVoiceAssistant)** — Text-in/audio-out console app with transcription
- **[LiveAudioPlayback](https://github.com/tryAGI/Google_Generative_AI/tree/main/samples/LiveAudioPlayback)** — Saves audio responses as playable WAV files
- **[LiveMicrophone](https://github.com/tryAGI/Google_Generative_AI/tree/main/samples/LiveMicrophone)** — Real-time voice conversation with microphone capture and speaker playback
- **[LiveToolAgent](https://github.com/tryAGI/Google_Generative_AI/tree/main/samples/LiveToolAgent)** — Voice agent with function calling (weather, time, calculator)
