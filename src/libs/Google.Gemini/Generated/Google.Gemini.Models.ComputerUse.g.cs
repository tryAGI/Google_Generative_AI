
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Computer Use tool type.
    /// </summary>
    public sealed partial class ComputerUse
    {
        /// <summary>
        /// Optional. By default, predefined functions are included in the final model call. Some of them can be explicitly excluded from being automatically included. This can serve two purposes: 1. Using a more restricted / different action space. 2. Improving the definitions / instructions of predefined functions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedPredefinedFunctions")]
        public global::System.Collections.Generic.IList<string>? ExcludedPredefinedFunctions { get; set; }

        /// <summary>
        /// Required. The environment being operated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ComputerUseEnvironmentJsonConverter))]
        public global::Google.Gemini.ComputerUseEnvironment? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        /// <param name="excludedPredefinedFunctions">
        /// Optional. By default, predefined functions are included in the final model call. Some of them can be explicitly excluded from being automatically included. This can serve two purposes: 1. Using a more restricted / different action space. 2. Improving the definitions / instructions of predefined functions.
        /// </param>
        /// <param name="environment">
        /// Required. The environment being operated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUse(
            global::System.Collections.Generic.IList<string>? excludedPredefinedFunctions,
            global::Google.Gemini.ComputerUseEnvironment? environment)
        {
            this.ExcludedPredefinedFunctions = excludedPredefinedFunctions;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        public ComputerUse()
        {
        }
    }
}