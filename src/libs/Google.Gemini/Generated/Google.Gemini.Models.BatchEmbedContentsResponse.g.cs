
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The response to a `BatchEmbedContentsRequest`.
    /// </summary>
    public sealed partial class BatchEmbedContentsResponse
    {
        /// <summary>
        /// Output only. The embeddings for each request, in the same order as provided in the batch request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}