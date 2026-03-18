using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        IChatClient chatClient = client;
        var response = await chatClient.GetResponseAsync(
            messages:
            [
                new ChatMessage(ChatRole.User, "Generate 5 random words.")
            ],
            options: new ChatOptions
            {
                ModelId = modelId,
            });

        response.Messages.Should().ContainSingle();
        response.Text.Should().NotBeNullOrWhiteSpace();
        response.Messages[0].Role.Should().Be(ChatRole.Assistant);
        response.Messages[0].Text.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        IChatClient chatClient = client;
        var updates = chatClient.GetStreamingResponseAsync(
            messages:
            [
                new ChatMessage(ChatRole.User, "Generate 5 random words.")
            ],
            options: new ChatOptions
            {
                ModelId = modelId,
            });

        var deltas = new List<string>();
        await foreach (var update in updates)
        {
            if (!string.IsNullOrWhiteSpace(update.Text))
            {
                deltas.Add(update.Text);
            }
        }

        deltas.Should().NotBeEmpty();
        string.Concat(deltas).Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public void ChatClient_GetService_ReturnsChatClientMetadata()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var metadata = chatClient.GetService<ChatClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(GeminiClient));
    }

    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var self = chatClient.GetService<GeminiClient>();

        self.Should().BeSameAs(client);
    }

    [TestMethod]
    public void ChatClient_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var result = chatClient.GetService<ChatClientMetadata>(serviceKey: "unknown");

        result.Should().BeNull();
    }
}
