
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata on the usage of the embedding request.
    /// </summary>
    public sealed partial class EmbeddingUsageMetadata
    {
        /// <summary>
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokenDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? PromptTokenDetails { get; set; }

        /// <summary>
        /// Output only. Number of tokens in the prompt.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokenCount")]
        public int? PromptTokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsageMetadata" /> class.
        /// </summary>
        /// <param name="promptTokenDetails">
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="promptTokenCount">
        /// Output only. Number of tokens in the prompt.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingUsageMetadata(
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? promptTokenDetails,
            int? promptTokenCount)
        {
            this.PromptTokenDetails = promptTokenDetails;
            this.PromptTokenCount = promptTokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsageMetadata" /> class.
        /// </summary>
        public EmbeddingUsageMetadata()
        {
        }
    }
}