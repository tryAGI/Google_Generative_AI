# Microsoft.Extensions.AI Integration

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
        ModelId = "text-embedding-004",
    });

foreach (var embedding in embeddings)
{
    Console.WriteLine($"Dimensions: {embedding.Vector.Length}");
}
```
