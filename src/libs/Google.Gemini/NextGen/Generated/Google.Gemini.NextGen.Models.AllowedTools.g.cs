
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The configuration for allowed tools.
    /// </summary>
    public sealed partial class AllowedTools
    {
        /// <summary>
        /// The mode of the tool choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AllowedToolsModeJsonConverter))]
        public global::Google.Gemini.NextGen.AllowedToolsMode? Mode { get; set; }

        /// <summary>
        /// The names of the allowed tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedTools" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode of the tool choice.
        /// </param>
        /// <param name="tools">
        /// The names of the allowed tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowedTools(
            global::Google.Gemini.NextGen.AllowedToolsMode? mode,
            global::System.Collections.Generic.IList<string>? tools)
        {
            this.Mode = mode;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedTools" /> class.
        /// </summary>
        public AllowedTools()
        {
        }

    }
}