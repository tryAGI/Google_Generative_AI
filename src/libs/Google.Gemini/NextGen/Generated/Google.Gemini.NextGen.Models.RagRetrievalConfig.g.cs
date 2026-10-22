
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Specifies the context retrieval config.
    /// </summary>
    public sealed partial class RagRetrievalConfig
    {
        /// <summary>
        /// Optional. The number of contexts to retrieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Config for Hybrid Search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_search")]
        public global::Google.Gemini.NextGen.HybridSearch? HybridSearch { get; set; }

        /// <summary>
        /// Config for filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Google.Gemini.NextGen.Filter? Filter { get; set; }

        /// <summary>
        /// Config for ranking and reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking")]
        public global::Google.Gemini.NextGen.Ranking? Ranking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalConfig" /> class.
        /// </summary>
        /// <param name="topK">
        /// Optional. The number of contexts to retrieve.
        /// </param>
        /// <param name="hybridSearch">
        /// Config for Hybrid Search.
        /// </param>
        /// <param name="filter">
        /// Config for filters.
        /// </param>
        /// <param name="ranking">
        /// Config for ranking and reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagRetrievalConfig(
            int? topK,
            global::Google.Gemini.NextGen.HybridSearch? hybridSearch,
            global::Google.Gemini.NextGen.Filter? filter,
            global::Google.Gemini.NextGen.Ranking? ranking)
        {
            this.TopK = topK;
            this.HybridSearch = hybridSearch;
            this.Filter = filter;
            this.Ranking = ranking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalConfig" /> class.
        /// </summary>
        public RagRetrievalConfig()
        {
        }

    }
}