
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Chunk from context retrieved by the file search tool.
    /// </summary>
    public sealed partial class RetrievedContext
    {
        /// <summary>
        /// Optional. User-provided metadata about the retrieved context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customMetadata")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Optional. Title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. Text of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional. Name of the `FileSearchStore` containing the document. Example: `fileSearchStores/123`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSearchStore")]
        public string? FileSearchStore { get; set; }

        /// <summary>
        /// Optional. URI reference of the semantic retrieval document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedContext" /> class.
        /// </summary>
        /// <param name="customMetadata">
        /// Optional. User-provided metadata about the retrieved context.
        /// </param>
        /// <param name="title">
        /// Optional. Title of the document.
        /// </param>
        /// <param name="text">
        /// Optional. Text of the chunk.
        /// </param>
        /// <param name="fileSearchStore">
        /// Optional. Name of the `FileSearchStore` containing the document. Example: `fileSearchStores/123`
        /// </param>
        /// <param name="uri">
        /// Optional. URI reference of the semantic retrieval document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievedContext(
            global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? customMetadata,
            string? title,
            string? text,
            string? fileSearchStore,
            string? uri)
        {
            this.CustomMetadata = customMetadata;
            this.Title = title;
            this.Text = text;
            this.FileSearchStore = fileSearchStore;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedContext" /> class.
        /// </summary>
        public RetrievedContext()
        {
        }
    }
}