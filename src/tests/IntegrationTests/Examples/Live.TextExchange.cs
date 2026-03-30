/*
order: 300
title: Live Text Exchange
slug: live-text-exchange
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_TextExchange()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Connects to the Gemini Live API, sends text, receives audio response.
            await using var session = await client.ConnectLiveAsync(CreateLiveConfig(), cancellationToken: cts.Token);

            //// Send a simple text message.
            await session.SendTextAsync("Say hello", cts.Token);

            //// Read events until the model turn is complete.
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

            receivedResponse.Should().BeTrue("model should return a response");
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
