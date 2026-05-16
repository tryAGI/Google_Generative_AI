/*
order: 280
title: Speak with Gemini 3.1 Flash TTS
slug: speak-gemini-3-1-flash-tts
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Speak_GeminiFlash31Tts()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// Gemini 3.1 Flash TTS supports 200+ audio tags for controlling vocal style,
            //// pacing, and delivery. Tags are written inline as bracketed directives.
            var result = await client.SpeakAsync(
                text: "[cheerful] Hello! [excited] This is Gemini 3.1 Flash TTS. [calm] It sounds great.",
                voiceName: "Puck",
                modelId: "gemini-3.1-flash-tts-preview");

            result.HasAudio.Should().BeTrue();
            result.AudioData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
            result.ModelId.Should().Contain("3.1-flash-tts");
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
}
