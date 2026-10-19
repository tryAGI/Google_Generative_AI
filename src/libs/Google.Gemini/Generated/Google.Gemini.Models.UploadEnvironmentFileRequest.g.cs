
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request for `UploadEnvironmentFile`.
    /// </summary>
    public sealed partial class UploadEnvironmentFileRequest
    {
        /// <summary>
        /// Optional. If true, treats the uploaded file as a tar/tar.gz archive and unpacks it into `path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract")]
        public bool? Extract { get; set; }

        /// <summary>
        /// Optional. Whether to overwrite the destination file if it already exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadEnvironmentFileRequest" /> class.
        /// </summary>
        /// <param name="extract">
        /// Optional. If true, treats the uploaded file as a tar/tar.gz archive and unpacks it into `path`.
        /// </param>
        /// <param name="overwrite">
        /// Optional. Whether to overwrite the destination file if it already exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadEnvironmentFileRequest(
            bool? extract,
            bool? overwrite)
        {
            this.Extract = extract;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadEnvironmentFileRequest" /> class.
        /// </summary>
        public UploadEnvironmentFileRequest()
        {
        }

    }
}