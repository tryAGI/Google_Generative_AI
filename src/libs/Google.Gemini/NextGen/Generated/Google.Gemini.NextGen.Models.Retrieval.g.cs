
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model to retrieve files.
    /// </summary>
    public sealed partial class Retrieval
    {
        /// <summary>
        /// Used to specify configuration for ExaAISearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exa_ai_search_config")]
        public global::Google.Gemini.NextGen.ExaAISearchConfig? ExaAiSearchConfig { get; set; }

        /// <summary>
        /// Used to specify configuration for ParallelAISearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_ai_search_config")]
        public global::Google.Gemini.NextGen.ParallelAISearchConfig? ParallelAiSearchConfig { get; set; }

        /// <summary>
        /// Use to specify configuration for RAG Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_store_config")]
        public global::Google.Gemini.NextGen.RagStoreConfig? RagStoreConfig { get; set; }

        /// <summary>
        /// The types of file retrieval to enable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_types")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RetrievalRetrievalType>? RetrievalTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Used to specify configuration for VertexAISearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_ai_search_config")]
        public global::Google.Gemini.NextGen.VertexAISearchConfig? VertexAiSearchConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Retrieval" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="exaAiSearchConfig">
        /// Used to specify configuration for ExaAISearch.
        /// </param>
        /// <param name="parallelAiSearchConfig">
        /// Used to specify configuration for ParallelAISearch.
        /// </param>
        /// <param name="ragStoreConfig">
        /// Use to specify configuration for RAG Store.
        /// </param>
        /// <param name="retrievalTypes">
        /// The types of file retrieval to enable.
        /// </param>
        /// <param name="vertexAiSearchConfig">
        /// Used to specify configuration for VertexAISearch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Retrieval(
            object type,
            global::Google.Gemini.NextGen.ExaAISearchConfig? exaAiSearchConfig,
            global::Google.Gemini.NextGen.ParallelAISearchConfig? parallelAiSearchConfig,
            global::Google.Gemini.NextGen.RagStoreConfig? ragStoreConfig,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RetrievalRetrievalType>? retrievalTypes,
            global::Google.Gemini.NextGen.VertexAISearchConfig? vertexAiSearchConfig)
        {
            this.ExaAiSearchConfig = exaAiSearchConfig;
            this.ParallelAiSearchConfig = parallelAiSearchConfig;
            this.RagStoreConfig = ragStoreConfig;
            this.RetrievalTypes = retrievalTypes;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.VertexAiSearchConfig = vertexAiSearchConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Retrieval" /> class.
        /// </summary>
        public Retrieval()
        {
        }

    }
}