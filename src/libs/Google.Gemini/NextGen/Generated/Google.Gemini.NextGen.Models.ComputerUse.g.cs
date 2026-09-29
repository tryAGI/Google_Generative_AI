
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model to interact with the computer.
    /// </summary>
    public sealed partial class ComputerUse
    {
        /// <summary>
        /// Optional. Disabled safety policies for computer use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_safety_policies")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? DisabledSafetyPolicies { get; set; }

        /// <summary>
        /// Whether enable the prompt injection detection check on computer-use<br/>
        /// request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_prompt_injection_detection")]
        public bool? EnablePromptInjectionDetection { get; set; }

        /// <summary>
        /// The environment being operated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ComputerUseEnvironmentJsonConverter))]
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Environment { get; set; }

        /// <summary>
        /// The list of predefined functions that are excluded from the model call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_predefined_functions")]
        public global::System.Collections.Generic.IList<string>? ExcludedPredefinedFunctions { get; set; }

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
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="disabledSafetyPolicies">
        /// Optional. Disabled safety policies for computer use.
        /// </param>
        /// <param name="enablePromptInjectionDetection">
        /// Whether enable the prompt injection detection check on computer-use<br/>
        /// request.
        /// </param>
        /// <param name="environment">
        /// The environment being operated.
        /// </param>
        /// <param name="excludedPredefinedFunctions">
        /// The list of predefined functions that are excluded from the model call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUse(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? disabledSafetyPolicies,
            bool? enablePromptInjectionDetection,
            global::Google.Gemini.NextGen.ComputerUseEnvironment? environment,
            global::System.Collections.Generic.IList<string>? excludedPredefinedFunctions)
        {
            this.DisabledSafetyPolicies = disabledSafetyPolicies;
            this.EnablePromptInjectionDetection = enablePromptInjectionDetection;
            this.Environment = environment;
            this.ExcludedPredefinedFunctions = excludedPredefinedFunctions;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        public ComputerUse()
        {
        }

    }
}