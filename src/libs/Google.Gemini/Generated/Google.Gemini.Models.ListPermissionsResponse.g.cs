
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response from `ListPermissions` containing a paginated list of permissions.
    /// </summary>
    public sealed partial class ListPermissionsResponse
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Returned permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPermissionsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
        /// <param name="permissions">
        /// Returned permissions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPermissionsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? permissions)
        {
            this.NextPageToken = nextPageToken;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPermissionsResponse" /> class.
        /// </summary>
        public ListPermissionsResponse()
        {
        }
    }
}