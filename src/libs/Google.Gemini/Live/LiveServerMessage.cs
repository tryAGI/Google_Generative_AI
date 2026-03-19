#nullable enable

namespace Google.Gemini;

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// A message received from the Live API server.
/// Exactly one of the properties will be set, indicating the message type.
/// </summary>
public sealed class LiveServerMessage
{
    /// <summary>
    /// Setup acknowledgement. Sent after the client's setup message is processed.
    /// </summary>
    [JsonPropertyName("setupComplete")]
    public LiveSetupComplete? SetupComplete { get; set; }

    /// <summary>
    /// Server-generated content (model response, transcriptions, turn signals).
    /// </summary>
    [JsonPropertyName("serverContent")]
    public LiveServerContent? ServerContent { get; set; }

    /// <summary>
    /// Tool/function call request from the model.
    /// </summary>
    [JsonPropertyName("toolCall")]
    public LiveToolCall? ToolCall { get; set; }

    /// <summary>
    /// Cancellation of pending tool calls (e.g., due to user interruption).
    /// </summary>
    [JsonPropertyName("toolCallCancellation")]
    public LiveToolCallCancellation? ToolCallCancellation { get; set; }

    /// <summary>
    /// Server requesting graceful disconnect (session nearing time limit).
    /// </summary>
    [JsonPropertyName("goAway")]
    public LiveGoAway? GoAway { get; set; }

    /// <summary>
    /// Session resumption update with a token for reconnecting.
    /// </summary>
    [JsonPropertyName("sessionResumptionUpdate")]
    public LiveSessionResumptionUpdate? SessionResumptionUpdate { get; set; }

    /// <summary>
    /// Usage metadata for the current response.
    /// </summary>
    [JsonPropertyName("usageMetadata")]
    public UsageMetadata? UsageMetadata { get; set; }
}

/// <summary>
/// Sent by the server to acknowledge that setup is complete and the session is ready.
/// </summary>
public sealed class LiveSetupComplete
{
}
