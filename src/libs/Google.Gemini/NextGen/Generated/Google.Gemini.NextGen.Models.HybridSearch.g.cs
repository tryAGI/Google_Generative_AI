
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Config for Hybrid Search.
    /// </summary>
    public sealed partial class HybridSearch
    {
        /// <summary>
        /// Optional. Alpha value controls the weight between dense and sparse vector search<br/>
        /// results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha")]
        public float? Alpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridSearch" /> class.
        /// </summary>
        /// <param name="alpha">
        /// Optional. Alpha value controls the weight between dense and sparse vector search<br/>
        /// results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HybridSearch(
            float? alpha)
        {
            this.Alpha = alpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridSearch" /> class.
        /// </summary>
        public HybridSearch()
        {
        }

    }
}