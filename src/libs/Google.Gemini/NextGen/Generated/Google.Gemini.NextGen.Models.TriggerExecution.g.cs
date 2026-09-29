
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An execution instance of a trigger.
    /// </summary>
    public sealed partial class TriggerExecution
    {
        /// <summary>
        /// Output only. The time when the execution finished.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Output only. The environment ID used for the execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Output only. The error message if the execution failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Required. Output only. Identifier. The ID of the trigger execution.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Output only. The ID of the interaction created by this execution, if any.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_id")]
        public string? InteractionId { get; set; }

        /// <summary>
        /// Output only. The time when the execution was scheduled to run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time")]
        public global::System.DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Output only. The time when the execution started.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Output only. The status of the execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerExecutionStatusJsonConverter))]
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Status { get; set; }

        /// <summary>
        /// Required. Output only. Identifier. The ID of the trigger that created this execution.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        public string TriggerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerExecution" /> class.
        /// </summary>
        /// <param name="endTime">
        /// Output only. The time when the execution finished.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="environmentId">
        /// Output only. The environment ID used for the execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Output only. The error message if the execution failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="interactionId">
        /// Output only. The ID of the interaction created by this execution, if any.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="scheduledTime">
        /// Output only. The time when the execution was scheduled to run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// Output only. The time when the execution started.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. The status of the execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Required. Output only. Identifier. The ID of the trigger execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="triggerId">
        /// Required. Output only. Identifier. The ID of the trigger that created this execution.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerExecution(
            global::System.DateTime? endTime,
            string? environmentId,
            string? error,
            string? interactionId,
            global::System.DateTime? scheduledTime,
            global::System.DateTime? startTime,
            global::Google.Gemini.NextGen.TriggerExecutionStatus? status,
            string id = default!,
            string triggerId = default!)
        {
            this.EndTime = endTime;
            this.EnvironmentId = environmentId;
            this.Error = error;
            this.Id = id;
            this.InteractionId = interactionId;
            this.ScheduledTime = scheduledTime;
            this.StartTime = startTime;
            this.Status = status;
            this.TriggerId = triggerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerExecution" /> class.
        /// </summary>
        public TriggerExecution()
        {
        }

    }
}