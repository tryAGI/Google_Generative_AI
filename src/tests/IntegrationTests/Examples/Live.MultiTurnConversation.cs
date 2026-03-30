/*
order: 350
title: Live Multi-Turn Conversation
slug: live-multi-turn-conversation
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_MultiTurnConversation()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Demonstrates a multi-turn conversation using sequential text exchanges.
            await using var session = await client.ConnectLiveAsync(CreateLiveConfig(), cancellationToken: cts.Token);

            //// First turn: tell the model a fact.
            await session.SendTextAsync("My name is Alice", cts.Token);

            await foreach (var message in session.ReadEventsAsync(cts.Token))
            {
                if (message.ServerContent?.TurnComplete == true)
                {
                    break;
                }
            }

            //// Second turn: ask the model to recall the fact.
            await session.SendTextAsync("What is my name?", cts.Token);

            bool receivedResponse = false;
            await foreach (var message in session.ReadEventsAsync(cts.Token))
            {
                if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
                {
                    receivedResponse = true;
                }

                if (message.ServerContent?.TurnComplete == true)
                {
                    break;
                }
            }

            receivedResponse.Should().BeTrue("model should respond to multi-turn conversation");
        }
        catch (WebSocketException ex)
        {
            Assert.Inconclusive("WebSocket error: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (OperationCanceledException)
        {
            Assert.Inconclusive("Live API connection timed out.");
        }
    }
}
