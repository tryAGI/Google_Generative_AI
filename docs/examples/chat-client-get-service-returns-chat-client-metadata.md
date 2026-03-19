# Chat Client Get Service Returns Chat Client Metadata



This example assumes `using Google.Gemini;` is in scope and `apiKey` contains your Google.Gemini API key.

```csharp
using var client = CreateTestClient();
IChatClient chatClient = client;

var metadata = chatClient.GetService<ChatClientMetadata>();
```