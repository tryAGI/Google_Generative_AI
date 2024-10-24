namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateContent()
    {
        using var client = GetAuthenticatedClient();

        GenerateContentResponse response = await client.GenerateContentAsync(
            modelId: "gemini-1.5-flash-latest",
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
        
        response.Candidates.Should().NotBeNullOrEmpty();
        response.Candidates?[0].Content?.Parts?[0].Text.Should().NotBeNullOrEmpty();
    }
}
