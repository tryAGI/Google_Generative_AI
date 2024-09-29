namespace Google.Gemini.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GeminiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") ??
            Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY") ??
            throw new AssertInconclusiveException("GOOGLE_GEMINI_API_KEY environment variable is not found.");

        var client = new GeminiClient();
        
        return client;
    }
}
