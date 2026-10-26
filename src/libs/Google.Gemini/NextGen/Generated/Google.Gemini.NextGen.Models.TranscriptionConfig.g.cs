
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for speech recognition (transcription).
    /// </summary>
    public sealed partial class TranscriptionConfig
    {
        /// <summary>
        /// Optional. BCP-47 language codes providing hints about the languages present in the<br/>
        /// audio. If omitted or empty, defaults to automatic language detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_codes")]
        public global::System.Collections.Generic.IList<string>? LanguageCodes { get; set; }

        /// <summary>
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model<br/>
        /// toward recognizing specific terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary")]
        public global::System.Collections.Generic.IList<string>? CustomVocabulary { get; set; }

        /// <summary>
        /// Discriminated transcription mode options or enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Mode { get; set; }

        /// <summary>
        /// Optional. The granularity of timestamps to include in the transcription output.<br/>
        /// Supported values: "word". If empty, no timestamps are generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? TimestampGranularities { get; set; }

        /// <summary>
        /// Optional. Configures speaker diarization. Supported values: "speaker".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_mode")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DiarizationMode { get; set; }

        /// <summary>
        /// Optional. A list of phrases to bias the ASR model towards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptation_phrases")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AdaptationPhrases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        /// <param name="languageCodes">
        /// Optional. BCP-47 language codes providing hints about the languages present in the<br/>
        /// audio. If omitted or empty, defaults to automatic language detection.
        /// </param>
        /// <param name="customVocabulary">
        /// Optional. A list of custom vocabulary phrases to bias the speech recognition model<br/>
        /// toward recognizing specific terms.
        /// </param>
        /// <param name="mode">
        /// Discriminated transcription mode options or enum.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfig(
            global::System.Collections.Generic.IList<string>? languageCodes,
            global::System.Collections.Generic.IList<string>? customVocabulary,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? mode)
        {
            this.LanguageCodes = languageCodes;
            this.CustomVocabulary = customVocabulary;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        public TranscriptionConfig()
        {
        }

    }
}