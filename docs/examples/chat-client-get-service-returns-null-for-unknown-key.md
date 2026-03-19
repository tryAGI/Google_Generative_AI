# Chat Client Get Service Returns Null For Unknown Key



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var result = chatClient.GetService<ChatClientMetadata>(serviceKey: "unknown");
```