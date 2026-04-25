
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A resource representing a batch of `EmbedContent` requests.
    /// </summary>
    public sealed partial class EmbedContentBatch
    {
        /// <summary>
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Stats about the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchStats")]
        public global::Google.Gemini.EmbedContentBatchStats? BatchStats { get; set; }

        /// <summary>
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public string? Priority { get; set; }

        /// <summary>
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EmbedContentBatchStateJsonConverter))]
        public global::Google.Gemini.EmbedContentBatchState? State { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configures the input to the batch request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputConfig")]
        public global::Google.Gemini.InputEmbedContentConfig? InputConfig { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// The output of a batch request. This is returned in the `AsyncBatchEmbedContentResponse` or the `EmbedContentBatch.output` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Google.Gemini.EmbedContentBatchOutput? Output { get; set; }

        /// <summary>
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Required. The user-defined name of this batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentBatch" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="createTime">
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="batchStats">
        /// Stats about the batch.
        /// </param>
        /// <param name="priority">
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputConfig">
        /// Configures the input to the batch request.
        /// </param>
        /// <param name="updateTime">
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="output">
        /// The output of a batch request. This is returned in the `AsyncBatchEmbedContentResponse` or the `EmbedContentBatch.output` field.
        /// </param>
        /// <param name="endTime">
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Required. The user-defined name of this batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedContentBatch(
            string? model,
            string? createTime,
            global::Google.Gemini.EmbedContentBatchStats? batchStats,
            string? priority,
            global::Google.Gemini.EmbedContentBatchState? state,
            string? name,
            global::Google.Gemini.InputEmbedContentConfig? inputConfig,
            string? updateTime,
            global::Google.Gemini.EmbedContentBatchOutput? output,
            string? endTime,
            string? displayName)
        {
            this.Model = model;
            this.CreateTime = createTime;
            this.BatchStats = batchStats;
            this.Priority = priority;
            this.State = state;
            this.Name = name;
            this.InputConfig = inputConfig;
            this.UpdateTime = updateTime;
            this.Output = output;
            this.EndTime = endTime;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentBatch" /> class.
        /// </summary>
        public EmbedContentBatch()
        {
        }
    }
}