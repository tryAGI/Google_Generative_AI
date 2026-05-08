
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Context of the a single url retrieval.
    /// </summary>
    public sealed partial class UrlMetadata
    {
        /// <summary>
        /// Status of the url retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlRetrievalStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.UrlMetadataUrlRetrievalStatusJsonConverter))]
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? UrlRetrievalStatus { get; set; }

        /// <summary>
        /// Retrieved url by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievedUrl")]
        public string? RetrievedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlMetadata" /> class.
        /// </summary>
        /// <param name="urlRetrievalStatus">
        /// Status of the url retrieval.
        /// </param>
        /// <param name="retrievedUrl">
        /// Retrieved url by the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlMetadata(
            global::Google.Gemini.UrlMetadataUrlRetrievalStatus? urlRetrievalStatus,
            string? retrievedUrl)
        {
            this.UrlRetrievalStatus = urlRetrievalStatus;
            this.RetrievedUrl = retrievedUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlMetadata" /> class.
        /// </summary>
        public UrlMetadata()
        {
        }
    }
}