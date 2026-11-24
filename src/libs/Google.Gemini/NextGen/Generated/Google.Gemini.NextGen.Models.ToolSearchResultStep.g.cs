
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Tool search result step.
    /// </summary>
    public sealed partial class ToolSearchResultStep
    {
        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The retrieved function definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Function>? Result { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResultStep" /> class.
        /// </summary>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="type"></param>
        /// <param name="result">
        /// The retrieved function definitions.
        /// </param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchResultStep(
            string callId,
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Function>? result,
            byte[]? signature)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Result = result;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResultStep" /> class.
        /// </summary>
        public ToolSearchResultStep()
        {
        }

    }
}