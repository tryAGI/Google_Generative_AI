# Embedding Generator Get Service Returns Embedding Generator Metadata



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
```