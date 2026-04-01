/*
order: 20
title: Chat Client Five Random Words
slug: chat-client-five-random-words
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
        using var client = GetAuthenticatedClient();
        var modelId = GetGenerateContentModelId();

        try
        {
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
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
    }
}
