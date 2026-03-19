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
    public IList<FunctionCall>? FunctionCalls { get; set; }
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
    public IList<string>? Ids { get; set; }
}
