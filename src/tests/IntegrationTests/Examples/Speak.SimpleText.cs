/*
order: 270
title: Speak Simple Text
slug: speak-simple-text
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Speak_SimpleText()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            var result = await client.SpeakAsync(
                text: "Say cheerfully: Hello, this is a test of text to speech. Have a wonderful day!",
                voiceName: "Puck");

            result.HasAudio.Should().BeTrue();
            result.AudioData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest &&
                                      ex.Message.Contains("only be used for TTS"))
        {
            Assert.Inconclusive("TTS model rejected input: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
