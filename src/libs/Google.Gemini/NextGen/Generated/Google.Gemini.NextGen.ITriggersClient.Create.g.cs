#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Creates a new trigger that will invoke the specified agent on the given<br/>
        /// cron schedule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/triggers \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "schedule": "0 9 * * *",<br/>
        ///     "time_zone": "America/New_York",<br/>
        ///     "interaction": {<br/>
        ///       "agent": "antigravity-preview-05-2026",<br/>
        ///       "input": "Summarize top news stories.",<br/>
        ///       "environment": "remote"<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Trigger> CreateAsync(

            global::Google.Gemini.NextGen.TriggerCreateParams request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new trigger that will invoke the specified agent on the given<br/>
        /// cron schedule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/triggers \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "schedule": "0 9 * * *",<br/>
        ///     "time_zone": "America/New_York",<br/>
        ///     "interaction": {<br/>
        ///       "agent": "antigravity-preview-05-2026",<br/>
        ///       "input": "Summarize top news stories.",<br/>
        ///       "environment": "remote"<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Trigger>> CreateAsResponseAsync(

            global::Google.Gemini.NextGen.TriggerCreateParams request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new trigger that will invoke the specified agent on the given<br/>
        /// cron schedule.
        /// </summary>
        /// <param name="displayName">
        /// Optional. The display name of the trigger.
        /// </param>
        /// <param name="environmentId">
        /// Optional. The environment ID for the trigger execution.
        /// </param>
        /// <param name="executionTimeoutSeconds">
        /// Optional. The execution timeout for the triggered interaction.
        /// </param>
        /// <param name="createAgentInteraction">
        /// Interaction for generating the completion using agents.
        /// </param>
        /// <param name="maxConsecutiveFailures">
        /// Optional. The maximum number of consecutive failures allowed before<br/>
        /// the trigger is automatically paused (status becomes ERROR).
        /// </param>
        /// <param name="schedule">
        /// Required. The cron schedule on which the trigger should run.<br/>
        /// Standard cron format.
        /// </param>
        /// <param name="timeZone">
        /// Required. Time zone in which the schedule should be interpreted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Trigger> CreateAsync(
            global::Google.Gemini.NextGen.CreateAgentInteraction createAgentInteraction,
            string schedule,
            string timeZone,
            string? displayName = default,
            string? environmentId = default,
            int? executionTimeoutSeconds = default,
            int? maxConsecutiveFailures = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}