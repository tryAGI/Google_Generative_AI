
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Information about a single recognized word.
    /// </summary>
    public sealed partial class WordInfo
    {
        /// <summary>
        /// Required. Transcript of the word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Optional. Start offset in time of the word relative to the start of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startOffset")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// Optional. End offset in time of the word relative to the start of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOffset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordInfo" /> class.
        /// </summary>
        /// <param name="word">
        /// Required. Transcript of the word.
        /// </param>
        /// <param name="startOffset">
        /// Optional. Start offset in time of the word relative to the start of the audio.
        /// </param>
        /// <param name="endOffset">
        /// Optional. End offset in time of the word relative to the start of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordInfo(
            string? word,
            string? startOffset,
            string? endOffset)
        {
            this.Word = word;
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordInfo" /> class.
        /// </summary>
        public WordInfo()
        {
        }

    }
}