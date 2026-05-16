/*
order: 290
title: SpeechToTextClient Generated Audio
slug: speech-to-text-client-generated-audio
*/

using Microsoft.Extensions.AI;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GeneratedAudio()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// GeminiClient implements MEAI's ISpeechToTextClient, so it plugs
            //// directly into any MEAI-aware pipeline. Generate audio with
            //// SpeakAsync, then transcribe it back through the standard interface.
            var audio = await client.SpeakAsync(
                text: "Read aloud, slowly and clearly: The quick brown fox jumps over the lazy dog.");

            audio.HasAudio.Should().BeTrue("need audio to transcribe");

            ISpeechToTextClient stt = client;

            using var stream = new MemoryStream(audio.AudioData!);
            var response = await stt.GetTextAsync(stream);

            response.Text.Should().NotBeNullOrWhiteSpace();
            response.ModelId.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                                      ex.Message.Contains("only be used for TTS"))
        {
            Assert.Inconclusive("TTS model rejected input: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }

    [TestMethod]
    public void SpeechToTextClient_GetService_ReturnsMetadata()
    {
        using var client = CreateTestClient();
        ISpeechToTextClient stt = client;

        var metadata = stt.GetService(typeof(SpeechToTextClientMetadata)) as SpeechToTextClientMetadata;

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(GeminiClient));
    }

    [TestMethod]
    public void SpeechToTextClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        ISpeechToTextClient stt = client;

        var resolved = stt.GetService(typeof(ISpeechToTextClient));

        resolved.Should().BeSameAs(client);
    }

    [TestMethod]
    public void SpeechToTextClient_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        ISpeechToTextClient stt = client;

        stt.GetService(typeof(ISpeechToTextClient), serviceKey: "unknown").Should().BeNull();
    }
}
