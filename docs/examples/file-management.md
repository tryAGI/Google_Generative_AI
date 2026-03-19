# File Management



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

var response = await client.FilesListAsync();

// Should return a valid response even if no files exist
```