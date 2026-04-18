
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response from `ListDocuments` containing a paginated list of `Document`s. The `Document`s are sorted by ascending `document.create_time`.
    /// </summary>
    public sealed partial class ListDocumentsResponse
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The returned `Document`s.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
        /// <param name="documents">
        /// The returned `Document`s.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDocumentsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.Document>? documents)
        {
            this.NextPageToken = nextPageToken;
            this.Documents = documents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        public ListDocumentsResponse()
        {
        }
    }
}