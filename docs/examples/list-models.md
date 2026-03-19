# List Models



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);

ListModelsResponse response = await client.ModelsListAsync();

foreach (var model in response.Models ?? [])
{
    Console.WriteLine(model.Name);
}
```