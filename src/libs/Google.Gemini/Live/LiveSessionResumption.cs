#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// Session resumption update from the server, providing a token for reconnecting.
/// </summary>
public sealed class LiveSessionResumptionUpdate
{
    /// <summary>
    /// The session handle/token to use when reconnecting.
    /// Pass this value as <see cref="LiveSessionResumptionConfig.Handle"/> in the setup config.
    /// </summary>
    [JsonPropertyName("newHandle")]
    public string? NewHandle { get; set; }

    /// <summary>
    /// If true, the session has been fully resumed from the provided handle.
    /// </summary>
    [JsonPropertyName("resumable")]
    public bool? Resumable { get; set; }
}
