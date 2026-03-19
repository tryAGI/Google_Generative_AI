/*
order: 50
title: Chat Client Get Service Returns Self
slug: chat-client-get-service-returns-self
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IChatClient chatClient = client;

        var self = chatClient.GetService<GeminiClient>();

        self.Should().BeSameAs(client);
    }
}
