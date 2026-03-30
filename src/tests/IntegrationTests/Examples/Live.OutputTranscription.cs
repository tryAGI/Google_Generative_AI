/*
order: 320
title: Live Output Transcription
slug: live-output-transcription
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_OutputTranscription()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Enables output audio transcription to receive text alongside audio.
            var config = CreateLiveConfig();
            config.OutputAudioTranscription = new LiveOutputAudioTranscription();

            await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

            //// Send a text message and collect transcription events.
            await session.SendTextAsync("Say the word hello", cts.Token);

            bool receivedTranscription = false;
            bool receivedAudio = false;
            await foreach (var message in session.ReadEventsAsync(cts.Token))
            {
                if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
                {
                    receivedAudio = true;
                }

                if (message.ServerContent?.OutputTranscription?.Text is { Length: > 0 })
                {
                    receivedTranscription = true;
                }

                if (message.ServerContent?.TurnComplete == true)
                {
                    break;
                }
            }

            receivedAudio.Should().BeTrue("model should return audio");
            receivedTranscription.Should().BeTrue("output transcription should be received");
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
