```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

Console.WriteLine($"Using model: {modelId}");

GenerateContentResponse response = await client.GenerateContentAsync(
    modelId: modelId,
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
```