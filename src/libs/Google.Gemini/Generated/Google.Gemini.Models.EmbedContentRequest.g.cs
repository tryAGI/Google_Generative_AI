
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request containing the `Content` for the model to embed.
    /// </summary>
    public sealed partial class EmbedContentRequest
    {
        /// <summary>
        /// Optional. An optional title for the text. Only applicable when TaskType is `RETRIEVAL_DOCUMENT`. Note: Specifying a `title` for `RETRIEVAL_DOCUMENT` provides better quality embeddings for retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Google.Gemini.Content? Content { get; set; }

        /// <summary>
        /// Optional. Optional task type for which the embeddings will be used. Can only be set for `models/embedding-001` or newer models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeJsonConverter))]
        public global::Google.Gemini.EmbedContentRequestTaskType? TaskType { get; set; }

        /// <summary>
        /// Required. The model's resource name. This serves as an ID for the Model to use. This name should match a model name returned by the `ListModels` method. Format: `models/{model}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024, and the earlier model (`models/embedding-001`) cannot specify this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDimensionality")]
        public int? OutputDimensionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}