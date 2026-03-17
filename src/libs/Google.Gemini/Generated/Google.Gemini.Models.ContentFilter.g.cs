
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Content filtering metadata associated with processing a single request. ContentFilter contains a reason and an optional supporting string. The reason may be unspecified.
    /// </summary>
    public sealed partial class ContentFilter
    {
        /// <summary>
        /// The reason content was blocked during request processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ContentFilterReasonJsonConverter))]
        public global::Google.Gemini.ContentFilterReason? Reason { get; set; }

        /// <summary>
        /// A string that describes the filtering behavior in more detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilter" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason content was blocked during request processing.
        /// </param>
        /// <param name="message">
        /// A string that describes the filtering behavior in more detail.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilter(
            global::Google.Gemini.ContentFilterReason? reason,
            string? message)
        {
            this.Reason = reason;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilter" /> class.
        /// </summary>
        public ContentFilter()
        {
        }
    }
}