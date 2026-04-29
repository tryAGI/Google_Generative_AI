
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configurations for the EmbedContent request.
    /// </summary>
    public sealed partial class EmbedContentConfig
    {
        /// <summary>
        /// Optional. The task type of the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EmbedContentConfigTaskTypeJsonConverter))]
        public global::Google.Gemini.EmbedContentConfigTaskType? TaskType { get; set; }

        /// <summary>
        /// Optional. Whether to extract audio from video content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioTrackExtraction")]
        public bool? AudioTrackExtraction { get; set; }

        /// <summary>
        /// Optional. Whether to enable OCR for document content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentOcr")]
        public bool? DocumentOcr { get; set; }

        /// <summary>
        /// Optional. The title for the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. Whether to silently truncate the input content if it's longer than the maximum sequence length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoTruncate")]
        public bool? AutoTruncate { get; set; }

        /// <summary>
        /// Optional. Reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDimensionality")]
        public int? OutputDimensionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentConfig" /> class.
        /// </summary>
        /// <param name="taskType">
        /// Optional. The task type of the embedding.
        /// </param>
        /// <param name="audioTrackExtraction">
        /// Optional. Whether to extract audio from video content.
        /// </param>
        /// <param name="documentOcr">
        /// Optional. Whether to enable OCR for document content.
        /// </param>
        /// <param name="title">
        /// Optional. The title for the text.
        /// </param>
        /// <param name="autoTruncate">
        /// Optional. Whether to silently truncate the input content if it's longer than the maximum sequence length.
        /// </param>
        /// <param name="outputDimensionality">
        /// Optional. Reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedContentConfig(
            global::Google.Gemini.EmbedContentConfigTaskType? taskType,
            bool? audioTrackExtraction,
            bool? documentOcr,
            string? title,
            bool? autoTruncate,
            int? outputDimensionality)
        {
            this.TaskType = taskType;
            this.AudioTrackExtraction = audioTrackExtraction;
            this.DocumentOcr = documentOcr;
            this.Title = title;
            this.AutoTruncate = autoTruncate;
            this.OutputDimensionality = outputDimensionality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentConfig" /> class.
        /// </summary>
        public EmbedContentConfig()
        {
        }
    }
}