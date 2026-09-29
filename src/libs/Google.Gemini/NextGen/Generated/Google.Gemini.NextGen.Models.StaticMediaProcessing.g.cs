
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StaticMediaProcessing
    {
        /// <summary>
        /// Optional. Segment end time. Specified as a decimal number of seconds followed<br/>
        /// by an 's' suffix, e.g., "30s". Must be non-negative and greater than<br/>
        /// `start_offset` if `start_offset` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Optional. Video frame-rate sampling density.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Optional. Segment start time. Specified as a decimal number of seconds followed<br/>
        /// by an 's' suffix, e.g., "10.5s". Must be non-negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        public string? StartOffset { get; set; }

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
        /// Initializes a new instance of the <see cref="StaticMediaProcessing" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endOffset">
        /// Optional. Segment end time. Specified as a decimal number of seconds followed<br/>
        /// by an 's' suffix, e.g., "30s". Must be non-negative and greater than<br/>
        /// `start_offset` if `start_offset` is set.
        /// </param>
        /// <param name="fps">
        /// Optional. Video frame-rate sampling density.
        /// </param>
        /// <param name="startOffset">
        /// Optional. Segment start time. Specified as a decimal number of seconds followed<br/>
        /// by an 's' suffix, e.g., "10.5s". Must be non-negative.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticMediaProcessing(
            object type,
            string? endOffset,
            double? fps,
            string? startOffset)
        {
            this.EndOffset = endOffset;
            this.Fps = fps;
            this.StartOffset = startOffset;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticMediaProcessing" /> class.
        /// </summary>
        public StaticMediaProcessing()
        {
        }

    }
}