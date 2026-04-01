/*
order: 300
title: Generate Music Simple Prompt
slug: generate-music-simple-prompt
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(120_000)]
    public async Task Music_SimplePrompt()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// Generate a short music clip from a text prompt using the Lyria 3 Clip model.
            var result = await client.GenerateMusicAsync(
                prompt: "A cheerful acoustic guitar melody with a light percussion beat, major key, 120 BPM");

            result.HasMusic.Should().BeTrue();
            result.MusicData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (IsTransientAvailabilityIssue(ex))
        {
            AssertTransientAvailability(ex);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
        {
            Assert.Inconclusive("Music generation not supported: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
