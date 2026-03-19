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
    /// Sends raw audio data as 16-bit PCM, 16kHz, little-endian, mono.
    /// </summary>
    /// <remarks>
    /// The audio is sent with MIME type <c>audio/pcm;rate=16000</c>.
    /// For other sample rates or formats, use the overload that accepts a MIME type.
    /// Audio input does not automatically trigger a model response — call
    /// <see cref="SendClientContentAsync"/> with <c>turnComplete: true</c> to signal end of turn,
    /// or rely on the server's voice activity detection (VAD).
    /// </remarks>
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
    /// Sends a video frame (e.g., JPEG image data) as realtime input.
    /// </summary>
    /// <remarks>
    /// For streaming video, send frames at approximately 1-10 fps.
    /// Supported formats include JPEG and PNG. The server processes frames
    /// alongside any audio being streamed.
    /// </remarks>
    /// <param name="imageData">The image bytes.</param>
    /// <param name="mimeType">The image MIME type (e.g., <c>"image/jpeg"</c>).</param>
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
    /// Sends text content as a complete user turn, triggering a model response.
    /// </summary>
    /// <remarks>
    /// This is a convenience method that wraps the text in a <see cref="Content"/> with
    /// <c>Role = "user"</c> and sets <c>TurnComplete = true</c>. For multi-turn
    /// conversation history, use <see cref="SendClientContentAsync"/> instead.
    /// </remarks>
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
    /// Sends turn-based conversation content with explicit turn management.
    /// </summary>
    /// <remarks>
    /// Use this method to send multi-turn conversation history or to signal end of turn
    /// after streaming audio. Each <see cref="Content"/> in <paramref name="turns"/>
    /// should have a <c>Role</c> of either <c>"user"</c> or <c>"model"</c>.
    /// Set <paramref name="turnComplete"/> to <see langword="true"/> to trigger a model response,
    /// or <see langword="false"/> to indicate more input will follow.
    /// </remarks>
    /// <param name="turns">The conversation turns (user and model messages).</param>
    /// <param name="turnComplete">Whether the client turn is complete and the model should respond.</param>
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
    /// Sends function/tool response results back to the model after a <see cref="LiveToolCall"/>.
    /// </summary>
    /// <remarks>
    /// Call this method after receiving a <see cref="LiveServerMessage.ToolCall"/> event.
    /// Each <see cref="FunctionResponse"/> must include the <c>Id</c> from the corresponding
    /// <see cref="FunctionCall"/>. The model will resume generating its response after
    /// receiving all tool results. If the user interrupts during a pending tool call,
    /// the server may send a <see cref="LiveToolCallCancellation"/> instead.
    /// </remarks>
    /// <param name="responses">The function responses matching pending tool calls.</param>
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
    /// Receives a single server message, or <see langword="null"/> if the connection is closed.
    /// </summary>
    /// <remarks>
    /// Automatically tracks <see cref="LiveSessionResumptionUpdate.NewHandle"/> tokens
    /// and stores them in <see cref="LastSessionResumptionHandle"/>.
    /// For most use cases, prefer <see cref="ReadEventsAsync"/> which streams all events
    /// as an <see cref="IAsyncEnumerable{T}"/>.
    /// </remarks>
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
    /// Streams all server events as an async enumerable until the connection closes or is cancelled.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The enumerable completes gracefully (without throwing) when the WebSocket connection
    /// closes or when <paramref name="cancellationToken"/> is cancelled. WebSocket errors
    /// also cause graceful completion rather than exceptions.
    /// </para>
    /// <para>
    /// Callers typically <see langword="break"/> out of the loop when
    /// <see cref="LiveServerContent.TurnComplete"/> is <see langword="true"/>, then call
    /// this method again for the next turn. To handle server-initiated disconnects,
    /// check for <see cref="LiveServerMessage.GoAway"/> and reconnect using
    /// <see cref="GeminiClientLiveExtensions.ReconnectLiveAsync"/> or
    /// <see cref="ResilientLiveSession"/>.
    /// </para>
    /// </remarks>
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
