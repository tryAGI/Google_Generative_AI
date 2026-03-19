#nullable enable

namespace Google.Gemini;

using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

/// <summary>
/// Extension methods for connecting to the Gemini Live API.
/// </summary>
public static class GeminiClientLiveExtensions
{
    private const string DefaultLiveModel = "models/gemini-2.5-flash-native-audio-latest";
    private const string WssBaseUri = "wss://generativelanguage.googleapis.com/ws/google.ai.generativelanguage.v1beta.GenerativeService.BidiGenerateContent";

    /// <summary>
    /// Connects to the Gemini Live API and returns an active session.
    /// Sends the setup message and waits for <see cref="LiveSetupComplete"/> before returning.
    /// </summary>
    /// <param name="client">The authenticated Gemini client (must have an API key).</param>
    /// <param name="config">The setup configuration for the session.</param>
    /// <param name="connectTimeout">Connection timeout (default: 30 seconds).</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval (default: 20 seconds).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A connected <see cref="GeminiLiveSession"/> ready for bidirectional communication.</returns>
    /// <exception cref="InvalidOperationException">Thrown if no API key is found in client authorizations.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the server does not respond with SetupComplete.</exception>
    public static async Task<GeminiLiveSession> ConnectLiveAsync(
        this GeminiClient client,
        LiveSetupConfig config,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(config);

        var timeout = connectTimeout ?? TimeSpan.FromSeconds(30);
        var keepAlive = keepAliveInterval ?? TimeSpan.FromSeconds(20);

        // Extract API key from client authorizations
        var apiKey = client.Authorizations
            .Where(a => a is { Name: "key", Location: "Query" })
            .Select(a => a.Value)
            .FirstOrDefault();

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "An API key is required for the Live API. " +
                "Create the GeminiClient with an API key: new GeminiClient(apiKey).");
        }

        // Ensure model is set
        config.Model ??= DefaultLiveModel;

        // Build JSON serializer options that can handle both Live types and SDK-generated types.
        // Use the SDK's SourceGenerationContext converters (for enums etc.) with reflection fallback
        // for Live types. This ensures both SDK types and Live types serialize correctly.
        var jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        foreach (var converter in SourceGenerationContext.Default.Options.Converters)
        {
            jsonOptions.Converters.Add(converter);
        }

        // Build WebSocket URI with API key
        var uri = new Uri($"{WssBaseUri}?key={Uri.EscapeDataString(apiKey)}");

        // Create and configure WebSocket
        var webSocket = new ClientWebSocket();
        GeminiLiveSession? session = null;

        try
        {
            webSocket.Options.KeepAliveInterval = keepAlive;

            // Connect with timeout
            using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            cts.CancelAfter(timeout);

            await webSocket.ConnectAsync(uri, cts.Token).ConfigureAwait(false);

            session = new GeminiLiveSession(webSocket, jsonOptions);

            // Send setup message
            var setupMessage = new LiveClientMessage { Setup = config };
            await session.SendMessageAsync(setupMessage, cts.Token).ConfigureAwait(false);

            // Wait for SetupComplete
            var response = await session.ReceiveAsync(cts.Token).ConfigureAwait(false);

            if (response?.SetupComplete == null)
            {
                throw new InvalidOperationException(
                    "Expected SetupComplete from the server but received a different message.");
            }

            return session;
        }
        catch
        {
            if (session != null)
            {
                await session.DisposeAsync().ConfigureAwait(false);
            }
            else
            {
                webSocket.Dispose();
            }

            throw;
        }
    }

    /// <summary>
    /// Reconnects to the Gemini Live API using the session resumption handle from a previous session.
    /// This automatically sets <see cref="LiveSessionResumptionConfig.Handle"/> from the previous session's
    /// <see cref="GeminiLiveSession.LastSessionResumptionHandle"/>.
    /// </summary>
    /// <param name="client">The authenticated Gemini client.</param>
    /// <param name="previousSession">The previous session whose resumption handle will be used.</param>
    /// <param name="config">The setup configuration for the new session.</param>
    /// <param name="connectTimeout">Connection timeout (default: 30 seconds).</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval (default: 20 seconds).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A new connected <see cref="GeminiLiveSession"/> that resumes the previous session.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the previous session has no resumption handle.</exception>
    public static Task<GeminiLiveSession> ReconnectLiveAsync(
        this GeminiClient client,
        GeminiLiveSession previousSession,
        LiveSetupConfig config,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(previousSession);
        ArgumentNullException.ThrowIfNull(config);

        var handle = previousSession.LastSessionResumptionHandle;
        if (string.IsNullOrEmpty(handle))
        {
            throw new InvalidOperationException(
                "The previous session has no resumption handle. " +
                "Ensure SessionResumption is enabled in the setup config.");
        }

        config.SessionResumption ??= new LiveSessionResumptionConfig();
        config.SessionResumption.Handle = handle;

        return client.ConnectLiveAsync(config, connectTimeout, keepAliveInterval, cancellationToken);
    }
}
