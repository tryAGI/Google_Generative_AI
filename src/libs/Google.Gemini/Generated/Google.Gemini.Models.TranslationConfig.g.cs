
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Config for translation features.
    /// </summary>
    public sealed partial class TranslationConfig
    {
        /// <summary>
        /// Required. The target language for translation. Supported values are BCP-47 language codes (e.g. "en", "es", "fr").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLanguageCode")]
        public string? TargetLanguageCode { get; set; }

        /// <summary>
        /// Optional. If true, the model will generate audio when the target language is spoken, essentially it will parrot the input. If false, we will not produce audio for the target language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echoTargetLanguage")]
        public bool? EchoTargetLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfig" /> class.
        /// </summary>
        /// <param name="targetLanguageCode">
        /// Required. The target language for translation. Supported values are BCP-47 language codes (e.g. "en", "es", "fr").
        /// </param>
        /// <param name="echoTargetLanguage">
        /// Optional. If true, the model will generate audio when the target language is spoken, essentially it will parrot the input. If false, we will not produce audio for the target language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationConfig(
            string? targetLanguageCode,
            bool? echoTargetLanguage)
        {
            this.TargetLanguageCode = targetLanguageCode;
            this.EchoTargetLanguage = echoTargetLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfig" /> class.
        /// </summary>
        public TranslationConfig()
        {
        }

    }
}