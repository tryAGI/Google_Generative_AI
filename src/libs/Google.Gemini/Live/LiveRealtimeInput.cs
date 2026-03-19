#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// Real-time input data (audio, text, video chunks) streamed to the server.
/// </summary>
public sealed class LiveRealtimeInput
{
    /// <summary>
    /// Optional. Audio data chunk (16-bit PCM 16kHz little-endian, base64-encoded via Blob.Data).
    /// </summary>
    [JsonPropertyName("mediaChunks")]
#pragma warning disable CA2227 // Collection properties should be read only — needed for JSON deserialization
    public IList<Blob>? MediaChunks { get; set; }
#pragma warning restore CA2227

    /// <summary>
    /// Optional. Text input.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Optional. Signal that the audio stream has ended.
    /// </summary>
    [JsonPropertyName("audioStreamEnd")]
    public bool? AudioStreamEnd { get; set; }

    /// <summary>
    /// Optional. Signal that user activity has started (for activity detection).
    /// </summary>
    [JsonPropertyName("activityStart")]
    public LiveActivityStart? ActivityStart { get; set; }

    /// <summary>
    /// Optional. Signal that user activity has ended (for activity detection).
    /// </summary>
    [JsonPropertyName("activityEnd")]
    public LiveActivityEnd? ActivityEnd { get; set; }
}

/// <summary>
/// Signal that user activity has started.
/// </summary>
public sealed class LiveActivityStart
{
}

/// <summary>
/// Signal that user activity has ended.
/// </summary>
public sealed class LiveActivityEnd
{
}
