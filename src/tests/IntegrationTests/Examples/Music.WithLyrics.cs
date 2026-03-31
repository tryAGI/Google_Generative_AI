/*
order: 301
title: Generate Music With Lyrics
slug: generate-music-with-lyrics
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(120_000)]
    public async Task Music_WithLyrics()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            //// Generate music with vocals using structure tags and lyrics.
            var result = await client.GenerateMusicAsync(
                prompt: """
                    Pop ballad, female vocal, piano accompaniment, 90 BPM, C major

                    [Verse]
                    Walking through the morning light,
                    Everything feels warm and bright.

                    [Chorus]
                    This is where I want to be,
                    Under skies so wide and free.
                    """);

            result.HasMusic.Should().BeTrue();
            result.MusicData.Should().NotBeNullOrEmpty();
            result.MimeType.Should().NotBeNullOrWhiteSpace();
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.TooManyRequests)
        {
            Assert.Inconclusive("Rate limited: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.BadRequest)
        {
            Assert.Inconclusive("Music generation not supported: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
    }
}
