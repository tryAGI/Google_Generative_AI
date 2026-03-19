# Generate Content



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = new GeminiClient(apiKey);
var modelId = GetGenerateContentModelId();

try
{
    Console.WriteLine($"Using model: {modelId}");

    GenerateContentResponse response = await client.ModelsGenerateContentAsync(
        modelsId: modelId,
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

}
catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
{
}
```