
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for specifying function calling behavior.
    /// </summary>
    public sealed partial class FunctionCallingConfig
    {
        /// <summary>
        /// Optional. A set of function names that, when provided, limits the functions the model will call. This should only be set when the Mode is ANY or VALIDATED. Function names should match [FunctionDeclaration.name]. When set, model will predict a function call from only allowed function names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedFunctionNames")]
        public global::System.Collections.Generic.IList<string>? AllowedFunctionNames { get; set; }

        /// <summary>
        /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FunctionCallingConfigModeJsonConverter))]
        public global::Google.Gemini.FunctionCallingConfigMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallingConfig" /> class.
        /// </summary>
        /// <param name="allowedFunctionNames">
        /// Optional. A set of function names that, when provided, limits the functions the model will call. This should only be set when the Mode is ANY or VALIDATED. Function names should match [FunctionDeclaration.name]. When set, model will predict a function call from only allowed function names.
        /// </param>
        /// <param name="mode">
        /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallingConfig(
            global::System.Collections.Generic.IList<string>? allowedFunctionNames,
            global::Google.Gemini.FunctionCallingConfigMode? mode)
        {
            this.AllowedFunctionNames = allowedFunctionNames;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallingConfig" /> class.
        /// </summary>
        public FunctionCallingConfig()
        {
        }
    }
}