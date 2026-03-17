
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The response to a EmbedTextRequest.
    /// </summary>
    public sealed partial class BatchEmbedTextResponse
    {
        /// <summary>
        /// Output only. The embeddings generated from the input text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Embedding>? Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedTextResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// Output only. The embeddings generated from the input text.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchEmbedTextResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.Embedding>? embeddings)
        {
            this.Embeddings = embeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedTextResponse" /> class.
        /// </summary>
        public BatchEmbedTextResponse()
        {
        }
    }
}