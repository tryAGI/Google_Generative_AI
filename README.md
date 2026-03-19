# Google.Gemini

[![Nuget package](https://img.shields.io/nuget/vpre/Google_Gemini)](https://www.nuget.org/packages/Google_Gemini/)
[![dotnet](https://github.com/tryAGI/Google_Generative_AI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Google_Generative_AI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Google_Generative_AI)](https://github.com/tryAGI/Google_Generative_AI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Google.Gemini OpenAPI specification](https://raw.githubusercontent.com/Google.Gemini/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support

### Usage
```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient) and [`IEmbeddingGenerator`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.iembeddinggenerator-2):
```csharp
using Google.Gemini;
using Microsoft.Extensions.AI;

// IChatClient
IChatClient chatClient = new GeminiClient(apiKey);
var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello!")],
    new ChatOptions { ModelId = "gemini-2.0-flash" });

// IEmbeddingGenerator
IEmbeddingGenerator<string, Embedding<float>> generator = new GeminiClient(apiKey);
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions { ModelId = "gemini-embedding-001" });
```

### Live API (Real-time Voice/Video)

The SDK supports the [Gemini Live API](https://ai.google.dev/gemini-api/docs/live-api) for real-time bidirectional voice and video interactions over WebSocket:

```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);

// Connect to the Live API
await using var session = await client.ConnectLiveAsync(new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
});

// Send text and receive audio responses
await session.SendTextAsync("Hello, how are you?");

await foreach (var message in session.ReadEventsAsync())
{
    // Audio data in message.ServerContent.ModelTurn.Parts[].InlineData
    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**System instruction** (customize model behavior):
```csharp
await using var session = await client.ConnectLiveAsync(new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    SystemInstruction = new Content
    {
        Parts = [new Part { Text = "You are a friendly pirate. Always respond in pirate speak." }],
    },
});
```

**Tool calling:**
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
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
        // Handle function call and send response
        await session.SendToolResponseAsync([new FunctionResponse
        {
            Name = toolCall.FunctionCalls![0].Name,
            Id = toolCall.FunctionCalls[0].Id,
            Response = new { temperature = "15C" },
        }]);
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Session resumption** (reconnect without losing context):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
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

**Output transcription** (get text alongside audio responses):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    OutputAudioTranscription = new LiveOutputAudioTranscription(),
};

await using var session = await client.ConnectLiveAsync(config);
await session.SendTextAsync("Tell me a joke");

await foreach (var message in session.ReadEventsAsync())
{
    // Text transcription of the audio response
    if (message.ServerContent?.OutputTranscription?.Text is { } text)
        Console.Write(text);

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Context window compression** (for longer sessions):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-2.5-flash-native-audio-latest",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    ContextWindowCompression = new LiveContextWindowCompression
    {
        SlidingWindow = new LiveSlidingWindow
        {
            TargetTokens = 1024, // tokens to retain after compression
        },
    },
};
```

**GoAway handling** (graceful session migration):
```csharp
await foreach (var message in session.ReadEventsAsync())
{
    if (message.GoAway is { } goAway)
    {
        // Server is closing soon — reconnect using session resumption
        Console.WriteLine($"Server closing in {goAway.TimeLeft}, reconnecting...");
        break; // dispose session and reconnect with resumption handle
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Send audio/video:**
```csharp
// Send PCM audio (16-bit, 16kHz, little-endian, mono)
await session.SendAudioAsync(pcmBytes);

// Send video frame
await session.SendVideoAsync(jpegBytes, "image/jpeg");
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

### Embedding Models

| Model | Dimensions | Description |
|-------|-----------|-------------|
| `gemini-embedding-001` | 768 (default) | Stable text embedding model |
| `gemini-embedding-2-preview` | 3072 (default) | Latest multimodal model — text, images, video, audio, PDFs. Matryoshka dimensions support |

The SDK defaults to `gemini-embedding-001`. For best retrieval quality, use `gemini-embedding-2-preview` (note: embedding spaces are incompatible between the two models). See [Google's embedding guide](https://ai.google.dev/gemini-api/docs/embeddings) for details.

### API Version

This SDK targets the **v1beta** API, which is the full-featured version used by Google's own SDKs (Python, JS, Go). The v1 (stable) API only exposes ~30 of the 70+ available endpoints and lacks critical features like tool calling, file upload, context caching, and grounding.

## Support

Priority place for bugs: https://github.com/tryAGI/Google_Generative_AI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Google_Generative_AI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).