
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Parameters for creating a trigger.
    /// </summary>
    public sealed partial class TriggerCreateParams
    {
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
        /// Optional. The execution timeout for the triggered interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_timeout_seconds")]
        public int? ExecutionTimeoutSeconds { get; set; }

        /// <summary>
        /// Required. The interaction request template to be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction> Interaction { get; set; }

        /// <summary>
        /// Optional. The maximum number of consecutive failures allowed before<br/>
        /// the trigger is automatically paused (status becomes ERROR).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_consecutive_failures")]
        public int? MaxConsecutiveFailures { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerCreateParams" /> class.
        /// </summary>
        /// <param name="interaction">
        /// Required. The interaction request template to be executed.
        /// </param>
        /// <param name="schedule">
        /// Required. The cron schedule on which the trigger should run.<br/>
        /// Standard cron format.
        /// </param>
        /// <param name="timeZone">
        /// Required. Time zone in which the schedule should be interpreted.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the trigger.
        /// </param>
        /// <param name="environmentId">
        /// Optional. The environment ID for the trigger execution.
        /// </param>
        /// <param name="executionTimeoutSeconds">
        /// Optional. The execution timeout for the triggered interaction.
        /// </param>
        /// <param name="maxConsecutiveFailures">
        /// Optional. The maximum number of consecutive failures allowed before<br/>
        /// the trigger is automatically paused (status becomes ERROR).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerCreateParams(
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction> interaction,
            string schedule,
            string timeZone,
            string? displayName,
            string? environmentId,
            int? executionTimeoutSeconds,
            int? maxConsecutiveFailures)
        {
            this.DisplayName = displayName;
            this.EnvironmentId = environmentId;
            this.ExecutionTimeoutSeconds = executionTimeoutSeconds;
            this.Interaction = interaction;
            this.MaxConsecutiveFailures = maxConsecutiveFailures;
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.TimeZone = timeZone ?? throw new global::System.ArgumentNullException(nameof(timeZone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerCreateParams" /> class.
        /// </summary>
        public TriggerCreateParams()
        {
        }

    }
}