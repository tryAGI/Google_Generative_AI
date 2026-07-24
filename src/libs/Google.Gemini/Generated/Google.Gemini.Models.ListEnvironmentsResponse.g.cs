
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response for `ListEnvironments`.
    /// </summary>
    public sealed partial class ListEnvironmentsResponse
    {
        /// <summary>
        /// Pagination token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Environments belonging to the provided project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentConfig>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// Pagination token.
        /// </param>
        /// <param name="environments">
        /// Environments belonging to the provided project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEnvironmentsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentConfig>? environments)
        {
            this.NextPageToken = nextPageToken;
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponse" /> class.
        /// </summary>
        public ListEnvironmentsResponse()
        {
        }

    }
}