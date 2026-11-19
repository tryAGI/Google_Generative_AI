
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioStaticMediaProcessing
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Optional. Segment start time, relative to the start of the audio stream. Specified<br/>
        /// as a decimal number of seconds followed by an 's' suffix, e.g., "10.5s".<br/>
        /// Must be non-negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// Optional. Segment end time, relative to the start of the audio stream. Specified<br/>
        /// as a decimal number of seconds followed by an 's' suffix, e.g., "30s".<br/>
        /// Must be positive and greater than `start_offset` if `start_offset` is<br/>
        /// set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioStaticMediaProcessing" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="startOffset">
        /// Optional. Segment start time, relative to the start of the audio stream. Specified<br/>
        /// as a decimal number of seconds followed by an 's' suffix, e.g., "10.5s".<br/>
        /// Must be non-negative.
        /// </param>
        /// <param name="endOffset">
        /// Optional. Segment end time, relative to the start of the audio stream. Specified<br/>
        /// as a decimal number of seconds followed by an 's' suffix, e.g., "30s".<br/>
        /// Must be positive and greater than `start_offset` if `start_offset` is<br/>
        /// set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioStaticMediaProcessing(
            object type,
            string? startOffset,
            string? endOffset)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioStaticMediaProcessing" /> class.
        /// </summary>
        public AudioStaticMediaProcessing()
        {
        }

    }
}