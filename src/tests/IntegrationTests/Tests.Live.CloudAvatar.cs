namespace Google.Gemini.IntegrationTests;

using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public partial class Tests
{
    [TestMethod]
    public void CloudLiveAvatar_UsesRegionalOAuthEndpointAndFullyQualifiedModel()
    {
        Assert.AreEqual(
            "wss://us-central1-aiplatform.googleapis.com/ws/google.cloud.aiplatform.v1.LlmBidiService/BidiGenerateContent",
            GeminiCloudLiveClient.GetWebSocketUri("us-central1").AbsoluteUri);
        Assert.AreEqual(
            "projects/test-project/locations/us-central1/publishers/google/models/gemini-3.8-live",
            GeminiCloudLiveClient.GetModelResourceName("test-project", "us-central1", "models/gemini-3.8-live"));
        Assert.AreEqual(
            "projects/test-project/locations/us-central1/publishers/google/models/gemini-3.8-live",
            GeminiCloudLiveClient.GetModelResourceName("test-project", "us-central1",
                "projects/test-project/locations/us-central1/publishers/google/models/gemini-3.8-live"));
        Assert.ThrowsExactly<ArgumentException>(() => GeminiCloudLiveClient.GetWebSocketUri("us-central1/other"));
    }

    [TestMethod]
    public void CloudLiveAvatar_SerializesPrebuiltAndCustomSetup()
    {
        var setup = GeminiCloudLiveClient.CreateAvatarSetup("Ben", "Puck");
        using var prebuilt = JsonDocument.Parse(SerializeSetup(setup));
        var payload = prebuilt.RootElement.GetProperty("setup");
        Assert.AreEqual("VIDEO", payload.GetProperty("generationConfig")
            .GetProperty("responseModalities")[0].GetString());
        Assert.AreEqual("Puck", payload.GetProperty("generationConfig")
            .GetProperty("speechConfig").GetProperty("voiceConfig")
            .GetProperty("prebuiltVoiceConfig").GetProperty("voiceName").GetString());
        Assert.AreEqual("Ben", payload.GetProperty("avatarConfig").GetProperty("avatarName").GetString());

        setup.AvatarConfig = new LiveAvatarConfig
        {
            CustomizedAvatar = new LiveCustomizedAvatar
            {
                ImageData = [1, 2, 3],
                ImageMimeType = "png",
            },
        };
        using var custom = JsonDocument.Parse(SerializeSetup(setup));
        Assert.AreEqual("AQID", custom.RootElement.GetProperty("setup")
            .GetProperty("avatarConfig").GetProperty("customizedAvatar")
            .GetProperty("imageData").GetString());
    }

    [TestMethod]
    public async Task CloudLiveAvatar_RejectsInvalidSetupBeforeConnecting()
    {
        var setup = GeminiCloudLiveClient.CreateAvatarSetup("Ben", "Puck");
        setup.GenerationConfig!.ResponseModalities = [GenerationConfigResponseModalitie.Audio];

        await Assert.ThrowsExactlyAsync<ArgumentException>(() => GeminiCloudLiveClient.ConnectAsync(
            "test-project", "us-central1", "test-token", setup));
    }

    [TestMethod]
    public void CloudLiveAvatar_ExtractsMp4ChunksWithoutAudio()
    {
        var content = new LiveServerContent
        {
            ModelTurn = new Content
            {
                Parts =
                [
                    new Part { InlineData = new Blob { MimeType = "video/mp4", Data = [1, 2] } },
                    new Part { InlineData = new Blob { MimeType = "audio/pcm", Data = [3, 4] } },
                    new Part { InlineData = new Blob { MimeType = "VIDEO/MP4; codecs=avc1", Data = [5, 6] } },
                ],
            },
        };

        CollectionAssert.AreEqual(new byte[] { 1, 2 }, content.GetVideoChunks().First().Data);
        CollectionAssert.AreEqual(new byte[] { 5, 6 }, content.GetVideoChunks().Last().Data);
        Assert.AreEqual(2, content.GetVideoChunks().Count());
    }

    [TestMethod]
    public async Task CloudLiveAvatar_UsesBearerHeaderAndReceivesMp4Message()
    {
        using var portReservation = new TcpListener(IPAddress.Loopback, 0);
        portReservation.Start();
        var port = ((IPEndPoint)portReservation.LocalEndpoint).Port;
        portReservation.Stop();

        using var listener = new HttpListener();
        listener.Prefixes.Add($"http://127.0.0.1:{port}/");
        listener.Start();
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        string? authorization = null;
        string? setupPayload = null;
        var server = Task.Run(async () =>
        {
            var context = await listener.GetContextAsync().WaitAsync(timeout.Token);
            authorization = context.Request.Headers["Authorization"];
            var webSocketContext = await context.AcceptWebSocketAsync(subProtocol: null);
            using var socket = webSocketContext.WebSocket;
            var buffer = new byte[16_384];
            var received = await socket.ReceiveAsync(buffer, timeout.Token);
            setupPayload = Encoding.UTF8.GetString(buffer, 0, received.Count);

            var acknowledgement = Encoding.UTF8.GetBytes("""{"setupComplete":{}}""");
            await socket.SendAsync(acknowledgement, WebSocketMessageType.Binary, true, timeout.Token);
            var response = Encoding.UTF8.GetBytes("""
                {"serverContent":{"modelTurn":{"parts":[{"inlineData":{"mimeType":"video/mp4","data":"AQID"}}]},"turnComplete":true}}
                """);
            await socket.SendAsync(response, WebSocketMessageType.Binary, true, timeout.Token);
            var closing = await socket.ReceiveAsync(buffer, timeout.Token);
            if (closing.MessageType == WebSocketMessageType.Close)
            {
                await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", timeout.Token);
            }
        }, timeout.Token);

        var setup = GeminiCloudLiveClient.CreateAvatarSetup("Ben", "Puck");
        await using (var session = await GeminiCloudLiveClient.ConnectCoreAsync(
                         new Uri($"ws://127.0.0.1:{port}/"),
                         GeminiCloudLiveClient.GetModelResourceName("test-project", "us-central1", setup.Model!),
                         "test-token", setup, cancellationToken: timeout.Token))
        {
            var response = await session.ReceiveAsync(timeout.Token);
            CollectionAssert.AreEqual(new byte[] { 1, 2, 3 },
                response!.ServerContent!.GetVideoChunks().Single().Data);
        }

        await server.WaitAsync(timeout.Token);
        Assert.AreEqual("Bearer test-token", authorization);
        using var serialized = JsonDocument.Parse(setupPayload!);
        Assert.AreEqual(
            "projects/test-project/locations/us-central1/publishers/google/models/gemini-3.8-live",
            serialized.RootElement.GetProperty("setup").GetProperty("model").GetString());
        Assert.AreEqual("Ben", serialized.RootElement.GetProperty("setup")
            .GetProperty("avatarConfig").GetProperty("avatarName").GetString());
    }

    private static string SerializeSetup(LiveSetupConfig setup)
    {
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };
        foreach (var converter in SourceGenerationContext.Default.Options.Converters)
        {
            options.Converters.Add(converter);
        }

        return JsonSerializer.Serialize(new LiveClientMessage { Setup = setup }, options);
    }
}
