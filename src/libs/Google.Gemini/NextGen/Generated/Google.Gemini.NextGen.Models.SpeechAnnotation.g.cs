
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Speech annotation for text content.
    /// </summary>
    public sealed partial class SpeechAnnotation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The speaker to associate with this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Style instruction for the speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAnnotation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="speaker">
        /// The speaker to associate with this turn.
        /// </param>
        /// <param name="style">
        /// Style instruction for the speech synthesis.
        /// </param>
        /// <param name="startIndex">
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="endIndex">
        /// End of the attributed segment, exclusive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechAnnotation(
            object type,
            string? speaker,
            string? style,
            int? startIndex,
            int? endIndex)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Speaker = speaker;
            this.Style = style;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAnnotation" /> class.
        /// </summary>
        public SpeechAnnotation()
        {
        }

    }
}