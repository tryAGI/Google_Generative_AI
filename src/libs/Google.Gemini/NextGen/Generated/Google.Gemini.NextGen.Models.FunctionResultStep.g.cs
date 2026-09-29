
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Result of a function tool call.
    /// </summary>
    public sealed partial class FunctionResultStep
    {
        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Whether the tool call resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// The name of the tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Required. The result of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string> Result { get; set; }

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
        /// Initializes a new instance of the <see cref="FunctionResultStep" /> class.
        /// </summary>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="result">
        /// Required. The result of the tool call.
        /// </param>
        /// <param name="type"></param>
        /// <param name="isError">
        /// Whether the tool call resulted in an error.
        /// </param>
        /// <param name="name">
        /// The name of the tool that was called.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResultStep(
            string callId,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string> result,
            object type,
            bool? isError,
            string? name)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.IsError = isError;
            this.Name = name;
            this.Result = result;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultStep" /> class.
        /// </summary>
        public FunctionResultStep()
        {
        }

    }
}