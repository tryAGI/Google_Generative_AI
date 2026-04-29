
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request containing the `Content` for the model to embed.
    /// </summary>
    public sealed partial class EmbedContentRequest
    {
        /// <summary>
        /// Optional. Deprecated: Please use EmbedContentConfig.title instead. An optional title for the text. Only applicable when TaskType is `RETRIEVAL_DOCUMENT`. Note: Specifying a `title` for `RETRIEVAL_DOCUMENT` provides better quality embeddings for retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Title { get; set; }

        /// <summary>
        /// Configurations for the EmbedContent request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedContentConfig")]
        public global::Google.Gemini.EmbedContentConfig? EmbedContentConfig { get; set; }

        /// <summary>
        /// Optional. Deprecated: Please use EmbedContentConfig.task_type instead. Optional task type for which the embeddings will be used. Not supported on earlier models (`models/embedding-001`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.EmbedContentRequestTaskType? TaskType { get; set; }

        /// <summary>
        /// Required. The model's resource name. This serves as an ID for the Model to use. This name should match a model name returned by the `ListModels` method. Format: `models/{model}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional. Deprecated: Please use EmbedContentConfig.output_dimensionality instead. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024 only. You cannot set this value if using the earlier model (`models/embedding-001`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDimensionality")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? OutputDimensionality { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Google.Gemini.Content? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentRequest" /> class.
        /// </summary>
        /// <param name="embedContentConfig">
        /// Configurations for the EmbedContent request.
        /// </param>
        /// <param name="model">
        /// Required. The model's resource name. This serves as an ID for the Model to use. This name should match a model name returned by the `ListModels` method. Format: `models/{model}`
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedContentRequest(
            global::Google.Gemini.EmbedContentConfig? embedContentConfig,
            string? model,
            global::Google.Gemini.Content? content)
        {
            this.EmbedContentConfig = embedContentConfig;
            this.Model = model;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentRequest" /> class.
        /// </summary>
        public EmbedContentRequest()
        {
        }
    }
}