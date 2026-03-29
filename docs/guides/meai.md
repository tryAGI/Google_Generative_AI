# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Google.Gemini SDK implements `IChatClient` and `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

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
        ModelId = "gemini-embedding-2-preview",
    });

foreach (var embedding in embeddings)
{
    Console.WriteLine($"Dimensions: {embedding.Vector.Length}");
}
```

### Custom Dimensions

`gemini-embedding-2-preview` supports Matryoshka dimensionality reduction — you can request smaller vectors for faster search with minimal quality loss:

```csharp
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "gemini-embedding-2-preview",
        Dimensions = 256, // default is 3072; supports 256, 512, 768, 1024, etc.
    });
```

### Task Types

Specify a task type via `AdditionalProperties` to optimize embeddings for your use case:

```csharp
var embeddings = await generator.GenerateAsync(
    ["How do I reset my password?"],
    new EmbeddingGenerationOptions
    {
        ModelId = "gemini-embedding-2-preview",
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["TaskType"] = "RETRIEVAL_QUERY",
        },
    });
```

For document ingestion, use `RETRIEVAL_DOCUMENT` with an optional `Title`:

```csharp
var embeddings = await generator.GenerateAsync(
    ["To reset your password, go to Settings > Security > Change Password..."],
    new EmbeddingGenerationOptions
    {
        ModelId = "gemini-embedding-2-preview",
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["TaskType"] = "RETRIEVAL_DOCUMENT",
            ["Title"] = "Password Reset Guide",
        },
    });
```

| Task Type | Use Case |
|-----------|----------|
| `RETRIEVAL_QUERY` | Search queries — embed the question |
| `RETRIEVAL_DOCUMENT` | Documents to be searched — embed the content |
| `SEMANTIC_SIMILARITY` | Measuring text similarity |
| `CLASSIFICATION` | Text classification |
| `CLUSTERING` | Grouping similar texts |
| `QUESTION_ANSWERING` | Question answering |
| `FACT_VERIFICATION` | Fact checking |
| `CODE_RETRIEVAL_QUERY` | Code search queries |

### Available Embedding Models

| Model | Dimensions | Description |
|-------|-----------|-------------|
| `gemini-embedding-2-preview` | 3072 (default) | Latest model, best retrieval quality, Matryoshka dimensions support |
| `gemini-embedding-001` | 768 | Previous generation model |

!!! note "API Version"
    This SDK targets the **v1beta** API — the full-featured version used by Google's own SDKs. The v1 stable API lacks critical features like tool calling, file upload, context caching, and grounding.
