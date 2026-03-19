#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// A message sent from the client to the Live API server.
/// Exactly one of the properties should be set.
/// </summary>
public sealed class LiveClientMessage
{
    /// <summary>
    /// Setup configuration. Must be the first message sent.
    /// </summary>
    [JsonPropertyName("setup")]
    public LiveSetupConfig? Setup { get; set; }

    /// <summary>
    /// Real-time audio/text/video input chunks.
    /// </summary>
    [JsonPropertyName("realtimeInput")]
    public LiveRealtimeInput? RealtimeInput { get; set; }

    /// <summary>
    /// Turn-based content (conversation history or user turn).
    /// </summary>
    [JsonPropertyName("clientContent")]
    public LiveClientContent? ClientContent { get; set; }

    /// <summary>
    /// Tool/function response results.
    /// </summary>
    [JsonPropertyName("toolResponse")]
    public LiveToolResponse? ToolResponse { get; set; }
}

/// <summary>
/// Turn-based content sent from the client.
/// </summary>
public sealed class LiveClientContent
{
    /// <summary>
    /// Optional. Conversation turns to send.
    /// </summary>
    [JsonPropertyName("turns")]
    public IList<Content>? Turns { get; set; }

    /// <summary>
    /// If true, indicates that the current turn is complete.
    /// </summary>
    [JsonPropertyName("turnComplete")]
    public bool? TurnComplete { get; set; }
}

/// <summary>
/// Tool/function response sent from the client.
/// </summary>
public sealed class LiveToolResponse
{
    /// <summary>
    /// The function responses to send.
    /// </summary>
    [JsonPropertyName("functionResponses")]
    public IList<FunctionResponse>? FunctionResponses { get; set; }
}
