#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// Sent by the server to signal that the connection will be terminated soon.
/// The client should gracefully disconnect and optionally reconnect using session resumption.
/// </summary>
public sealed class LiveGoAway
{
    /// <summary>
    /// The remaining time before the server closes the connection, as a Duration string (e.g., "30s").
    /// </summary>
    [JsonPropertyName("timeLeft")]
    public string? TimeLeft { get; set; }
}
