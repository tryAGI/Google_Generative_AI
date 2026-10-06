
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The tool choice configuration containing allowed tools.<br/>
    /// Example: {"allowed_tools":{"mode":"any","tools":["my_tool"]}}
    /// </summary>
    public sealed partial class ToolChoiceConfig
    {
        /// <summary>
        /// The configuration for allowed tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::Google.Gemini.NextGen.AllowedTools? AllowedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceConfig" /> class.
        /// </summary>
        /// <param name="allowedTools">
        /// The configuration for allowed tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceConfig(
            global::Google.Gemini.NextGen.AllowedTools? allowedTools)
        {
            this.AllowedTools = allowedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceConfig" /> class.
        /// </summary>
        public ToolChoiceConfig()
        {
        }

    }
}