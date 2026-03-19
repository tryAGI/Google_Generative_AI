# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `Google_Gemini` SDK implements both `IChatClient` and `IEmbeddingGenerator` interfaces from `Microsoft.Extensions.AI`, enabling you to use Google Gemini models through standardized .NET AI abstractions.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `IChatClient` | Full (text, streaming, tool calling, images, thinking) |
| `IEmbeddingGenerator<string, Embedding<float>>` | Full |

## IChatClient

### Installation

```bash
dotnet add package Google_Gemini
```

### Basic Usage

```csharp
using Google.Gemini;
using Microsoft.Extensions.AI;

using var client = new GeminiClient(apiKey);
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "What is the capital of France?",
    new ChatOptions
    {
        ModelId = "gemini-2.0-flash",
    });

Console.WriteLine(response.Text);
```

### Streaming

```csharp
IChatClient chatClient = client;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Write a short poem about coding.",
    new ChatOptions
    {
        ModelId = "gemini-2.0-flash",
    }))
{
    Console.Write(update.Text);
}
```

### Tool Calling

```csharp
using CSharpToJsonSchema;

[GenerateJsonSchema]
public interface IWeatherTools
{
    [Description("Gets the current weather for a location.")]
    string GetWeather(
        [Description("The city name")] string city);
}

IChatClient chatClient = client;
var service = new WeatherToolsService();

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new ChatOptions
    {
        ModelId = "gemini-2.0-flash",
        Tools = service.AsTools().AsAITools(),
    });
```

### Image Input

```csharp
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new ImageContent(imageBytes, "image/png"),
            new TextContent("Describe this image."),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "gemini-2.0-flash",
    });
```

## IEmbeddingGenerator

### Basic Usage

```csharp
using Google.Gemini;
using Microsoft.Extensions.AI;

using var client = new GeminiClient(apiKey);
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["Hello, world!", "How are you?"],
    new EmbeddingGenerationOptions
    {
        ModelId = "gemini-embedding-2",
    });

foreach (var embedding in embeddings)
{
    Console.WriteLine($"Dimensions: {embedding.Vector.Length}");
}
```

### Custom Dimensions

`gemini-embedding-2` supports Matryoshka dimensionality reduction — you can request smaller vectors for faster search with minimal quality loss:

```csharp
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "gemini-embedding-2",
        Dimensions = 256, // default is 3072; supports 256, 512, 768, 1024, etc.
    });
```

### Available Embedding Models

| Model | Dimensions | Description |
|-------|-----------|-------------|
| `gemini-embedding-2` | 3072 (default) | Latest model, best retrieval quality, Matryoshka dimensions support |
| `gemini-embedding-001` | 768 | Previous generation model |

!!! note "API Version"
    This SDK targets the **v1beta** API — the full-featured version used by Google's own SDKs. The v1 stable API lacks critical features like tool calling, file upload, context caching, and grounding.
