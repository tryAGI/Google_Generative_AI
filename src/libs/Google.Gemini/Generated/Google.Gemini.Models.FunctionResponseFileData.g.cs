
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// URI based data for function response.
    /// </summary>
    public sealed partial class FunctionResponseFileData
    {
        /// <summary>
        /// Optional. Display name of the file. Used to provide a label or filename to distinguish file data, and to reference the file from `FunctionResponse.response` (for example, via `{"$ref": "DISPLAY_NAME"}`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Required. URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUri")]
        public string? FileUri { get; set; }

        /// <summary>
        /// The IANA standard MIME type of the source data. If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Multimodal function responses](https://aistudio.google.com/docs/function-calling#multimodal) and [Supported file formats](https://aistudio.google.com/docs/file-input-methods#supported-content-types).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseFileData" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Optional. Display name of the file. Used to provide a label or filename to distinguish file data, and to reference the file from `FunctionResponse.response` (for example, via `{"$ref": "DISPLAY_NAME"}`).
        /// </param>
        /// <param name="fileUri">
        /// Required. URI.
        /// </param>
        /// <param name="mimeType">
        /// The IANA standard MIME type of the source data. If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Multimodal function responses](https://aistudio.google.com/docs/function-calling#multimodal) and [Supported file formats](https://aistudio.google.com/docs/file-input-methods#supported-content-types).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponseFileData(
            string? displayName,
            string? fileUri,
            string? mimeType)
        {
            this.DisplayName = displayName;
            this.FileUri = fileUri;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseFileData" /> class.
        /// </summary>
        public FunctionResponseFileData()
        {
        }

    }
}