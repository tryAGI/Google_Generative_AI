
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A document content block.<br/>
    /// Example: {"type":"document","data":"BASE64_ENCODED_DOCUMENT","mime_type":"application/pdf"}
    /// </summary>
    public sealed partial class DocumentContent
    {
        /// <summary>
        /// The document content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// The mime type of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.DocumentContentMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.DocumentContentMimeType? MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The URI of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data">
        /// The document content.
        /// </param>
        /// <param name="mimeType">
        /// The mime type of the document.
        /// </param>
        /// <param name="uri">
        /// The URI of the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentContent(
            object type,
            byte[]? data,
            global::Google.Gemini.NextGen.DocumentContentMimeType? mimeType,
            string? uri)
        {
            this.Data = data;
            this.MimeType = mimeType;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContent" /> class.
        /// </summary>
        public DocumentContent()
        {
        }

    }
}