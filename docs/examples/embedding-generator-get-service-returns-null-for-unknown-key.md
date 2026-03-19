# Embedding Generator Get Service Returns Null For Unknown Key



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = generator.GetService<EmbeddingGeneratorMetadata>(serviceKey: "unknown");
```