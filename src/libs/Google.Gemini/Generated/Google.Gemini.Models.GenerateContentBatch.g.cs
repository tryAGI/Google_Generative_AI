
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A resource representing a batch of `GenerateContent` requests.
    /// </summary>
    public sealed partial class GenerateContentBatch
    {
        /// <summary>
        /// Required. The user-defined name of this batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public string? Priority { get; set; }

        /// <summary>
        /// Configures the input to the batch request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputConfig")]
        public global::Google.Gemini.InputConfig? InputConfig { get; set; }

        /// <summary>
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.GenerateContentBatchStateJsonConverter))]
        public global::Google.Gemini.GenerateContentBatchState? State { get; set; }

        /// <summary>
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Stats about the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchStats")]
        public global::Google.Gemini.BatchStats? BatchStats { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The output of a batch request. This is returned in the `BatchGenerateContentResponse` or the `GenerateContentBatch.output` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Google.Gemini.GenerateContentBatchOutput? Output { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatch" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Required. The user-defined name of this batch.
        /// </param>
        /// <param name="updateTime">
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="priority">
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </param>
        /// <param name="inputConfig">
        /// Configures the input to the batch request.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endTime">
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="batchStats">
        /// Stats about the batch.
        /// </param>
        /// <param name="createTime">
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="output">
        /// The output of a batch request. This is returned in the `BatchGenerateContentResponse` or the `GenerateContentBatch.output` field.
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentBatch(
            string? displayName,
            string? updateTime,
            string? priority,
            global::Google.Gemini.InputConfig? inputConfig,
            global::Google.Gemini.GenerateContentBatchState? state,
            string? endTime,
            global::Google.Gemini.BatchStats? batchStats,
            string? createTime,
            string? model,
            global::Google.Gemini.GenerateContentBatchOutput? output,
            string? name)
        {
            this.DisplayName = displayName;
            this.UpdateTime = updateTime;
            this.Priority = priority;
            this.InputConfig = inputConfig;
            this.State = state;
            this.EndTime = endTime;
            this.BatchStats = batchStats;
            this.CreateTime = createTime;
            this.Model = model;
            this.Output = output;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatch" /> class.
        /// </summary>
        public GenerateContentBatch()
        {
        }
    }
}