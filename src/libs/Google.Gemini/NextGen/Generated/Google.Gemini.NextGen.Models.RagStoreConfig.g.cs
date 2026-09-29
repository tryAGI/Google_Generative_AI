
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Use to specify configuration for RAG Store.
    /// </summary>
    public sealed partial class RagStoreConfig
    {
        /// <summary>
        /// Optional. The representation of the rag source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_resources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RagResource>? RagResources { get; set; }

        /// <summary>
        /// Specifies the context retrieval config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_retrieval_config")]
        public global::Google.Gemini.NextGen.RagRetrievalConfig? RagRetrievalConfig { get; set; }

        /// <summary>
        /// Optional. Number of top k results to return from the selected corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_top_k")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? SimilarityTopK { get; set; }

        /// <summary>
        /// Optional. Only return results with vector distance smaller than the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_distance_threshold")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? VectorDistanceThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagStoreConfig" /> class.
        /// </summary>
        /// <param name="ragResources">
        /// Optional. The representation of the rag source.
        /// </param>
        /// <param name="ragRetrievalConfig">
        /// Specifies the context retrieval config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagStoreConfig(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RagResource>? ragResources,
            global::Google.Gemini.NextGen.RagRetrievalConfig? ragRetrievalConfig)
        {
            this.RagResources = ragResources;
            this.RagRetrievalConfig = ragRetrievalConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagStoreConfig" /> class.
        /// </summary>
        public RagStoreConfig()
        {
        }

    }
}