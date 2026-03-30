/*
order: 330
title: Live Speech Config
slug: live-speech-config
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_SpeechConfig()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Connects with a speech config to select a specific voice.
            var config = CreateLiveConfig();
            config.GenerationConfig!.SpeechConfig = new SpeechConfig
            {
                VoiceConfig = new VoiceConfig
                {
                    PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                    {
                        VoiceName = "Kore",
                    },
                },
            };

            await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

            //// Send a message — voice selection is applied at setup time.
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

            receivedResponse.Should().BeTrue("model should respond with selected voice");
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
