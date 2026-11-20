
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata describes the input document content. Set this in `Part.document_metadata` or `FunctionResponsePart.document_metadata` when `inline_data` or `file_data` contains a document to configure static document preprocessing.
    /// </summary>
    public sealed partial class DocumentMetadata
    {
        /// <summary>
        /// Optional. 1-indexed inclusive start page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPage")]
        public int? StartPage { get; set; }

        /// <summary>
        /// Optional. 1-indexed inclusive end page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPage")]
        public int? EndPage { get; set; }

        /// <summary>
        /// Optional. Content layers to return. If empty, defaults to [PAGE_IMAGE] when DocumentMetadata is set. When DocumentMetadata is not set, default document processing is used (for example, page images for PDFs).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLayers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.DocumentMetadataContentLayer>? ContentLayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentMetadata" /> class.
        /// </summary>
        /// <param name="startPage">
        /// Optional. 1-indexed inclusive start page.
        /// </param>
        /// <param name="endPage">
        /// Optional. 1-indexed inclusive end page.
        /// </param>
        /// <param name="contentLayers">
        /// Optional. Content layers to return. If empty, defaults to [PAGE_IMAGE] when DocumentMetadata is set. When DocumentMetadata is not set, default document processing is used (for example, page images for PDFs).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentMetadata(
            int? startPage,
            int? endPage,
            global::System.Collections.Generic.IList<global::Google.Gemini.DocumentMetadataContentLayer>? contentLayers)
        {
            this.StartPage = startPage;
            this.EndPage = endPage;
            this.ContentLayers = contentLayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentMetadata" /> class.
        /// </summary>
        public DocumentMetadata()
        {
        }

    }
}