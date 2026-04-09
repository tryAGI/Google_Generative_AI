
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Retrieval config.
    /// </summary>
    public sealed partial class RetrievalConfig
    {
        /// <summary>
        /// Optional. The language code of the user. Language code for content. Use language tags defined by [BCP47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard. Values must be within normalized ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latLng")]
        public global::Google.Gemini.LatLng? LatLng { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalConfig" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// Optional. The language code of the user. Language code for content. Use language tags defined by [BCP47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt).
        /// </param>
        /// <param name="latLng">
        /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard. Values must be within normalized ranges.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalConfig(
            string? languageCode,
            global::Google.Gemini.LatLng? latLng)
        {
            this.LanguageCode = languageCode;
            this.LatLng = latLng;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalConfig" /> class.
        /// </summary>
        public RetrievalConfig()
        {
        }
    }
}