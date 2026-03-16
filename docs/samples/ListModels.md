```csharp
using var client = new GeminiClient(apiKey);

ListModelsResponse response = await client.ListModelsAsync();

foreach (var model in response.Models ?? [])
{
    Console.WriteLine(model.Name);
}
```