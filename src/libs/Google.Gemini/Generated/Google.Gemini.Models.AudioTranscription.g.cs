
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The transcription of an audio part. For multi-speaker audio, each speaker segment is a separate Part with its own AudioTranscription carrying the speaker_label.
    /// </summary>
    public sealed partial class AudioTranscription
    {
        /// <summary>
        /// Optional. Detailed word-level transcriptions and timing details. Present when word_timestamp is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? Words { get; set; }

        /// <summary>
        /// Required. The transcription text of this audio segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional. A label identifying the speaker of this audio segment (e.g. "spk_1", "spk_2"). Present when diarization is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakerLabel")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscription" /> class.
        /// </summary>
        /// <param name="words">
        /// Optional. Detailed word-level transcriptions and timing details. Present when word_timestamp is set.
        /// </param>
        /// <param name="text">
        /// Required. The transcription text of this audio segment.
        /// </param>
        /// <param name="speakerLabel">
        /// Optional. A label identifying the speaker of this audio segment (e.g. "spk_1", "spk_2"). Present when diarization is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscription(
            global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? words,
            string? text,
            string? speakerLabel)
        {
            this.Words = words;
            this.Text = text;
            this.SpeakerLabel = speakerLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscription" /> class.
        /// </summary>
        public AudioTranscription()
        {
        }

    }
}