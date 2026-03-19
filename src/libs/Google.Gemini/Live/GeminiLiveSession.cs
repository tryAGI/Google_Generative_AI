#nullable enable

namespace Google.Gemini;

using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

/// <summary>
/// Represents an active session with the Gemini Live API over WebSocket.
/// Provides methods to send and receive real-time messages.
/// </summary>
public sealed class GeminiLiveSession : IAsyncDisposable
{
    private readonly ClientWebSocket _webSocket;
    private readonly JsonSerializerOptions _jsonOptions;
    private bool _disposed;

    /// <summary>
    /// Creates a new session from an already-connected WebSocket.
    /// Prefer using <see cref="GeminiClientLiveExtensions.ConnectLiveAsync"/> instead.
    /// </summary>
    public GeminiLiveSession(ClientWebSocket webSocket, JsonSerializerOptions jsonOptions)
    {
        _webSocket = webSocket ?? throw new ArgumentNullException(nameof(webSocket));
        _jsonOptions = jsonOptions ?? throw new ArgumentNullException(nameof(jsonOptions));
    }

    /// <summary>
    /// The JSON serializer options used for message serialization.
    /// </summary>
    public JsonSerializerOptions JsonOptions => _jsonOptions;

    /// <summary>
    /// The last received session resumption token, if any.
    /// Use this value in <see cref="LiveSessionResumptionConfig.Handle"/> when reconnecting.
    /// </summary>
    public string? LastSessionResumptionHandle { get; private set; }

    /// <summary>
    /// Sends raw audio data (16-bit PCM, 16kHz, little-endian, mono).
    /// </summary>
    /// <param name="pcmData">The raw PCM audio bytes.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendAudioAsync(
        ReadOnlyMemory<byte> pcmData,
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            RealtimeInput = new LiveRealtimeInput
            {
                MediaChunks =
                [
                    new Blob
                    {
                        MimeType = "audio/pcm;rate=16000",
                        Data = pcmData.ToArray(),
                    },
                ],
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends raw audio data with a custom MIME type.
    /// </summary>
    /// <param name="audioData">The audio bytes.</param>
    /// <param name="mimeType">The audio MIME type (e.g., "audio/pcm;rate=16000", "audio/pcm;rate=24000").</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendAudioAsync(
        ReadOnlyMemory<byte> audioData,
        string mimeType,
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            RealtimeInput = new LiveRealtimeInput
            {
                MediaChunks =
                [
                    new Blob
                    {
                        MimeType = mimeType,
                        Data = audioData.ToArray(),
                    },
                ],
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends a video frame (e.g., JPEG image data).
    /// </summary>
    /// <param name="imageData">The image bytes.</param>
    /// <param name="mimeType">The image MIME type (e.g., "image/jpeg").</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendVideoAsync(
        ReadOnlyMemory<byte> imageData,
        string mimeType = "image/jpeg",
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            RealtimeInput = new LiveRealtimeInput
            {
                MediaChunks =
                [
                    new Blob
                    {
                        MimeType = mimeType,
                        Data = imageData.ToArray(),
                    },
                ],
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends text content as a complete turn.
    /// </summary>
    /// <param name="text">The text to send.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendTextAsync(
        string text,
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            ClientContent = new LiveClientContent
            {
                Turns =
                [
                    new Content
                    {
                        Role = "user",
                        Parts = [new Part { Text = text }],
                    },
                ],
                TurnComplete = true,
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends turn-based conversation content.
    /// </summary>
    /// <param name="turns">The conversation turns.</param>
    /// <param name="turnComplete">Whether the client turn is complete.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendClientContentAsync(
        IList<Content> turns,
        bool turnComplete = true,
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            ClientContent = new LiveClientContent
            {
                Turns = turns,
                TurnComplete = turnComplete,
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends function/tool response results back to the model.
    /// </summary>
    /// <param name="responses">The function responses.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public Task SendToolResponseAsync(
        IList<FunctionResponse> responses,
        CancellationToken cancellationToken = default)
    {
        var message = new LiveClientMessage
        {
            ToolResponse = new LiveToolResponse
            {
                FunctionResponses = responses,
            },
        };

        return SendMessageAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends a raw client message to the server.
    /// </summary>
    /// <param name="message">The client message to send.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task SendMessageAsync(
        LiveClientMessage message,
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        var json = JsonSerializer.Serialize(message, _jsonOptions);
        var payload = Encoding.UTF8.GetBytes(json);

        await _webSocket.SendAsync(
            new ArraySegment<byte>(payload),
            WebSocketMessageType.Text,
            endOfMessage: true,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Receives a single server message.
    /// Returns null if the connection is closed.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task<LiveServerMessage?> ReceiveAsync(
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        var json = await ReceiveJsonMessageAsync(cancellationToken).ConfigureAwait(false);
        if (json == null)
        {
            return null;
        }

        var message = JsonSerializer.Deserialize<LiveServerMessage>(json, _jsonOptions);

        if (message?.SessionResumptionUpdate?.NewHandle is { Length: > 0 } handle)
        {
            LastSessionResumptionHandle = handle;
        }

        return message;
    }

    /// <summary>
    /// Streams all server events as an async enumerable.
    /// Completes when the connection is closed or cancelled.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async IAsyncEnumerable<LiveServerMessage> ReadEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (_webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
        {
            LiveServerMessage? message;
            try
            {
                message = await ReceiveAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                yield break;
            }
            catch (OperationCanceledException)
            {
                yield break;
            }

            if (message == null)
            {
                yield break;
            }

            yield return message;
        }
    }

    private async Task<string?> ReceiveJsonMessageAsync(CancellationToken cancellationToken)
    {
        var buffer = new byte[8192];
        using var ms = new MemoryStream();

        while (true)
        {
            var result = await _webSocket.ReceiveAsync(
                new ArraySegment<byte>(buffer),
                cancellationToken).ConfigureAwait(false);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                return null;
            }

            // Gemini Live API sends JSON as Binary frames (not Text).
            // Process both Text and Binary frames as JSON.
            await ms.WriteAsync(
                buffer.AsMemory(0, result.Count),
                cancellationToken).ConfigureAwait(false);

            if (result.EndOfMessage)
            {
                break;
            }
        }

        return Encoding.UTF8.GetString(ms.ToArray());
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        if (_webSocket.State == WebSocketState.Open)
        {
            try
            {
                await _webSocket.CloseAsync(
                    WebSocketCloseStatus.NormalClosure,
                    "Closing",
                    CancellationToken.None).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                // Connection may already be closed
            }
        }

        _webSocket.Dispose();
        GC.SuppressFinalize(this);
    }
}
