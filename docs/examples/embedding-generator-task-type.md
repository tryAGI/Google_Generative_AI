# Embedding Generator Task Type



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

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