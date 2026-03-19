#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// Configuration sent as the first message to set up a Live API session.
/// </summary>
public sealed class LiveSetupConfig
{
    /// <summary>
    /// Required. The model to use, e.g. "models/gemini-2.0-flash-live-001".
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// Optional. Generation configuration (temperature, top-p, response modalities, speech config, etc.).
    /// </summary>
    [JsonPropertyName("generationConfig")]
    public GenerationConfig? GenerationConfig { get; set; }

    /// <summary>
    /// Optional. System instruction for the session.
    /// </summary>
    [JsonPropertyName("systemInstruction")]
    public Content? SystemInstruction { get; set; }

    /// <summary>
    /// Optional. Tools available for this session (function declarations, Google Search, code execution).
    /// </summary>
    [JsonPropertyName("tools")]
    public IList<Tool>? Tools { get; set; }

    /// <summary>
    /// Optional. Configuration for how to handle tool calls.
    /// </summary>
    [JsonPropertyName("toolConfig")]
    public ToolConfig? ToolConfig { get; set; }

    /// <summary>
    /// Optional. Session resumption configuration for reconnecting to a previous session.
    /// </summary>
    [JsonPropertyName("sessionResumption")]
    public LiveSessionResumptionConfig? SessionResumption { get; set; }

    /// <summary>
    /// Optional. Context window compression configuration.
    /// When enabled, the server compresses context instead of truncating
    /// when the context window limit is reached.
    /// </summary>
    [JsonPropertyName("contextWindowCompression")]
    public LiveContextWindowCompression? ContextWindowCompression { get; set; }

    /// <summary>
    /// Optional. Input audio transcription configuration.
    /// When set, the server will send input audio transcription in server messages.
    /// </summary>
    [JsonPropertyName("inputAudioTranscription")]
    public LiveInputAudioTranscription? InputAudioTranscription { get; set; }

    /// <summary>
    /// Optional. Output audio transcription configuration.
    /// When set, the server will send output audio transcription in server messages.
    /// </summary>
    [JsonPropertyName("outputAudioTranscription")]
    public LiveOutputAudioTranscription? OutputAudioTranscription { get; set; }
}

/// <summary>
/// Configuration for session resumption on reconnection.
/// </summary>
public sealed class LiveSessionResumptionConfig
{
    /// <summary>
    /// Optional. A previously received session resumption token to resume from.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? Handle { get; set; }
}

/// <summary>
/// Configuration for context window compression.
/// </summary>
public sealed class LiveContextWindowCompression
{
    /// <summary>
    /// Optional. Sliding window mechanism configuration.
    /// </summary>
    [JsonPropertyName("slidingWindow")]
    public LiveSlidingWindow? SlidingWindow { get; set; }
}

/// <summary>
/// Sliding window compression mechanism.
/// </summary>
public sealed class LiveSlidingWindow
{
    /// <summary>
    /// Optional. Target number of tokens to retain after compression.
    /// </summary>
    [JsonPropertyName("targetTokens")]
    public int? TargetTokens { get; set; }
}

/// <summary>
/// Configuration for input audio transcription.
/// </summary>
public sealed class LiveInputAudioTranscription
{
}

/// <summary>
/// Configuration for output audio transcription.
/// </summary>
public sealed class LiveOutputAudioTranscription
{
}
