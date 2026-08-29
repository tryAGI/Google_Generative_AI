
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
        /// Optional. Configures transcription mode. Supported values: `VERBATIM`, `SMART`. If unspecified, defaults to `VERBATIM` transcription. In `SMART` mode, the model performs disfluency removal (eliminating filler words, repetitions, and false starts), light grammatical cleanup, automatic formatting (paragraphs, bullet points, numbered lists), and minor user edits (inline self-corrections). Timestamps and diarization are incompatible with mode `SMART`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.AudioTranscriptionConfigModeJsonConverter))]
        public global::Google.Gemini.AudioTranscriptionConfigMode? Mode { get; set; }

        /// <summary>
        /// Provides hints to the model about possible languages present in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHints")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.LanguageHints? LanguageHints { get; set; }

        /// <summary>
        /// Optional. Configures word-level timestamp generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordTimestamp")]
        public bool? WordTimestamp { get; set; }

        /// <summary>
        /// Indicates the language of the audio should be automatically detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageAuto")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.LanguageAuto? LanguageAuto { get; set; }

        /// <summary>
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model toward recognizing specific terms (product names, proper nouns, jargon).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabulary")]
        public global::System.Collections.Generic.IList<string>? CustomVocabulary { get; set; }

        /// <summary>
        /// Optional. BCP-47 language codes providing hints about the languages present in the audio. If omitted or empty, defaults to automatic language detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCodes")]
        public global::System.Collections.Generic.IList<string>? LanguageCodes { get; set; }

        /// <summary>
        /// Optional. Configures speaker diarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization")]
        public bool? Diarization { get; set; }

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
        /// <param name="mode">
        /// Optional. Configures transcription mode. Supported values: `VERBATIM`, `SMART`. If unspecified, defaults to `VERBATIM` transcription. In `SMART` mode, the model performs disfluency removal (eliminating filler words, repetitions, and false starts), light grammatical cleanup, automatic formatting (paragraphs, bullet points, numbered lists), and minor user edits (inline self-corrections). Timestamps and diarization are incompatible with mode `SMART`.
        /// </param>
        /// <param name="wordTimestamp">
        /// Optional. Configures word-level timestamp generation.
        /// </param>
        /// <param name="customVocabulary">
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model toward recognizing specific terms (product names, proper nouns, jargon).
        /// </param>
        /// <param name="languageCodes">
        /// Optional. BCP-47 language codes providing hints about the languages present in the audio. If omitted or empty, defaults to automatic language detection.
        /// </param>
        /// <param name="diarization">
        /// Optional. Configures speaker diarization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionConfig(
            global::Google.Gemini.AudioTranscriptionConfigMode? mode,
            bool? wordTimestamp,
            global::System.Collections.Generic.IList<string>? customVocabulary,
            global::System.Collections.Generic.IList<string>? languageCodes,
            bool? diarization)
        {
            this.Mode = mode;
            this.WordTimestamp = wordTimestamp;
            this.CustomVocabulary = customVocabulary;
            this.LanguageCodes = languageCodes;
            this.Diarization = diarization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionConfig" /> class.
        /// </summary>
        public AudioTranscriptionConfig()
        {
        }

    }
}