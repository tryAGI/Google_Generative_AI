#nullable enable

namespace Google.Gemini;

using System.Text.Json;

/// <summary>
/// Hand-written extension for <see cref="UsageMetadata"/> adding fields sent by
/// Gemini 3.1+ Live API that are not yet in the upstream Discovery spec.
/// These fields land in <see cref="UsageMetadata.AdditionalProperties"/> during
/// deserialization. This partial class provides typed accessors.
/// </summary>
/// <remarks>
/// Once the upstream Discovery spec includes <c>responseTokenCount</c> and
/// <c>responseTokensDetails</c>, regenerating the SDK will add them as first-class
/// properties and this file can be removed.
/// </remarks>
public partial class UsageMetadata
{
    /// <summary>
    /// Number of tokens in the response. Sent by Gemini 3.1+ Live API models
    /// instead of <see cref="CandidatesTokenCount"/>.
    /// Returns <see langword="null"/> if the field was not present in the server response.
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public int? ResponseTokenCount => GetAdditionalInt("responseTokenCount");

    /// <summary>
    /// List of modalities returned in the response with per-modality token counts.
    /// Sent by Gemini 3.1+ Live API models instead of <see cref="CandidatesTokensDetails"/>.
    /// Returns <see langword="null"/> if the field was not present in the server response.
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public IList<ModalityTokenCount>? ResponseTokensDetails =>
        GetAdditionalList<ModalityTokenCount>("responseTokensDetails");

    private int? GetAdditionalInt(string key)
    {
        if (!AdditionalProperties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            JsonElement je when je.ValueKind == JsonValueKind.Number => je.GetInt32(),
            int i => i,
            long l => (int)l,
            _ => null,
        };
    }

    private IList<T>? GetAdditionalList<T>(string key)
    {
        if (!AdditionalProperties.TryGetValue(key, out var value))
        {
            return null;
        }

        if (value is JsonElement je && je.ValueKind == JsonValueKind.Array)
        {
            return je.Deserialize<IList<T>>();
        }

        return null;
    }
}
