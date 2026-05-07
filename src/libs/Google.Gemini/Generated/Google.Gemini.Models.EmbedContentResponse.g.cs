
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The response to an `EmbedContentRequest`.
    /// </summary>
    public sealed partial class EmbedContentResponse
    {
        /// <summary>
        /// Metadata on the usage of the embedding request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageMetadata")]
        public global::Google.Gemini.EmbeddingUsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// A list of floats representing an embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::Google.Gemini.ContentEmbedding? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentResponse" /> class.
        /// </summary>
        /// <param name="usageMetadata">
        /// Metadata on the usage of the embedding request.
        /// </param>
        /// <param name="embedding">
        /// A list of floats representing an embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedContentResponse(
            global::Google.Gemini.EmbeddingUsageMetadata? usageMetadata,
            global::Google.Gemini.ContentEmbedding? embedding)
        {
            this.UsageMetadata = usageMetadata;
            this.Embedding = embedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentResponse" /> class.
        /// </summary>
        public EmbedContentResponse()
        {
        }
    }
}