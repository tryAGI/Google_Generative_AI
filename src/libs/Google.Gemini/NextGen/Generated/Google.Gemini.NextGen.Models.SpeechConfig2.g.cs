
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The configuration for speech interaction.
    /// </summary>
    public sealed partial class SpeechConfig2
    {
        /// <summary>
        /// The language of the speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The speaker's name, it should match the speaker name given in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// The voice of the speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig2" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the speech.
        /// </param>
        /// <param name="speaker">
        /// The speaker's name, it should match the speaker name given in the prompt.
        /// </param>
        /// <param name="voice">
        /// The voice of the speaker.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechConfig2(
            string? language,
            string? speaker,
            string? voice)
        {
            this.Language = language;
            this.Speaker = speaker;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig2" /> class.
        /// </summary>
        public SpeechConfig2()
        {
        }

    }
}