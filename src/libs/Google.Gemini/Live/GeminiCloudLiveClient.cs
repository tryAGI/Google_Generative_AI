#nullable enable

namespace Google.Gemini;

using System.Net.WebSockets;
using System.Text.RegularExpressions;

/// <summary>
/// Connects to the Google Cloud Gemini Live API with an OAuth access token.
/// The Cloud endpoint is separate from the API-key Gemini Developer API endpoint.
/// </summary>
public static partial class GeminiCloudLiveClient
{
    private const string WebSocketPath = "/ws/google.cloud.aiplatform.v1.LlmBidiService/BidiGenerateContent";

    /// <summary>Creates the regional Google Cloud Live WebSocket URI.</summary>
    public static Uri GetWebSocketUri(string location)
    {
        ValidateResourceSegment(location, nameof(location));
        return new Uri($"wss://{location}-aiplatform.googleapis.com{WebSocketPath}");
    }

    /// <summary>Creates the fully qualified model resource used in the setup message.</summary>
    public static string GetModelResourceName(string projectId, string location, string modelId)
    {
        ValidateResourceSegment(projectId, nameof(projectId));
        ValidateResourceSegment(location, nameof(location));
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        var prefix = $"projects/{projectId}/locations/{location}/publishers/google/models/";
        var name = modelId.StartsWith(prefix, StringComparison.Ordinal)
            ? modelId[prefix.Length..]
            : modelId.StartsWith("models/", StringComparison.OrdinalIgnoreCase)
            ? modelId["models/".Length..]
            : modelId;
        if (!ModelIdPattern().IsMatch(name))
        {
            throw new ArgumentException("Use a bare model ID or models/<model ID>.", nameof(modelId));
        }

        return $"{prefix}{name}";
    }

    /// <summary>Creates a setup for a prebuilt Gemini 3.8 Live Avatar and voice.</summary>
    public static LiveSetupConfig CreateAvatarSetup(string avatarName, string voiceName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(avatarName);
        ArgumentException.ThrowIfNullOrWhiteSpace(voiceName);

        return new LiveSetupConfig
        {
            Model = GeminiLiveModelCatalog.Gemini38Live,
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Video],
                SpeechConfig = new SpeechConfig
                {
                    VoiceConfig = new VoiceConfig
                    {
                        PrebuiltVoiceConfig = new PrebuiltVoiceConfig { VoiceName = voiceName },
                    },
                },
            },
            AvatarConfig = new LiveAvatarConfig { AvatarName = avatarName },
        };
    }

    /// <summary>
    /// Connects to a regional Google Cloud Live endpoint and waits for setup acknowledgement.
    /// Supply an unexpired OAuth 2.0 access token obtained from Google Cloud credentials.
    /// </summary>
    public static async Task<GeminiLiveSession> ConnectAsync(
        string projectId,
        string location,
        string accessToken,
        LiveSetupConfig config,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        var uri = GetWebSocketUri(location);
        var modelResource = GetModelResourceName(
            projectId, location, config?.Model ?? GeminiLiveModelCatalog.Gemini38Live);
        return await ConnectCoreAsync(
            uri, modelResource, accessToken, config!, connectTimeout, keepAliveInterval, cancellationToken)
            .ConfigureAwait(false);
    }

    internal static async Task<GeminiLiveSession> ConnectCoreAsync(
        Uri uri,
        string modelResource,
        string accessToken,
        LiveSetupConfig config,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(config);
        ArgumentException.ThrowIfNullOrWhiteSpace(accessToken);
        if (accessToken.Any(char.IsWhiteSpace))
        {
            throw new ArgumentException("The access token must not contain whitespace.", nameof(accessToken));
        }

        var originalModel = config.Model;
        config.Model = modelResource[(modelResource.LastIndexOf('/') + 1)..];
        try
        {
            GeminiLiveModelCatalog.PrepareForConnection(config);
            ValidateAvatarSetup(config);
        }
        catch
        {
            config.Model = originalModel;
            throw;
        }

        config.Model = modelResource;

        // Ownership transfers to GeminiLiveSession after a successful connection.
#pragma warning disable CA2000
        var webSocket = new ClientWebSocket();
        GeminiLiveSession? session = null;
        try
        {
            webSocket.Options.KeepAliveInterval = keepAliveInterval ?? TimeSpan.FromSeconds(20);
            webSocket.Options.SetRequestHeader("Authorization", $"Bearer {accessToken}");

            using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            timeout.CancelAfter(connectTimeout ?? TimeSpan.FromSeconds(30));
            await webSocket.ConnectAsync(uri, timeout.Token).ConfigureAwait(false);

            session = new GeminiLiveSession(webSocket, LiveJsonContext.WithGeneratedConverters.Options);
            await session.SendMessageAsync(new LiveClientMessage { Setup = config }, timeout.Token)
                .ConfigureAwait(false);
            await GeminiClientLiveExtensions.WaitForSetupCompleteAsync(session.ReceiveAsync, timeout.Token)
                .ConfigureAwait(false);
            return session;
        }
        catch
        {
            if (session is not null)
            {
                await session.DisposeAsync().ConfigureAwait(false);
            }
            else
            {
                webSocket.Dispose();
            }

            throw;
        }
#pragma warning restore CA2000
    }

    private static void ValidateAvatarSetup(LiveSetupConfig config)
    {
        if (config.AvatarConfig is not { } avatar)
        {
            return;
        }

        if (config.GenerationConfig?.ResponseModalities is not { Count: 1 } modalities ||
            modalities[0] != GenerationConfigResponseModalitie.Video)
        {
            throw new ArgumentException("Live Avatar requires VIDEO as the sole response modality.", nameof(config));
        }

        var hasName = !string.IsNullOrWhiteSpace(avatar.AvatarName);
        var hasImage = avatar.CustomizedAvatar is not null;
        if (hasName == hasImage)
        {
            throw new ArgumentException("Choose exactly one prebuilt or custom avatar.", nameof(config));
        }

        if (hasImage && (avatar.CustomizedAvatar!.ImageData is not { Length: > 0 } image ||
                         image.Length >= 5_000_000 ||
                         string.IsNullOrWhiteSpace(avatar.CustomizedAvatar.ImageMimeType)))
        {
            throw new ArgumentException("Custom avatars require an image below 5 MB and an image format.", nameof(config));
        }
    }

    private static void ValidateResourceSegment(string value, string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, name);
        if (!ResourceSegmentPattern().IsMatch(value))
        {
            throw new ArgumentException("Use a Google Cloud project ID or location without a path.", name);
        }
    }

    [GeneratedRegex("^[a-zA-Z0-9][a-zA-Z0-9-]*$")]
    private static partial Regex ResourceSegmentPattern();

    [GeneratedRegex("^[a-zA-Z0-9][a-zA-Z0-9._-]*$")]
    private static partial Regex ModelIdPattern();
}
