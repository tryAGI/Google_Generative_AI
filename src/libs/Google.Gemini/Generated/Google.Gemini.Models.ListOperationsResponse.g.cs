
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
        /// Unordered list. Unreachable resources. Populated when the request sets `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to list all resources across all supported locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unreachable")]
        public global::System.Collections.Generic.IList<string>? Unreachable { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOperationsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// The standard List next-page token.
        /// </param>
        /// <param name="unreachable">
        /// Unordered list. Unreachable resources. Populated when the request sets `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to list all resources across all supported locations.
        /// </param>
        /// <param name="operations">
        /// A list of operations that matches the specified filter in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOperationsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<string>? unreachable,
            global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? operations)
        {
            this.NextPageToken = nextPageToken;
            this.Unreachable = unreachable;
            this.Operations = operations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOperationsResponse" /> class.
        /// </summary>
        public ListOperationsResponse()
        {
        }
    }
}