
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Result of executing the `ExecutableCode`. Generated only when the `CodeExecution` tool is used.
    /// </summary>
    public sealed partial class CodeExecutionResult
    {
        /// <summary>
        /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Required. Outcome of the code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CodeExecutionResultOutcomeJsonConverter))]
        public global::Google.Gemini.CodeExecutionResultOutcome? Outcome { get; set; }

        /// <summary>
        /// Optional. The identifier of the `ExecutableCode` part this result is for. Only populated if the corresponding `ExecutableCode` has an id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        /// <param name="output">
        /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
        /// </param>
        /// <param name="outcome">
        /// Required. Outcome of the code execution.
        /// </param>
        /// <param name="id">
        /// Optional. The identifier of the `ExecutableCode` part this result is for. Only populated if the corresponding `ExecutableCode` has an id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeExecutionResult(
            string? output,
            global::Google.Gemini.CodeExecutionResultOutcome? outcome,
            string? id)
        {
            this.Output = output;
            this.Outcome = outcome;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        public CodeExecutionResult()
        {
        }
    }
}