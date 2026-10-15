
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// URI based data.
    /// </summary>
    public sealed partial class FileData
    {
        /// <summary>
        /// Optional. The IANA standard MIME type of the source data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Optional. Specifies the name used to refer to this file to the model (e.g. "my_file.pdf"). Used as the file reference identifier when `verbalization_mode` is set to `REFERENCE_ONLY`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Required. URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUri")]
        public string? FileUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// Optional. The IANA standard MIME type of the source data.
        /// </param>
        /// <param name="displayName">
        /// Optional. Specifies the name used to refer to this file to the model (e.g. "my_file.pdf"). Used as the file reference identifier when `verbalization_mode` is set to `REFERENCE_ONLY`.
        /// </param>
        /// <param name="fileUri">
        /// Required. URI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileData(
            string? mimeType,
            string? displayName,
            string? fileUri)
        {
            this.MimeType = mimeType;
            this.DisplayName = displayName;
            this.FileUri = fileUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        public FileData()
        {
        }

    }
}