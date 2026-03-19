/*
order: 30
title: Chat Client Get Service Returns Chat Client Metadata
slug: chat-client-get-service-returns-chat-client-metadata
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsChatClientMetadata()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var metadata = chatClient.GetService<ChatClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(GeminiClient));
    }
}
