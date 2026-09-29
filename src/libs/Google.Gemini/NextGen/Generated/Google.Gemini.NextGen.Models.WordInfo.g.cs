
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Word-level ASR annotation for transcription output.<br/>
    /// Carries the word text, optional timing, and optional speaker attribution.
    /// </summary>
    public sealed partial class WordInfo
    {
        /// <summary>
        /// End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// End offset in time of the word relative to the start of the audio.<br/>
        /// Present when timestamp_granularities contains "word".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Optional. Speaker label for this word (e.g. "spk_1", "spk_2").<br/>
        /// Present when diarization_mode is set in TranscriptionConfig.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Start offset in time of the word relative to the start of the audio.<br/>
        /// Present when timestamp_granularities contains "word".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// The transcribed word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordInfo" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endIndex">
        /// End of the attributed segment, exclusive.
        /// </param>
        /// <param name="endOffset">
        /// End offset in time of the word relative to the start of the audio.<br/>
        /// Present when timestamp_granularities contains "word".
        /// </param>
        /// <param name="speaker">
        /// Optional. Speaker label for this word (e.g. "spk_1", "spk_2").<br/>
        /// Present when diarization_mode is set in TranscriptionConfig.
        /// </param>
        /// <param name="startIndex">
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="startOffset">
        /// Start offset in time of the word relative to the start of the audio.<br/>
        /// Present when timestamp_granularities contains "word".
        /// </param>
        /// <param name="text">
        /// The transcribed word.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordInfo(
            object type,
            int? endIndex,
            string? endOffset,
            string? speaker,
            int? startIndex,
            string? startOffset,
            string? text)
        {
            this.EndIndex = endIndex;
            this.EndOffset = endOffset;
            this.Speaker = speaker;
            this.StartIndex = startIndex;
            this.StartOffset = startOffset;
            this.Text = text;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordInfo" /> class.
        /// </summary>
        public WordInfo()
        {
        }

    }
}