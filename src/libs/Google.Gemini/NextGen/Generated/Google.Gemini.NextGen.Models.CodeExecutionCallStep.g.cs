
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Code execution call step.
    /// </summary>
    public sealed partial class CodeExecutionCallStep
    {
        /// <summary>
        /// The arguments to pass to the code execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.CodeExecutionCallArguments2 CodeExecutionCallArguments { get; set; }

        /// <summary>
        /// Required. A unique ID for this specific tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Initializes a new instance of the <see cref="CodeExecutionCallStep" /> class.
        /// </summary>
        /// <param name="codeExecutionCallArguments">
        /// The arguments to pass to the code execution.
        /// </param>
        /// <param name="id">
        /// Required. A unique ID for this specific tool call.
        /// </param>
        /// <param name="type"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeExecutionCallStep(
            global::Google.Gemini.NextGen.CodeExecutionCallArguments2 codeExecutionCallArguments,
            string id,
            object type,
            byte[]? signature)
        {
            this.CodeExecutionCallArguments = codeExecutionCallArguments ?? throw new global::System.ArgumentNullException(nameof(codeExecutionCallArguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionCallStep" /> class.
        /// </summary>
        public CodeExecutionCallStep()
        {
        }

    }
}