
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Batch request to get a text embedding from the model.
    /// </summary>
    public sealed partial class BatchEmbedTextRequest
    {
        /// <summary>
        /// Optional. The free-form input texts that the model will turn into an embedding. The current limit is 100 texts, over which an error will be thrown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// Optional. Embed requests for the batch. Only one of `texts` or `requests` can be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedTextRequest>? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedTextRequest" /> class.
        /// </summary>
        /// <param name="texts">
        /// Optional. The free-form input texts that the model will turn into an embedding. The current limit is 100 texts, over which an error will be thrown.
        /// </param>
        /// <param name="requests">
        /// Optional. Embed requests for the batch. Only one of `texts` or `requests` can be set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchEmbedTextRequest(
            global::System.Collections.Generic.IList<string>? texts,
            global::System.Collections.Generic.IList<global::Google.Gemini.EmbedTextRequest>? requests)
        {
            this.Texts = texts;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedTextRequest" /> class.
        /// </summary>
        public BatchEmbedTextRequest()
        {
        }
    }
}