
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response for `UploadEnvironmentFile`.
    /// </summary>
    public sealed partial class UploadEnvironmentFileResponse
    {
        /// <summary>
        /// List of files created or extracted in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadEnvironmentFileResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// List of files created or extracted in the environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadEnvironmentFileResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadEnvironmentFileResponse" /> class.
        /// </summary>
        public UploadEnvironmentFileResponse()
        {
        }

    }
}