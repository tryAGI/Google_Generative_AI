
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// URL context result step.
    /// </summary>
    public sealed partial class URLContextResultStep
    {
        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Whether the URL context resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Required. The results of the URL context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult> Result { get; set; }

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
        /// Initializes a new instance of the <see cref="URLContextResultStep" /> class.
        /// </summary>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="result">
        /// Required. The results of the URL context.
        /// </param>
        /// <param name="type"></param>
        /// <param name="isError">
        /// Whether the URL context resulted in an error.
        /// </param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public URLContextResultStep(
            string callId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult> result,
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
        /// Initializes a new instance of the <see cref="URLContextResultStep" /> class.
        /// </summary>
        public URLContextResultStep()
        {
        }

    }
}