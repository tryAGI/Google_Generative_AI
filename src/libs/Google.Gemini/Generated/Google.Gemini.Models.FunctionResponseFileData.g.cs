
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// URI based data for function response.
    /// </summary>
    public sealed partial class FunctionResponseFileData
    {
        /// <summary>
        /// The IANA standard MIME type of the source data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Required. URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUri")]
        public string? FileUri { get; set; }

        /// <summary>
        /// Optional. Display name of the file. Used to provide a label or filename to distinguish file data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseFileData" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The IANA standard MIME type of the source data.
        /// </param>
        /// <param name="fileUri">
        /// Required. URI.
        /// </param>
        /// <param name="displayName">
        /// Optional. Display name of the file. Used to provide a label or filename to distinguish file data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponseFileData(
            string? mimeType,
            string? fileUri,
            string? displayName)
        {
            this.MimeType = mimeType;
            this.FileUri = fileUri;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseFileData" /> class.
        /// </summary>
        public FunctionResponseFileData()
        {
        }

    }
}