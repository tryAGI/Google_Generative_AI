
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The arguments to pass to the code execution.
    /// </summary>
    public sealed partial class CodeExecutionCallArguments2
    {
        /// <summary>
        /// The code to be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Programming language of the `code`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.CodeExecutionCallArgumentsLanguage2JsonConverter))]
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage2? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionCallArguments2" /> class.
        /// </summary>
        /// <param name="code">
        /// The code to be executed.
        /// </param>
        /// <param name="language">
        /// Programming language of the `code`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeExecutionCallArguments2(
            string? code,
            global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage2? language)
        {
            this.Code = code;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionCallArguments2" /> class.
        /// </summary>
        public CodeExecutionCallArguments2()
        {
        }

    }
}