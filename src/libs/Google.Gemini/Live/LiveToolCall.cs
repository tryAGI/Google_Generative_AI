#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// A tool/function call request from the model during a Live API session.
/// </summary>
public sealed class LiveToolCall
{
    /// <summary>
    /// The function calls requested by the model.
    /// </summary>
    [JsonPropertyName("functionCalls")]
#pragma warning disable CA2227 // Collection properties should be read only — needed for JSON deserialization
    public IList<FunctionCall>? FunctionCalls { get; set; }
#pragma warning restore CA2227
}

/// <summary>
/// Cancellation of pending tool calls, typically due to user interruption.
/// </summary>
public sealed class LiveToolCallCancellation
{
    /// <summary>
    /// The IDs of the function calls to cancel.
    /// </summary>
    [JsonPropertyName("ids")]
#pragma warning disable CA2227 // Collection properties should be read only — needed for JSON deserialization
    public IList<string>? Ids { get; set; }
#pragma warning restore CA2227
}
