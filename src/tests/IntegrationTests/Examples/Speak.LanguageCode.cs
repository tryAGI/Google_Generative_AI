/*
order: 285
title: Speak with Language Code
slug: speak-language-code
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Speak_LanguageCode()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// Gemini 3.1 Flash TTS supports 70+ languages. Pass a BCP-47
            //// languageCode to bias the model toward a specific locale's
            //// pronunciation and prosody.
            var result = await client.SpeakAsync(
                text: "Hola, ¿cómo estás hoy? Espero que tengas un día maravilloso.",
                voiceName: GeminiVoices.Kore,
                modelId: "gemini-3.1-flash-tts-preview",
                languageCode: "es-ES");

            result.HasAudio.Should().BeTrue();
            result.AudioData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
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
