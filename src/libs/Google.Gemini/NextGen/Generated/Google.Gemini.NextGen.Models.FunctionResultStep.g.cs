
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Result of a function tool call.
    /// </summary>
    public sealed partial class FunctionResultStep
    {
        /// <summary>
        /// Required. The result of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> Result { get; set; }

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
        /// The name of the tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the tool call resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultStep" /> class.
        /// </summary>
        /// <param name="result">
        /// Required. The result of the tool call.
        /// </param>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the tool that was called.
        /// </param>
        /// <param name="isError">
        /// Whether the tool call resulted in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResultStep(
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> result,
            string callId,
            object type,
            string? name,
            bool? isError)
        {
            this.Result = result;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name;
            this.IsError = isError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultStep" /> class.
        /// </summary>
        public FunctionResultStep()
        {
        }

    }
}