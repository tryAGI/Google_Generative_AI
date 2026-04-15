
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Chunk from context retrieved by the file search tool.
    /// </summary>
    public sealed partial class RetrievedContext
    {
        /// <summary>
        /// Optional. Text of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional. Page number of the retrieved context, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Optional. Title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. User-provided metadata about the retrieved context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customMetadata")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Optional. URI reference of the semantic retrieval document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Optional. Name of the `FileSearchStore` containing the document. Example: `fileSearchStores/123`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSearchStore")]
        public string? FileSearchStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedContext" /> class.
        /// </summary>
        /// <param name="text">
        /// Optional. Text of the chunk.
        /// </param>
        /// <param name="pageNumber">
        /// Optional. Page number of the retrieved context, if applicable.
        /// </param>
        /// <param name="title">
        /// Optional. Title of the document.
        /// </param>
        /// <param name="customMetadata">
        /// Optional. User-provided metadata about the retrieved context.
        /// </param>
        /// <param name="uri">
        /// Optional. URI reference of the semantic retrieval document.
        /// </param>
        /// <param name="fileSearchStore">
        /// Optional. Name of the `FileSearchStore` containing the document. Example: `fileSearchStores/123`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievedContext(
            string? text,
            int? pageNumber,
            string? title,
            global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? customMetadata,
            string? uri,
            string? fileSearchStore)
        {
            this.Text = text;
            this.PageNumber = pageNumber;
            this.Title = title;
            this.CustomMetadata = customMetadata;
            this.Uri = uri;
            this.FileSearchStore = fileSearchStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedContext" /> class.
        /// </summary>
        public RetrievedContext()
        {
        }
    }
}