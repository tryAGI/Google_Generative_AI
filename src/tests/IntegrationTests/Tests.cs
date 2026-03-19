namespace Google.Gemini.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static int _isDotEnvLoaded;

    private static GeminiClient GetAuthenticatedClient()
    {
        LoadDotEnv();

        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("GOOGLE_GEMINI_API_KEY") is { Length: > 0 } geminiKeyValue ? geminiKeyValue :
            throw new AssertInconclusiveException(
                "GOOGLE_GEMINI_API_KEY environment variable is not found. Set GOOGLE_GEMINI_API_KEY or API_KEY, or add a repo-root .env file.");

        var client = new GeminiClient(apiKey);

        return client;
    }

    private static string GetGenerateContentModelId()
    {
        LoadDotEnv();

        return Environment.GetEnvironmentVariable("GOOGLE_GEMINI_MODEL_ID") ?? "gemini-flash-latest";
    }

    private static void LoadDotEnv()
    {
        if (Interlocked.Exchange(ref _isDotEnvLoaded, 1) == 1)
        {
            return;
        }

        foreach (var startDirectory in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var dotEnvPath = FindFileInAncestors(startDirectory, ".env");
            if (dotEnvPath is null)
            {
                continue;
            }

            foreach (var rawLine in System.IO.File.ReadLines(dotEnvPath))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith('#'))
                {
                    continue;
                }

                if (line.StartsWith("export ", StringComparison.Ordinal))
                {
                    line = line["export ".Length..].TrimStart();
                }

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                var key = line[..separatorIndex].Trim();
                if (key.Length == 0 || Environment.GetEnvironmentVariable(key) is not null)
                {
                    continue;
                }

                var value = line[(separatorIndex + 1)..].Trim();
                if (value.Length >= 2 &&
                    ((value[0] == '"' && value[^1] == '"') || (value[0] == '\'' && value[^1] == '\'')))
                {
                    value = value[1..^1];
                }

                Environment.SetEnvironmentVariable(key, value);
            }

            return;
        }
    }

    private static string? FindFileInAncestors(string startDirectory, string fileName)
    {
        var directory = new DirectoryInfo(Path.GetFullPath(startDirectory));
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, fileName);
            if (System.IO.File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }

    private static GeminiClient CreateTestClient() => new(apiKey: "test-key");
}
