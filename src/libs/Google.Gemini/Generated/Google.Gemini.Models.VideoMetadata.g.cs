
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata describes the input video content. Set this in `Part.video_metadata` or `FunctionResponsePart.video_metadata` when `inline_data` or `file_data` contains video to configure static video preprocessing (such as time clipping, frame rate, maximum frame count, or extracted content layers).
    /// </summary>
    public sealed partial class VideoMetadata
    {
        /// <summary>
        /// Optional. The start offset of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startOffset")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// Optional. The end offset of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOffset")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Optional. The frame rate of the video sent to the model. If not specified, the default value will be 1.0. The fps range is (0.0, 24.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        /// <param name="startOffset">
        /// Optional. The start offset of the video.
        /// </param>
        /// <param name="endOffset">
        /// Optional. The end offset of the video.
        /// </param>
        /// <param name="fps">
        /// Optional. The frame rate of the video sent to the model. If not specified, the default value will be 1.0. The fps range is (0.0, 24.0].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMetadata(
            string? startOffset,
            string? endOffset,
            double? fps)
        {
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
            this.Fps = fps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        public VideoMetadata()
        {
        }

    }
}