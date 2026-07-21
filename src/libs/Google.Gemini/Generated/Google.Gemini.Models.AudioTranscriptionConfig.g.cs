
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The audio transcription configuration.
    /// </summary>
    public sealed partial class AudioTranscriptionConfig
    {
        /// <summary>
        /// Indicates the language of the audio should be automatically detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageAuto")]
        public global::Google.Gemini.LanguageAuto? LanguageAuto { get; set; }

        /// <summary>
        /// Provides hints to the model about possible languages present in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHints")]
        public global::Google.Gemini.LanguageHints? LanguageHints { get; set; }

        /// <summary>
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model toward recognizing specific terms (product names, proper nouns, jargon).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabulary")]
        public global::System.Collections.Generic.IList<string>? CustomVocabulary { get; set; }

        /// <summary>
        /// Optional. A list of phrases used for speech adaptation, which biases the ASR model to improve recognition of these specific terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptationPhrases")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AdaptationPhrases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionConfig" /> class.
        /// </summary>
        /// <param name="languageAuto">
        /// Indicates the language of the audio should be automatically detected.
        /// </param>
        /// <param name="languageHints">
        /// Provides hints to the model about possible languages present in the audio.
        /// </param>
        /// <param name="customVocabulary">
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model toward recognizing specific terms (product names, proper nouns, jargon).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionConfig(
            global::Google.Gemini.LanguageAuto? languageAuto,
            global::Google.Gemini.LanguageHints? languageHints,
            global::System.Collections.Generic.IList<string>? customVocabulary)
        {
            this.LanguageAuto = languageAuto;
            this.LanguageHints = languageHints;
            this.CustomVocabulary = customVocabulary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionConfig" /> class.
        /// </summary>
        public AudioTranscriptionConfig()
        {
        }

    }
}