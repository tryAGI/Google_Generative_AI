using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Live_ModelMatrix_CompletesTextTurn()
    {
        if (!string.Equals(
                System.Environment.GetEnvironmentVariable("GOOGLE_GEMINI_LIVE_MATRIX_E2E"),
                "true",
                StringComparison.OrdinalIgnoreCase))
        {
            throw new AssertInconclusiveException(
                "Set GOOGLE_GEMINI_LIVE_MATRIX_E2E=true to run the metered Gemini Live model matrix.");
        }

        var variants = new (string Model, string? Effort)[]
        {
            (GeminiLiveModelCatalog.Gemini38Live, null),
            (GeminiLiveModelCatalog.Gemini31FlashLive, "minimal"),
            (GeminiLiveModelCatalog.Gemini31FlashLive, "high"),
            (GeminiLiveModelCatalog.Gemini38LiveExtendedThinking, "high"),
        };

        using var client = GetAuthenticatedClient();
        foreach (var (model, effort) in variants)
        {
            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(60));
            var config = new LiveSetupConfig
            {
                Model = model,
                GenerationConfig = new GenerationConfig
                {
                    ResponseModalities = [GenerationConfigResponseModalitie.Audio],
                },
                OutputAudioTranscription = new LiveOutputAudioTranscription(),
            };
            GeminiLiveModelCatalog.ApplyThinkingEffort(config, effort);

            try
            {
                await using var session = await client.ConnectLiveAsync(config, cancellationToken: timeout.Token);
                await session.SendTextAsync("Reply with the single word ready.", timeout.Token);

                var receivedResponse = false;
                var completed = false;
                await foreach (var message in session.ReadEventsAsync(timeout.Token))
                {
                    receivedResponse |= message.ServerContent?.ModelTurn?.Parts is { Count: > 0 } ||
                                        message.ServerContent?.OutputTranscription?.Text is { Length: > 0 };
                    completed = GeminiLiveModelCatalog.IsExtendedThinking(model)
                        ? message.IsInteractionIdle
                        : message.ServerContent?.TurnComplete == true;
                    if (completed)
                    {
                        break;
                    }
                }

                receivedResponse.Should().BeTrue($"{model} ({effort ?? "no thinking"}) should return model content");
                completed.Should().BeTrue($"{model} ({effort ?? "no thinking"}) should emit its terminal lifecycle signal");
            }
            catch (WebSocketException exception)
            {
                Assert.Fail($"{model} ({effort ?? "no thinking"}) WebSocket failed: {exception.Message}");
            }
            catch (OperationCanceledException)
            {
                Assert.Fail($"{model} ({effort ?? "no thinking"}) timed out before completing a turn.");
            }
        }
    }
}
