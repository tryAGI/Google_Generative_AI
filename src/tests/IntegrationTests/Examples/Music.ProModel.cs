/*
order: 302
title: Generate Music Pro Model
slug: generate-music-pro-model
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(180_000)] // Pro model generates longer audio
    public async Task Music_ProModel()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// Generate a longer music piece using the Lyria 3 Pro model.
            var result = await client.GenerateMusicAsync(
                prompt: "Epic orchestral soundtrack with strings, brass, and timpani, building from soft to powerful, D minor, 100 BPM",
                modelId: "lyria-3-pro-preview");

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
