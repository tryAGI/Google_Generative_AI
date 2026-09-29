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
        /// <param name="interaction">
        /// Required. The interaction request template to be executed.
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
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction> interaction,
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