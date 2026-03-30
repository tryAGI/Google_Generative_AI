#nullable enable

namespace Google.Gemini;

using System.Runtime.CompilerServices;

/// <summary>
/// A wrapper around <see cref="GeminiLiveSession"/> that automatically reconnects
/// when the server sends a <see cref="LiveGoAway"/> message.
/// </summary>
/// <remarks>
/// <para>
/// The Gemini Live API server may send a <see cref="LiveGoAway"/> message to request
/// a graceful disconnect (e.g., for server maintenance). This wrapper detects GoAway
/// during <see cref="ReadEventsAsync"/> and transparently reconnects using session
/// resumption, preserving conversation context.
/// </para>
/// <para>
/// Session resumption is automatically enabled. The <see cref="LiveSetupConfig"/> must
/// not disable it. All <c>Send*</c> methods delegate to the current underlying session.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// await using var session = await client.ConnectResilientLiveAsync(config);
///
/// await session.SendTextAsync("Hello!");
/// await foreach (var message in session.ReadEventsAsync(cancellationToken))
/// {
///     // GoAway is handled automatically — events keep flowing after reconnect
///     if (message.ServerContent?.TurnComplete == true)
///         break;
/// }
/// </code>
/// </example>
public sealed class ResilientLiveSession : IAsyncDisposable
{
    private GeminiLiveSession _session;
    private readonly GeminiClient _client;
    private readonly LiveSetupConfig _config;
    private readonly int _maxReconnects;
    private readonly TimeSpan? _connectTimeout;
    private readonly TimeSpan? _keepAliveInterval;
    private bool _disposed;
    private int _reconnectCount;

    /// <summary>
    /// Creates a new resilient session wrapping an existing connected session.
    /// Prefer using <see cref="GeminiClientLiveExtensions.ConnectResilientLiveAsync"/> instead.
    /// </summary>
    /// <param name="session">The initial connected session.</param>
    /// <param name="client">The Gemini client for reconnection.</param>
    /// <param name="config">The setup config (will be modified to enable session resumption).</param>
    /// <param name="maxReconnects">Maximum number of automatic reconnections (default: 5).</param>
    /// <param name="connectTimeout">Connection timeout per reconnect attempt.</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval.</param>
    public ResilientLiveSession(
        GeminiLiveSession session,
        GeminiClient client,
        LiveSetupConfig config,
        int maxReconnects = 5,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null)
    {
        _session = session ?? throw new ArgumentNullException(nameof(session));
        _client = client ?? throw new ArgumentNullException(nameof(client));
        _config = config ?? throw new ArgumentNullException(nameof(config));
        _maxReconnects = maxReconnects;
        _connectTimeout = connectTimeout;
        _keepAliveInterval = keepAliveInterval;

        // Ensure session resumption is enabled for reconnection
        _config.SessionResumption ??= new LiveSessionResumptionConfig();
    }

    /// <summary>
    /// The current underlying <see cref="GeminiLiveSession"/>.
    /// This may change after a GoAway reconnection.
    /// </summary>
    public GeminiLiveSession CurrentSession => _session;

    /// <summary>
    /// The last received session resumption handle from the current or previous session.
    /// </summary>
    public string? LastSessionResumptionHandle => _session.LastSessionResumptionHandle;

    /// <summary>
    /// The number of automatic reconnections performed so far.
    /// </summary>
    public int ReconnectCount => _reconnectCount;

    /// <summary>
    /// Raised when a GoAway message is received and a reconnection is about to occur.
    /// </summary>
#pragma warning disable CA1003 // LiveGoAway is a data model, not an EventArgs subclass
    public event EventHandler<LiveGoAway>? GoAwayReceived;
#pragma warning restore CA1003

    /// <summary>
    /// Raised after a successful reconnection.
    /// </summary>
    public event EventHandler? Reconnected;

    /// <inheritdoc cref="GeminiLiveSession.SendTextAsync"/>
    public Task SendTextAsync(string text, CancellationToken cancellationToken = default)
        => _session.SendTextAsync(text, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendAudioAsync(ReadOnlyMemory{byte}, CancellationToken)"/>
    public Task SendAudioAsync(ReadOnlyMemory<byte> pcmData, CancellationToken cancellationToken = default)
        => _session.SendAudioAsync(pcmData, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendAudioAsync(ReadOnlyMemory{byte}, string, CancellationToken)"/>
    public Task SendAudioAsync(ReadOnlyMemory<byte> audioData, string mimeType, CancellationToken cancellationToken = default)
        => _session.SendAudioAsync(audioData, mimeType, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendVideoAsync"/>
    public Task SendVideoAsync(ReadOnlyMemory<byte> imageData, string mimeType = "image/jpeg", CancellationToken cancellationToken = default)
        => _session.SendVideoAsync(imageData, mimeType, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendClientContentAsync"/>
    [Obsolete("Gemini 3.1+ models reject clientContent. Use SendTextAsync for multi-turn conversations.")]
    public Task SendClientContentAsync(IList<Content> turns, bool turnComplete = true, CancellationToken cancellationToken = default)
        => _session.SendClientContentAsync(turns, turnComplete, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendToolResponseAsync"/>
    public Task SendToolResponseAsync(IList<FunctionResponse> responses, CancellationToken cancellationToken = default)
        => _session.SendToolResponseAsync(responses, cancellationToken);

    /// <inheritdoc cref="GeminiLiveSession.SendMessageAsync"/>
    public Task SendMessageAsync(LiveClientMessage message, CancellationToken cancellationToken = default)
        => _session.SendMessageAsync(message, cancellationToken);

    /// <summary>
    /// Streams server events, automatically reconnecting on <see cref="LiveGoAway"/> messages.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When a GoAway message is received, the current session is disposed and a new connection
    /// is established using the session resumption handle. The <see cref="GoAwayReceived"/> and
    /// <see cref="Reconnected"/> events are raised during this process. The GoAway message itself
    /// is <b>not</b> yielded to the caller.
    /// </para>
    /// <para>
    /// If the maximum reconnection count (<see cref="ReconnectCount"/>) is exceeded, the
    /// enumerable completes without throwing. The enumerable also completes gracefully on
    /// WebSocket close or cancellation.
    /// </para>
    /// </remarks>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async IAsyncEnumerable<LiveServerMessage> ReadEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (!_disposed && !cancellationToken.IsCancellationRequested)
        {
            bool goAwayReceived = false;

            await foreach (var message in _session.ReadEventsAsync(cancellationToken).ConfigureAwait(false))
            {
                if (message.GoAway is { } goAway)
                {
                    goAwayReceived = true;
                    GoAwayReceived?.Invoke(this, goAway);

                    if (_reconnectCount >= _maxReconnects)
                    {
                        yield break;
                    }

                    // Reconnect using session resumption
                    var handle = _session.LastSessionResumptionHandle;
                    await _session.DisposeAsync().ConfigureAwait(false);

                    _config.SessionResumption ??= new LiveSessionResumptionConfig();
                    _config.SessionResumption.Handle = handle;

                    _session = await _client.ConnectLiveAsync(
                        _config,
                        _connectTimeout,
                        _keepAliveInterval,
                        cancellationToken).ConfigureAwait(false);

                    _reconnectCount++;
                    Reconnected?.Invoke(this, EventArgs.Empty);
                    break; // Re-enter outer loop to read from new session
                }

                yield return message;
            }

            if (!goAwayReceived)
            {
                // Connection closed without GoAway — don't reconnect
                yield break;
            }
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        await _session.DisposeAsync().ConfigureAwait(false);
    }
}
