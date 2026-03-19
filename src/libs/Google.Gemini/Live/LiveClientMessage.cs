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
#pragma warning disable CA2227 // Collection properties should be read only — needed for JSON deserialization
    public IList<Content>? Turns { get; set; }
#pragma warning restore CA2227

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
#pragma warning disable CA2227 // Collection properties should be read only — needed for JSON deserialization
    public IList<FunctionResponse>? FunctionResponses { get; set; }
#pragma warning restore CA2227
}
