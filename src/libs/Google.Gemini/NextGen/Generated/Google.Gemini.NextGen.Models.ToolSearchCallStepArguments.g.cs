
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolSearchCallStepArguments
    {
        /// <summary>
        /// List of function names to load explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_names")]
        public global::System.Collections.Generic.IList<string>? FunctionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallStepArguments" /> class.
        /// </summary>
        /// <param name="functionNames">
        /// List of function names to load explicitly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchCallStepArguments(
            global::System.Collections.Generic.IList<string>? functionNames)
        {
            this.FunctionNames = functionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallStepArguments" /> class.
        /// </summary>
        public ToolSearchCallStepArguments()
        {
        }

    }
}