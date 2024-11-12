
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A citation to a source for a portion of a specific response.
    /// </summary>
    public sealed partial class CitationSource
    {
        /// <summary>
        /// Optional. End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Optional. License for the GitHub project that is attributed as a source for segment. License info is required for code citations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Optional. Start of segment of the response that is attributed to this source. Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Optional. URI that is attributed as a source for a portion of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationSource" /> class.
        /// </summary>
        /// <param name="endIndex">
        /// Optional. End of the attributed segment, exclusive.
        /// </param>
        /// <param name="license">
        /// Optional. License for the GitHub project that is attributed as a source for segment. License info is required for code citations.
        /// </param>
        /// <param name="startIndex">
        /// Optional. Start of segment of the response that is attributed to this source. Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="uri">
        /// Optional. URI that is attributed as a source for a portion of the text.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CitationSource(
            int? endIndex,
            string? license,
            int? startIndex,
            string? uri)
        {
            this.EndIndex = endIndex;
            this.License = license;
            this.StartIndex = startIndex;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationSource" /> class.
        /// </summary>
        public CitationSource()
        {
        }
    }
}