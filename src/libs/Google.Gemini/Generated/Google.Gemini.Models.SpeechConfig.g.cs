
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Config for speech generation and transcription.
    /// </summary>
    public sealed partial class SpeechConfig
    {
        /// <summary>
        /// Optional. Controls text normalization before speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textNormalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SpeechConfigTextNormalizationJsonConverter))]
        public global::Google.Gemini.SpeechConfigTextNormalization? TextNormalization { get; set; }

        /// <summary>
        /// Optional. The IETF [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language code that the user configured the app to use. Used for speech recognition and synthesis. Valid values are: `de-DE`, `en-AU`, `en-GB`, `en-IN`, `en-US`, `es-US`, `fr-FR`, `hi-IN`, `pt-BR`, `ar-XA`, `es-ES`, `fr-CA`, `id-ID`, `it-IT`, `ja-JP`, `tr-TR`, `vi-VN`, `bn-IN`, `gu-IN`, `kn-IN`, `ml-IN`, `mr-IN`, `ta-IN`, `te-IN`, `nl-NL`, `ko-KR`, `cmn-CN`, `pl-PL`, `ru-RU`, and `th-TH`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// The configuration for the multi-speaker setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiSpeakerVoiceConfig")]
        public global::Google.Gemini.MultiSpeakerVoiceConfig? MultiSpeakerVoiceConfig { get; set; }

        /// <summary>
        /// The configuration for the voice to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceConfig")]
        public global::Google.Gemini.VoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig" /> class.
        /// </summary>
        /// <param name="textNormalization">
        /// Optional. Controls text normalization before speech synthesis.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The IETF [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language code that the user configured the app to use. Used for speech recognition and synthesis. Valid values are: `de-DE`, `en-AU`, `en-GB`, `en-IN`, `en-US`, `es-US`, `fr-FR`, `hi-IN`, `pt-BR`, `ar-XA`, `es-ES`, `fr-CA`, `id-ID`, `it-IT`, `ja-JP`, `tr-TR`, `vi-VN`, `bn-IN`, `gu-IN`, `kn-IN`, `ml-IN`, `mr-IN`, `ta-IN`, `te-IN`, `nl-NL`, `ko-KR`, `cmn-CN`, `pl-PL`, `ru-RU`, and `th-TH`.
        /// </param>
        /// <param name="multiSpeakerVoiceConfig">
        /// The configuration for the multi-speaker setup.
        /// </param>
        /// <param name="voiceConfig">
        /// The configuration for the voice to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechConfig(
            global::Google.Gemini.SpeechConfigTextNormalization? textNormalization,
            string? languageCode,
            global::Google.Gemini.MultiSpeakerVoiceConfig? multiSpeakerVoiceConfig,
            global::Google.Gemini.VoiceConfig? voiceConfig)
        {
            this.TextNormalization = textNormalization;
            this.LanguageCode = languageCode;
            this.MultiSpeakerVoiceConfig = multiSpeakerVoiceConfig;
            this.VoiceConfig = voiceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig" /> class.
        /// </summary>
        public SpeechConfig()
        {
        }

    }
}