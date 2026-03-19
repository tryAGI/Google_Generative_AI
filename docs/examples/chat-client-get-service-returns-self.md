# Chat Client Get Service Returns Self



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var self = chatClient.GetService<GeminiClient>();
```