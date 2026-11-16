
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata describes the input audio content. Set this in `Part.audio_metadata` or `FunctionResponsePart.audio_metadata` when `inline_data` or `file_data` contains audio to configure static audio preprocessing.
    /// </summary>
    public sealed partial class AudioMetadata
    {
        /// <summary>
        /// Optional. The end offset of the audio, relative to the start of the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOffset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Optional. The start offset of the audio, relative to the start of the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startOffset")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioMetadata" /> class.
        /// </summary>
        /// <param name="endOffset">
        /// Optional. The end offset of the audio, relative to the start of the audio stream.
        /// </param>
        /// <param name="startOffset">
        /// Optional. The start offset of the audio, relative to the start of the audio stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioMetadata(
            string? endOffset,
            string? startOffset)
        {
            this.EndOffset = endOffset;
            this.StartOffset = startOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioMetadata" /> class.
        /// </summary>
        public AudioMetadata()
        {
        }

    }
}