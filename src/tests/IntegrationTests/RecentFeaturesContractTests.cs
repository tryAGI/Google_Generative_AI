using System.Net;
using System.Text.Json;
using NextGen = Google.Gemini.NextGen;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Gemini38Tts_SendsStructuredStyleVoiceAndFormat()
    {
        var requests = new List<(Uri Uri, string Body)>();
        using var transport = new HttpClient(new CaptureHandler(async request =>
        {
            requests.Add((request.RequestUri!, await request.Content!.ReadAsStringAsync()));
            return JsonResponse("""
                {"modelVersion":"gemini-3.8-flash-tts","candidates":[{"content":{"parts":[{"inlineData":{"mimeType":"audio/wav","data":"UklGRg=="}}]}}]}
                """);
        }));
        using var client = new GeminiClient("test-key", transport);

        var lite = await client.SpeakAsync("Hello.");
        var flash = await client.SpeakAdvancedAsync(
            "Welcome.", voiceName: "voice_abc", modelId: "gemini-3.8-flash-tts",
            style: "warm and clear", audioFormat: AudioResponseFormatMimeType.AudioL16);
        await client.SpeakAsync("Legacy.", modelId: "gemini-3.1-flash-tts-preview");

        Assert.IsTrue(lite.HasAudio);
        Assert.IsTrue(flash.HasAudio);
        StringAssert.Contains(requests[0].Uri.AbsolutePath, "gemini-3.8-flash-lite-tts");
        StringAssert.Contains(requests[1].Uri.AbsolutePath, "gemini-3.8-flash-tts");
        using var payload = JsonDocument.Parse(requests[1].Body);
        var config = payload.RootElement.GetProperty("generationConfig");
        Assert.AreEqual("voice_abc", config.GetProperty("speechConfig").GetProperty("voiceConfig").GetProperty("voice").GetString());
        Assert.AreEqual("AUDIO_L16", config.GetProperty("responseFormat").GetProperty("audio").GetProperty("mimeType").GetString());
        Assert.AreEqual("warm and clear", payload.RootElement.GetProperty("contents")[0].GetProperty("parts")[0]
            .GetProperty("speechMetadata").GetProperty("style").GetString());
        using var legacyPayload = JsonDocument.Parse(requests[2].Body);
        Assert.AreEqual("Puck", legacyPayload.RootElement.GetProperty("generationConfig")
            .GetProperty("speechConfig").GetProperty("voiceConfig")
            .GetProperty("prebuiltVoiceConfig").GetProperty("voiceName").GetString());
    }

    [TestMethod]
    public void AudioResult_WritesWavWithoutDuplicatingHeader()
    {
        var wav = "RIFF1234WAVEdata"u8.ToArray();
        using var destination = new MemoryStream();
        new AudioResult { AudioData = wav, MimeType = "audio/wav" }.WriteWavTo(destination);
        CollectionAssert.AreEqual(wav, destination.ToArray());

        using var rawDestination = new MemoryStream();
        new AudioResult { AudioData = [1, 2, 3, 4], MimeType = "audio/L16;rate=24000" }
            .WriteWavTo(rawDestination);
        Assert.AreEqual("RIFF", System.Text.Encoding.ASCII.GetString(rawDestination.ToArray(), 0, 4));
        Assert.AreEqual(48, rawDestination.Length);
    }

    [TestMethod]
    public async Task NextGenVoices_UsesOfficialPathsAndTypes()
    {
        var calls = new List<(HttpMethod Method, Uri Uri, string? Body)>();
        using var transport = new HttpClient(new CaptureHandler(async request =>
        {
            calls.Add((request.Method, request.RequestUri!,
                request.Content is null ? null : await request.Content.ReadAsStringAsync()));
            Assert.AreEqual("test-key", request.Headers.GetValues("x-goog-api-key").Single());
            return request.Method == HttpMethod.Post
                ? JsonResponse("""{"id":"voice_abc","type":"prompted"}""")
                : request.Method == HttpMethod.Get && request.RequestUri!.AbsolutePath.EndsWith("/voices", StringComparison.Ordinal)
                    ? JsonResponse("""{"voices":[{"id":"voice_abc","type":"prompted"}],"next_page_token":""}""")
                    : request.Method == HttpMethod.Get
                        ? JsonResponse("""{"id":"voice_abc","type":"prompted"}""")
                        : JsonResponse("{}");
        }));
        using var client = new NextGen.GeminiNextGenClient("test-key", transport);

        var created = await client.Voices.CreateAsync(new NextGen.CreateVoiceRequest
        {
            Store = true,
            Voice = new NextGen.Voice
            {
                Type = NextGen.VoiceType.Prompted,
                Prompted = new NextGen.PromptedVoice { Input = "A warm narrator" },
            },
        });
        var listed = await client.Voices.ListAsync(type: ["prompted"], pageSize: 20);
        var fetched = await client.Voices.GetAsync("voice_abc");
        await client.Voices.DeleteAsync("voice_abc");

        Assert.AreEqual("voice_abc", created.Id);
        Assert.AreEqual("voice_abc", listed.Voices?.Single().Id);
        Assert.AreEqual("voice_abc", fetched.Id);
        Assert.AreEqual(4, calls.Count);
        Assert.AreEqual("/v1beta/voices", calls[0].Uri.AbsolutePath);
        Assert.AreEqual("/v1beta/voices/voice_abc", calls[2].Uri.AbsolutePath);
        StringAssert.Contains(calls[1].Uri.Query, "type=prompted");
        using var payload = JsonDocument.Parse(calls[0].Body!);
        Assert.IsTrue(payload.RootElement.GetProperty("store").GetBoolean());
        Assert.AreEqual("A warm narrator", payload.RootElement.GetProperty("voice")
            .GetProperty("prompted").GetProperty("input").GetString());
    }

    [TestMethod]
    public async Task NextGenInteractions_AcceptsRecentlyReleasedModelIds()
    {
        string? requestBody = null;
        Uri? requestUri = null;
        using var transport = new HttpClient(new CaptureHandler(async request =>
        {
            requestUri = request.RequestUri;
            requestBody = await request.Content!.ReadAsStringAsync();
            return JsonResponse("""{"id":"interaction_1","created":"2026-09-30T00:00:00Z","status":"completed"}""");
        }));
        using var client = new NextGen.GeminiNextGenClient("test-key", transport);

        await client.Interactions.CreateAsync(new NextGen.CreateModelInteraction
        {
            Model = new NextGen.Model("lyria-3.5"),
            Input = "A short piano melody",
        });

        Assert.AreEqual("/v1beta/interactions", requestUri?.AbsolutePath);
        using var payload = JsonDocument.Parse(requestBody!);
        Assert.AreEqual("lyria-3.5", payload.RootElement.GetProperty("model").GetString());
        Assert.AreEqual("A short piano melody", payload.RootElement.GetProperty("input").GetString());
    }

    [TestMethod]
    public async Task NextGenVoices_ReplicatesWithSeparateConsentAudio()
    {
        string? requestBody = null;
        using var transport = new HttpClient(new CaptureHandler(async request =>
        {
            requestBody = await request.Content!.ReadAsStringAsync();
            return JsonResponse("""{"key":"voicekey_test","type":"replicated"}""");
        }));
        using var client = new NextGen.GeminiNextGenClient("test-key", transport);

        var voice = await client.Voices.CreateAsync(new NextGen.CreateVoiceRequest
        {
            Store = false,
            Voice = new NextGen.Voice
            {
                Type = NextGen.VoiceType.Replicated,
                Replicated = new NextGen.ReplicatedVoice
                {
                    SourceAudio = new NextGen.AudioData { Data = [1, 2], MimeType = "audio/wav" },
                    ConsentAudio = new NextGen.AudioData { Data = [3, 4], MimeType = "audio/wav" },
                },
            },
        });

        Assert.AreEqual("voicekey_test", voice.Key);
        using var payload = JsonDocument.Parse(requestBody!);
        Assert.IsFalse(payload.RootElement.GetProperty("store").GetBoolean());
        var replicated = payload.RootElement.GetProperty("voice").GetProperty("replicated");
        Assert.AreEqual("AQI=", replicated.GetProperty("source_audio").GetProperty("data").GetString());
        Assert.AreEqual("AwQ=", replicated.GetProperty("consent_audio").GetProperty("data").GetString());
    }

    [TestMethod]
    public async Task Gemini35Transcribe_SendsAudioFileAndConfigWithoutPrompt()
    {
        string? requestBody = null;
        Uri? requestUri = null;
        using var transport = new HttpClient(new CaptureHandler(async request =>
        {
            requestUri = request.RequestUri;
            requestBody = await request.Content!.ReadAsStringAsync();
            return JsonResponse("""{"candidates":[{"content":{"parts":[{"text":"hello"}]}}]}""");
        }));
        using var client = new GeminiClient("test-key", transport);

        var response = await client.Transcribe35FileAsync(
            new Uri("https://example.invalid/audio.wav"), "audio/wav",
            new AudioTranscriptionConfig { Mode = AudioTranscriptionConfigMode.Smart });

        Assert.AreEqual("hello", response.Candidates?[0].Content?.Parts?[0].Text);
        StringAssert.Contains(requestUri!.AbsolutePath, "gemini-3.5-transcribe");
        using var payload = JsonDocument.Parse(requestBody!);
        var part = payload.RootElement.GetProperty("contents")[0].GetProperty("parts")[0];
        Assert.AreEqual("https://example.invalid/audio.wav", part.GetProperty("fileData").GetProperty("fileUri").GetString());
        Assert.IsFalse(part.TryGetProperty("text", out _));
        Assert.AreEqual("SMART", payload.RootElement.GetProperty("generationConfig")
            .GetProperty("audioTranscriptionConfig").GetProperty("mode").GetString());
    }

    private static HttpResponseMessage JsonResponse(string json) => new(HttpStatusCode.OK)
    {
        Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json"),
    };

    private sealed class CaptureHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> respond) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => respond(request);
    }
}
