
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A trigger configuration that is scheduled to run an agent.
    /// </summary>
    public sealed partial class Trigger
    {
        /// <summary>
        /// Required. Output only. Identifier. The ID of the trigger.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Required. The cron schedule on which the trigger should run.<br/>
        /// Standard cron format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schedule { get; set; }

        /// <summary>
        /// Required. Time zone in which the schedule should be interpreted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimeZone { get; set; }

        /// <summary>
        /// Interaction for generating the completion using agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.CreateAgentInteraction CreateAgentInteraction { get; set; }

        /// <summary>
        /// Optional. The display name of the trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional. The environment ID for the trigger execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Optional. The maximum number of consecutive failures allowed before<br/>
        /// the trigger is automatically paused (status becomes ERROR).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_consecutive_failures")]
        public int? MaxConsecutiveFailures { get; set; }

        /// <summary>
        /// Optional. The execution timeout for the triggered interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_timeout_seconds")]
        public int? ExecutionTimeoutSeconds { get; set; }

        /// <summary>
        /// Output only. The number of consecutive failures that have occurred<br/>
        /// since the last successful execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consecutive_failure_count")]
        public int? ConsecutiveFailureCount { get; set; }

        /// <summary>
        /// Output only. The time when the trigger was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Output only. The time when the trigger was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Output only. The time when the trigger was last run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_time")]
        public global::System.DateTime? LastRunTime { get; set; }

        /// <summary>
        /// Output only. The time when the trigger is scheduled to run next.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_run_time")]
        public global::System.DateTime? NextRunTime { get; set; }

        /// <summary>
        /// Output only. The time when the trigger was last paused.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_pause_time")]
        public global::System.DateTime? LastPauseTime { get; set; }

        /// <summary>
        /// Output only. The time when the trigger was last resumed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_resume_time")]
        public global::System.DateTime? LastResumeTime { get; set; }

        /// <summary>
        /// Output only. The ID of the last interaction created by this trigger.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_interaction_id")]
        public string? PreviousInteractionId { get; set; }

        /// <summary>
        /// Output only. The current status of the trigger.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerStatusJsonConverter))]
        public global::Google.Gemini.NextGen.TriggerStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="schedule">
        /// Required. The cron schedule on which the trigger should run.<br/>
        /// Standard cron format.
        /// </param>
        /// <param name="timeZone">
        /// Required. Time zone in which the schedule should be interpreted.
        /// </param>
        /// <param name="createAgentInteraction">
        /// Interaction for generating the completion using agents.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the trigger.
        /// </param>
        /// <param name="environmentId">
        /// Optional. The environment ID for the trigger execution.
        /// </param>
        /// <param name="maxConsecutiveFailures">
        /// Optional. The maximum number of consecutive failures allowed before<br/>
        /// the trigger is automatically paused (status becomes ERROR).
        /// </param>
        /// <param name="executionTimeoutSeconds">
        /// Optional. The execution timeout for the triggered interaction.
        /// </param>
        /// <param name="consecutiveFailureCount">
        /// Output only. The number of consecutive failures that have occurred<br/>
        /// since the last successful execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Output only. The time when the trigger was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The time when the trigger was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastRunTime">
        /// Output only. The time when the trigger was last run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextRunTime">
        /// Output only. The time when the trigger is scheduled to run next.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastPauseTime">
        /// Output only. The time when the trigger was last paused.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastResumeTime">
        /// Output only. The time when the trigger was last resumed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="previousInteractionId">
        /// Output only. The ID of the last interaction created by this trigger.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. The current status of the trigger.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Required. Output only. Identifier. The ID of the trigger.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trigger(
            string schedule,
            string timeZone,
            global::Google.Gemini.NextGen.CreateAgentInteraction createAgentInteraction,
            string? displayName,
            string? environmentId,
            int? maxConsecutiveFailures,
            int? executionTimeoutSeconds,
            int? consecutiveFailureCount,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? lastRunTime,
            global::System.DateTime? nextRunTime,
            global::System.DateTime? lastPauseTime,
            global::System.DateTime? lastResumeTime,
            string? previousInteractionId,
            global::Google.Gemini.NextGen.TriggerStatus? status,
            string id = default!)
        {
            this.Id = id;
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.TimeZone = timeZone ?? throw new global::System.ArgumentNullException(nameof(timeZone));
            this.CreateAgentInteraction = createAgentInteraction ?? throw new global::System.ArgumentNullException(nameof(createAgentInteraction));
            this.DisplayName = displayName;
            this.EnvironmentId = environmentId;
            this.MaxConsecutiveFailures = maxConsecutiveFailures;
            this.ExecutionTimeoutSeconds = executionTimeoutSeconds;
            this.ConsecutiveFailureCount = consecutiveFailureCount;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.LastRunTime = lastRunTime;
            this.NextRunTime = nextRunTime;
            this.LastPauseTime = lastPauseTime;
            this.LastResumeTime = lastResumeTime;
            this.PreviousInteractionId = previousInteractionId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        public Trigger()
        {
        }

    }
}