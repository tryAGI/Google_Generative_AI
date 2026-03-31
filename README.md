# Google.Gemini

[![Nuget package](https://img.shields.io/nuget/vpre/Google_Gemini)](https://www.nuget.org/packages/Google_Gemini/)
[![dotnet](https://github.com/tryAGI/Google_Generative_AI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Google_Generative_AI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Google_Generative_AI)](https://github.com/tryAGI/Google_Generative_AI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Google.Gemini OpenAPI specification](https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
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
    Model = "models/gemini-3.1-flash-live-preview",
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

**Voice selection and speech config:**
```csharp
await using var session = await client.ConnectLiveAsync(new LiveSetupConfig
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
});
```

**Multi-turn conversation:**
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

**System instruction** (customize model behavior):
```csharp
await using var session = await client.ConnectLiveAsync(new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
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
        // Handle function call and send response
        await session.SendToolResponseAsync([new FunctionResponse
        {
            Name = toolCall.FunctionCalls![0].Name,
            Id = toolCall.FunctionCalls[0].Id,
            Response = new { temperature = "15C" },
        }]);
    }

    // Tool calls cancelled due to user interruption
    if (message.ToolCallCancellation is { } cancellation)
    {
        Console.WriteLine($"Tool calls cancelled: {string.Join(", ", cancellation.Ids!)}");
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Session resumption** (reconnect without losing context):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
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
    Model = "models/gemini-3.1-flash-live-preview",
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

**Send audio/video:**
```csharp
// Send PCM audio (16-bit, 16kHz, little-endian, mono)
await session.SendAudioAsync(pcmBytes);

// Send audio with custom MIME type
await session.SendAudioAsync(audioBytes, "audio/pcm;rate=24000");

// Send video frame
await session.SendVideoAsync(jpegBytes, "image/jpeg");

// Stream video frames in a loop
foreach (var frame in videoFrames)
{
    await session.SendVideoAsync(frame, "image/jpeg");
    await Task.Delay(100); // ~10 fps
}
```

**Auto-reconnect on GoAway** (resilient sessions):
```csharp
// ResilientLiveSession automatically reconnects when the server sends GoAway
await using var session = await client.ConnectResilientLiveAsync(new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
});

session.GoAwayReceived += (sender, goAway) =>
    Console.WriteLine($"Server closing in {goAway.TimeLeft}, reconnecting...");
session.Reconnected += (sender, _) =>
    Console.WriteLine("Reconnected successfully!");

await session.SendTextAsync("Hello!");

// Events keep flowing transparently across reconnections
await foreach (var message in session.ReadEventsAsync())
{
    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Input audio transcription** (get text for audio you send):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
    InputAudioTranscription = new LiveInputAudioTranscription(),
};

await using var session = await client.ConnectLiveAsync(config);
await session.SendAudioAsync(pcmBytes);

await foreach (var message in session.ReadEventsAsync())
{
    // Text transcription of the audio you sent
    if (message.ServerContent?.InputTranscription?.Text is { } text)
        Console.Write($"[You said: {text}]");

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

<details>
<summary><b>Advanced features</b> (compression, interruption, usage, GoAway, audio round-trip)</summary>

**Context window compression** (for longer sessions):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
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

**Interruption handling** (user speaks during model response):
```csharp
await foreach (var message in session.ReadEventsAsync())
{
    if (message.ServerContent?.Interrupted == true)
    {
        // Model response was cut short — user started speaking
        Console.WriteLine("Model interrupted by user input");
    }

    if (message.ServerContent?.ModelTurn?.Parts is { } parts)
    {
        foreach (var part in parts)
        {
            // Process audio/text parts (may be partial if interrupted)
            if (part.InlineData?.Data is { } audioData)
                PlayAudio(audioData);
        }
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

**Usage metadata** (track token consumption):
```csharp
await foreach (var message in session.ReadEventsAsync())
{
    if (message.UsageMetadata is { } usage)
    {
        Console.WriteLine($"Prompt tokens: {usage.PromptTokenCount}");
        Console.WriteLine($"Response tokens: {usage.CandidatesTokenCount}");
        Console.WriteLine($"Total tokens: {usage.TotalTokenCount}");
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
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

**Audio round-trip** (send and receive audio):
```csharp
var config = new LiveSetupConfig
{
    Model = "models/gemini-3.1-flash-live-preview",
    GenerationConfig = new GenerationConfig
    {
        ResponseModalities = [GenerationConfigResponseModalitie.Audio],
    },
};

await using var session = await client.ConnectLiveAsync(config);

// Send PCM audio (16-bit, 16kHz, little-endian, mono)
await session.SendAudioAsync(pcmBytes);

// Receive audio response
await foreach (var message in session.ReadEventsAsync())
{
    if (message.ServerContent?.ModelTurn?.Parts is { } parts)
    {
        foreach (var part in parts)
        {
            if (part.InlineData?.Data is { } audioData)
            {
                // audioData is base64-decoded PCM audio (24kHz)
                PlayAudio(audioData);
            }
        }
    }

    if (message.ServerContent?.TurnComplete == true)
        break;
}
```

</details>

### Free Tier and Image Generation

Gemini API access is model-specific. A Free Tier key can use many text and multimodal Gemini models, but native image output models are currently different.

- `GenerateImageAsync`, `EditImageAsync`, and `GenerateImageWithReferencesAsync` default to `gemini-2.5-flash-image`.
- Google's Gemini API pricing page currently lists `gemini-2.5-flash-image` and `imagen-*` models as Paid Tier only.
- There is no SDK flag that enables free native image generation. To use the image helpers in this SDK, create your API key from a Paid Tier Google AI Studio project with billing enabled.
- Google AI Studio itself can still be free to use, but using a paid API key for paid features is billed by Google.

For setup details, see the `Free Tier and Image Generation` guide in the docs and Google's official docs for [pricing](https://ai.google.dev/gemini-api/docs/pricing), [billing](https://ai.google.dev/gemini-api/docs/billing), [rate limits](https://ai.google.dev/gemini-api/docs/rate-limits), and [available regions](https://ai.google.dev/gemini-api/docs/available-regions).

<!-- EXAMPLES:START -->
### Chat Client Five Random Words Streaming
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    IChatClient chatClient = client;
    var updates = chatClient.GetStreamingResponseAsync(
        messages:
        [
            new ChatMessage(ChatRole.User, "Generate 5 random words.")
        ],
        options: new ChatOptions
        {
            ModelId = modelId,
        });

    var deltas = new List<string>();
    await foreach (var update in updates)
    {
        if (!string.IsNullOrWhiteSpace(update.Text))
        {
            deltas.Add(update.Text);
        }
    }

    // In streaming mode, rate limiting may not throw ApiException but instead
    // return empty/truncated data. Treat empty results as inconclusive.
    if (deltas.Count == 0)
    {
        return;
    }

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Chat Client Five Random Words
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    IChatClient chatClient = client;
    var response = await chatClient.GetResponseAsync(
        messages:
        [
            new ChatMessage(ChatRole.User, "Generate 5 random words.")
        ],
        options: new ChatOptions
        {
            ModelId = modelId,
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Chat Client Get Service Returns Chat Client Metadata
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var metadata = chatClient.GetService<ChatClientMetadata>();
```

### Chat Client Get Service Returns Null For Unknown Key
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var result = chatClient.GetService<ChatClientMetadata>(serviceKey: "unknown");
```

### Chat Client Get Service Returns Self
```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var self = chatClient.GetService<GeminiClient>();
```

### Chat Client Tool Calling Multi Turn
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var getWeatherTool = AIFunctionFactory.Create(
        (string location) => $"The weather in {location} is 72°F and sunny.",
        name: "get_weather",
        description: "Gets the current weather for a given location.");

    IChatClient chatClient = client;
    var messages = new List<ChatMessage>
    {
        new(ChatRole.User, "What is the weather in Paris?"),
    };

    // First turn: model requests tool call
    var response = await chatClient.GetResponseAsync(
        messages,
        new ChatOptions
        {
            ModelId = modelId,
            Tools = [getWeatherTool],
        });

    var functionCall = response.Messages
        .SelectMany(m => m.Contents)
        .OfType<FunctionCallContent>()
        .FirstOrDefault();

    // Verify thought signature is preserved on function call content
    // (Gemini API requires it to be echoed back in subsequent turns)
    if (functionCall!.AdditionalProperties?.TryGetValue("gemini.thoughtSignature", out var sig) == true)
    {
    }

    // Add assistant message with function call and tool result
    messages.AddRange(response.Messages);
    var toolResult = await getWeatherTool.InvokeAsync(
        functionCall.Arguments is { } args ? new AIFunctionArguments(args) : null);
    messages.Add(new ChatMessage(ChatRole.Tool,
    [
        new FunctionResultContent(functionCall.CallId, toolResult),
    ]));

    // Second turn: model should produce a final text response
    // (this verifies the thought signature round-trip works — the API
    // rejects requests with missing thought signatures)
    var finalResponse = await chatClient.GetResponseAsync(
        messages,
        new ChatOptions
        {
            ModelId = modelId,
            Tools = [getWeatherTool],
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Chat Client Tool Calling Single Turn
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var getWeatherTool = AIFunctionFactory.Create(
        (string location) => $"The weather in {location} is 72°F and sunny.",
        name: "get_weather",
        description: "Gets the current weather for a given location.");

    IChatClient chatClient = client;
    var response = await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User, "What is the weather in Paris?")
        ],
        new ChatOptions
        {
            ModelId = modelId,
            Tools = [getWeatherTool],
        });

    // The model should request a tool call
    var functionCall = response.Messages
        .SelectMany(m => m.Contents)
        .OfType<FunctionCallContent>()
        .FirstOrDefault();

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Chat Client Tool Calling Streaming
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var getWeatherTool = AIFunctionFactory.Create(
        (string location) => $"The weather in {location} is 72°F and sunny.",
        name: "get_weather",
        description: "Gets the current weather for a given location.");

    IChatClient chatClient = client;
    var updates = chatClient.GetStreamingResponseAsync(
        [
            new ChatMessage(ChatRole.User, "What is the weather in Paris?")
        ],
        new ChatOptions
        {
            ModelId = modelId,
            Tools = [getWeatherTool],
        });

    // Collect all streaming updates
    var functionCalls = new List<FunctionCallContent>();
    await foreach (var update in updates)
    {
        functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());
    }

    // In streaming mode, rate limiting may not throw ApiException but instead
    // return empty/truncated data. Treat empty results as inconclusive.
    if (functionCalls.Count == 0)
    {
        return;
    }

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Count Tokens Multiple Messages
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var response = await client.ModelsCountTokensAsync(
        modelsId: modelId,
        contents:
        [
            new Content
            {
                Role = "user",
                Parts = [new Part { Text = "What is the meaning of life?" }],
            },
            new Content
            {
                Role = "model",
                Parts = [new Part { Text = "The meaning of life is a philosophical question." }],
            },
            new Content
            {
                Role = "user",
                Parts = [new Part { Text = "Can you elaborate?" }],
            },
        ]);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Count Tokens Simple Text
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    var response = await client.ModelsCountTokensAsync(
        modelsId: modelId,
        contents:
        [
            new Content
            {
                Parts = [new Part { Text = "Hello, world! This is a test of token counting." }],
            },
        ]);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Edit Image Simple Edit
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // This example uses native image output and therefore requires
    // a Paid Tier Gemini API project and API key.
    // First generate an image to edit
    var original = await client.GenerateImageAsync(
        prompt: "A plain white background",
        imageSize: "1K");

    var edited = await client.EditImageAsync(
        prompt: "Add a red circle in the center",
        imageData: original.ImageData!,
        mimeType: original.MimeType ?? "image/png",
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Embedding Generator Batch Input
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetEmbeddingModelId();

try
{
    IEmbeddingGenerator<string, Embedding<float>> generator = client;
    var result = await generator.GenerateAsync(
        values: ["Hello, world!", "Goodbye, world!"],
        options: new EmbeddingGenerationOptions
        {
            ModelId = modelId,
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Embedding Generator Get Service Returns Embedding Generator Metadata
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
```

### Embedding Generator Get Service Returns Null For Unknown Key
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = generator.GetService<EmbeddingGeneratorMetadata>(serviceKey: "unknown");
```

### Embedding Generator Get Service Returns Self
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var self = generator.GetService<GeminiClient>();
```

### Embedding Generator Single Input
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetEmbeddingModelId();

try
{
    IEmbeddingGenerator<string, Embedding<float>> generator = client;
    var result = await generator.GenerateAsync(
        values: ["Hello, world!"],
        options: new EmbeddingGenerationOptions
        {
            ModelId = modelId,
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Embedding Generator Task Type
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetEmbeddingModelId();

try
{
    IEmbeddingGenerator<string, Embedding<float>> generator = client;

    // Use RETRIEVAL_QUERY task type for search queries
    var queryResult = await generator.GenerateAsync(
        values: ["How do I reset my password?"],
        options: new EmbeddingGenerationOptions
        {
            ModelId = modelId,
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                ["TaskType"] = "RETRIEVAL_QUERY",
            },
        });

    // Use RETRIEVAL_DOCUMENT task type with a Title for documents
    var docResult = await generator.GenerateAsync(
        values: ["To reset your password, go to Settings > Security > Change Password."],
        options: new EmbeddingGenerationOptions
        {
            ModelId = modelId,
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                ["TaskType"] = "RETRIEVAL_DOCUMENT",
                ["Title"] = "Password Reset Guide",
            },
        });

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### File Management
```csharp
using var client = new GeminiClient(apiKey);

var response = await client.FilesListAsync();

// Should return a valid response even if no files exist
```

### Generate Content
```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    Console.WriteLine($"Using model: {modelId}");

    GenerateContentResponse response = await client.ModelsGenerateContentAsync(
        modelsId: modelId,
        contents: [
            new Content
            {
                Parts = [
                    new Part
                    {
                        Text = "Generate 5 random words",
                    },
                ],
                Role = "user",
            },
        ],
        generationConfig: new GenerationConfig(),
        safetySettings: new List<SafetySetting>());

    Console.WriteLine(response.Candidates?[0].Content?.Parts?[0].Text);

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Generate Image Simple Prompt
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Native image output models such as gemini-2.5-flash-image currently
    // require a Paid Tier Gemini API project and API key.
    var result = await client.GenerateImageAsync(
        prompt: "A simple red circle on a white background",
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Generate Image With Aspect Ratio
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // Native image output models such as gemini-2.5-flash-image currently
    // require a Paid Tier Gemini API project and API key.
    var result = await client.GenerateImageAsync(
        prompt: "A landscape with mountains",
        imageSize: "1K",
        aspectRatio: "16:9");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Generate Image With References Single Reference
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // This example uses native image output and therefore requires
    // a Paid Tier Gemini API project and API key.
    // First generate a reference image
    var reference = await client.GenerateImageAsync(
        prompt: "A simple red square",
        imageSize: "1K");

    var result = await client.GenerateImageWithReferencesAsync(
        prompt: "Create a similar shape but in blue",
        referenceImages: [(reference.ImageData!, reference.MimeType ?? "image/png")],
        imageSize: "1K");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```

### Generate Video Simple Prompt
```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.GenerateVideoAsync(
        prompt: "A serene beach at sunset with gentle waves");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
    // VIDEO modality may not be supported in generateContent endpoint yet
}
```

### Generate Video From Image Simple Animation
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // This example first creates a source image, so it also requires
    // a Paid Tier Gemini API project and API key.
    var image = await client.GenerateImageAsync(
        prompt: "A still landscape with mountains and a lake",
        imageSize: "1K");

    var result = await client.GenerateVideoFromImageAsync(
        prompt: "Animate the clouds moving slowly across the sky",
        imageData: image.ImageData!,
        mimeType: image.MimeType ?? "image/png");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```

### Interpolate Frames Two Images
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // This example first creates source images, so it also requires
    // a Paid Tier Gemini API project and API key.
    var startFrame = await client.GenerateImageAsync(
        prompt: "A red circle on a white background",
        imageSize: "1K");

    var endFrame = await client.GenerateImageAsync(
        prompt: "A blue square on a white background",
        imageSize: "1K");

    var result = await client.InterpolateFramesAsync(
        startFrame: startFrame.ImageData!,
        endFrame: endFrame.ImageData!,
        prompt: "Smoothly transition between the two shapes");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
{
}
```

### List Models
```csharp
using var client = new GeminiClient(apiKey);

ListModelsResponse response = await client.ModelsListAsync();

foreach (var model in response.Models ?? [])
{
    Console.WriteLine(model.Name);
}
```

### Speak Different Voice
```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.SpeakAsync(
        text: "Say calmly: Testing with a different voice. This should sound professional.",
        voiceName: "Kore");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```

### Speak Simple Text
```csharp
using var client = new GeminiClient(apiKey);

try
{
    var result = await client.SpeakAsync(
        text: "Say cheerfully: Hello, this is a test of text to speech. Have a wonderful day!",
        voiceName: "Puck");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```

### Transcribe Generated Audio
```csharp
using var client = new GeminiClient(apiKey);

try
{
    // First generate audio to transcribe
    var audio = await client.SpeakAsync(
        text: "Read aloud: The quick brown fox jumps over the lazy dog.");

    var transcription = await client.TranscribeAsync(
        audioData: audio.AudioData!,
        mimeType: audio.MimeType ?? "audio/wav");

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                              ex.Message.Contains("only be used for TTS"))
{
}
```
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
