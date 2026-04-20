
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata returned to client when grounding is enabled.
    /// </summary>
    public sealed partial class GroundingMetadata
    {
        /// <summary>
        /// List of grounding support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundingSupports")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? GroundingSupports { get; set; }

        /// <summary>
        /// Image search queries used for grounding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageSearchQueries")]
        public global::System.Collections.Generic.IList<string>? ImageSearchQueries { get; set; }

        /// <summary>
        /// Google search entry point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchEntryPoint")]
        public global::Google.Gemini.SearchEntryPoint? SearchEntryPoint { get; set; }

        /// <summary>
        /// List of supporting references retrieved from specified grounding source. When streaming, this only contains the grounding chunks that have not been included in the grounding metadata of previous responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundingChunks")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? GroundingChunks { get; set; }

        /// <summary>
        /// Web search queries for the following-up web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSearchQueries")]
        public global::System.Collections.Generic.IList<string>? WebSearchQueries { get; set; }

        /// <summary>
        /// Optional. Resource name of the Google Maps widget context token that can be used with the PlacesContextElement widget in order to render contextual data. Only populated in the case that grounding with Google Maps is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("googleMapsWidgetContextToken")]
        public string? GoogleMapsWidgetContextToken { get; set; }

        /// <summary>
        /// Metadata related to retrieval in the grounding flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalMetadata")]
        public global::Google.Gemini.RetrievalMetadata? RetrievalMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingMetadata" /> class.
        /// </summary>
        /// <param name="groundingSupports">
        /// List of grounding support.
        /// </param>
        /// <param name="imageSearchQueries">
        /// Image search queries used for grounding.
        /// </param>
        /// <param name="searchEntryPoint">
        /// Google search entry point.
        /// </param>
        /// <param name="groundingChunks">
        /// List of supporting references retrieved from specified grounding source. When streaming, this only contains the grounding chunks that have not been included in the grounding metadata of previous responses.
        /// </param>
        /// <param name="webSearchQueries">
        /// Web search queries for the following-up web search.
        /// </param>
        /// <param name="googleMapsWidgetContextToken">
        /// Optional. Resource name of the Google Maps widget context token that can be used with the PlacesContextElement widget in order to render contextual data. Only populated in the case that grounding with Google Maps is enabled.
        /// </param>
        /// <param name="retrievalMetadata">
        /// Metadata related to retrieval in the grounding flow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingMetadata(
            global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? groundingSupports,
            global::System.Collections.Generic.IList<string>? imageSearchQueries,
            global::Google.Gemini.SearchEntryPoint? searchEntryPoint,
            global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? groundingChunks,
            global::System.Collections.Generic.IList<string>? webSearchQueries,
            string? googleMapsWidgetContextToken,
            global::Google.Gemini.RetrievalMetadata? retrievalMetadata)
        {
            this.GroundingSupports = groundingSupports;
            this.ImageSearchQueries = imageSearchQueries;
            this.SearchEntryPoint = searchEntryPoint;
            this.GroundingChunks = groundingChunks;
            this.WebSearchQueries = webSearchQueries;
            this.GoogleMapsWidgetContextToken = googleMapsWidgetContextToken;
            this.RetrievalMetadata = retrievalMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingMetadata" /> class.
        /// </summary>
        public GroundingMetadata()
        {
        }
    }
}