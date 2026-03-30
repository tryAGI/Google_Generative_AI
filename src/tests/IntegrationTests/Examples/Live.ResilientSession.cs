/*
order: 380
title: Live Resilient Session
slug: live-resilient-session
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_ResilientSession()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Connects using ResilientLiveSession and verifies basic text exchange works.
            var config = CreateLiveConfig();

            await using var session = await client.ConnectResilientLiveAsync(
                config,
                cancellationToken: cts.Token);

            //// Send a text message through the resilient session.
            await session.SendTextAsync("Say hello", cts.Token);

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

            receivedResponse.Should().BeTrue("resilient session should return a response");
            session.ReconnectCount.Should().Be(0, "no GoAway expected in a short session");
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
