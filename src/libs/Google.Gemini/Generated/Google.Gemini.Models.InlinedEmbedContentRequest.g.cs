
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The request to be processed in the batch.
    /// </summary>
    public sealed partial class InlinedEmbedContentRequest
    {
        /// <summary>
        /// Optional. The metadata to be associated with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Request containing the `Content` for the model to embed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Google.Gemini.EmbedContentRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Optional. The metadata to be associated with the request.
        /// </param>
        /// <param name="request">
        /// Request containing the `Content` for the model to embed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlinedEmbedContentRequest(
            object? metadata,
            global::Google.Gemini.EmbedContentRequest? request)
        {
            this.Metadata = metadata;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequest" /> class.
        /// </summary>
        public InlinedEmbedContentRequest()
        {
        }
    }
}