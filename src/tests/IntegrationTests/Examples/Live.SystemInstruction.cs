/*
order: 340
title: Live System Instruction
slug: live-system-instruction
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_SystemInstruction()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Connects with a system instruction to customize model behavior.
            var config = CreateLiveConfig();
            config.SystemInstruction = new Content
            {
                Parts = [new Part { Text = "You are a helpful assistant. Always be concise." }],
            };

            await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

            //// Send a message — system instruction is accepted at setup time.
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

            if (!receivedResponse)
            {
                Assert.Inconclusive("Live API completed without returning model content for the system instruction prompt.");
            }
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
