/*
order: 260
title: Speak Different Voice
slug: speak-different-voice
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Speak_DifferentVoice()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var result = await client.SpeakAsync(
                text: "Say calmly: Testing with a different voice. This should sound professional.",
                voiceName: "Kore");

            result.HasAudio.Should().BeTrue();
            result.AudioData.Should().NotBeNullOrEmpty();
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
