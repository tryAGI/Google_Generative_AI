
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Google Search result step.<br/>
    /// Example: {"type":"google_search_result","call_id":"search_call_19201","result":[{"search_suggestions":"\u003Cdiv class=\u0022container\u0022\u003E...\u003C/div\u003E"}]}
    /// </summary>
    public sealed partial class GoogleSearchResultStep
    {
        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Whether the Google Search resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Required. The results of the Google Search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2> Result { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearchResultStep" /> class.
        /// </summary>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="result">
        /// Required. The results of the Google Search.
        /// </param>
        /// <param name="type"></param>
        /// <param name="isError">
        /// Whether the Google Search resulted in an error.
        /// </param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleSearchResultStep(
            string callId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2> result,
            object type,
            bool? isError,
            byte[]? signature)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.IsError = isError;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearchResultStep" /> class.
        /// </summary>
        public GoogleSearchResultStep()
        {
        }

    }
}