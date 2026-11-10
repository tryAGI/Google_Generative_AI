
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response for `GetEnvironmentFiles`.
    /// </summary>
    public sealed partial class GetEnvironmentFilesResponse
    {
        /// <summary>
        /// Pagination token for directory listing. NOLINT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// If the requested path is a directory, this contains its contents. If the requested path is a file, this contains a single entry with the file's metadata. If alt=media was specified, this is empty (content is served via `blob`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentFilesResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// Pagination token for directory listing. NOLINT
        /// </param>
        /// <param name="files">
        /// If the requested path is a directory, this contains its contents. If the requested path is a file, this contains a single entry with the file's metadata. If alt=media was specified, this is empty (content is served via `blob`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEnvironmentFilesResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? files)
        {
            this.NextPageToken = nextPageToken;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentFilesResponse" /> class.
        /// </summary>
        public GetEnvironmentFilesResponse()
        {
        }

    }
}