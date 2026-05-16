/*
order: 252
title: List TTS Models
slug: list-tts-models
*/

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListTtsModels()
    {
        using var client = GetAuthenticatedClient();

        //// Discover every Gemini TTS model the API exposes today. Useful for
        //// surfacing newly released preview models without hard-coding IDs.
        var ttsModels = await client.ListTtsModelsAsync();

        foreach (var model in ttsModels)
        {
            Console.WriteLine($"{model.Name} -- {model.DisplayName}");
        }

        ttsModels.Should().NotBeEmpty();
        ttsModels.Should().Contain(m => m.Name == "models/gemini-3.1-flash-tts-preview");
    }
}
