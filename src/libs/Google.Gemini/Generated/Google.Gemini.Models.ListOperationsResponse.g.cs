
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The response message for Operations.ListOperations.
    /// </summary>
    public sealed partial class ListOperationsResponse
    {
        /// <summary>
        /// The standard List next-page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// A list of operations that matches the specified filter in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}