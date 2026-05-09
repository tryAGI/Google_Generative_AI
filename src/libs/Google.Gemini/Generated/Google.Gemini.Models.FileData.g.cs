
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// URI based data.
    /// </summary>
    public sealed partial class FileData
    {
        /// <summary>
        /// Required. URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUri")]
        public string? FileUri { get; set; }

        /// <summary>
        /// Optional. The IANA standard MIME type of the source data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="fileUri">
        /// Required. URI.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The IANA standard MIME type of the source data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileData(
            string? fileUri,
            string? mimeType)
        {
            this.FileUri = fileUri;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        public FileData()
        {
        }
    }
}