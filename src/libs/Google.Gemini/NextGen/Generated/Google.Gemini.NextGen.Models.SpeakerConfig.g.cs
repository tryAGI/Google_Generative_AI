
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for multi-speaker and speech generation.
    /// </summary>
    public sealed partial class SpeakerConfig
    {
        /// <summary>
        /// Individual speaker configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>? Speakers { get; set; }

        /// <summary>
        /// Controls text normalization before speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_normalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.SpeakerConfigTextNormalizationJsonConverter))]
        public global::Google.Gemini.NextGen.SpeakerConfigTextNormalization? TextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerConfig" /> class.
        /// </summary>
        /// <param name="speakers">
        /// Individual speaker configurations.
        /// </param>
        /// <param name="textNormalization">
        /// Controls text normalization before speech synthesis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerConfig(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>? speakers,
            global::Google.Gemini.NextGen.SpeakerConfigTextNormalization? textNormalization)
        {
            this.Speakers = speakers;
            this.TextNormalization = textNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerConfig" /> class.
        /// </summary>
        public SpeakerConfig()
        {
        }

    }
}