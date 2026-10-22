
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Config for filters.
    /// </summary>
    public sealed partial class Filter
    {
        /// <summary>
        /// Optional. Only returns contexts with vector distance smaller than the<br/>
        /// threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_distance_threshold")]
        public double? VectorDistanceThreshold { get; set; }

        /// <summary>
        /// Optional. Only returns contexts with vector similarity larger than the<br/>
        /// threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_similarity_threshold")]
        public double? VectorSimilarityThreshold { get; set; }

        /// <summary>
        /// Optional. String for metadata filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="vectorDistanceThreshold">
        /// Optional. Only returns contexts with vector distance smaller than the<br/>
        /// threshold.
        /// </param>
        /// <param name="vectorSimilarityThreshold">
        /// Optional. Only returns contexts with vector similarity larger than the<br/>
        /// threshold.
        /// </param>
        /// <param name="metadataFilter">
        /// Optional. String for metadata filtering.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Filter(
            double? vectorDistanceThreshold,
            double? vectorSimilarityThreshold,
            string? metadataFilter)
        {
            this.VectorDistanceThreshold = vectorDistanceThreshold;
            this.VectorSimilarityThreshold = vectorSimilarityThreshold;
            this.MetadataFilter = metadataFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        public Filter()
        {
        }

    }
}