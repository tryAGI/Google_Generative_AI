#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Updates a trigger.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Trigger> UpdateTriggerAsync(
            string id,

            global::Google.Gemini.NextGen.UpdateTriggerRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a trigger.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Trigger>> UpdateTriggerAsResponseAsync(
            string id,

            global::Google.Gemini.NextGen.UpdateTriggerRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a trigger.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trigger">
        /// Represents the fields of a Trigger that can be updated.
        /// </param>
        /// <param name="requestId">
        /// Required. The ID of the trigger to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applies to the resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Trigger> UpdateTriggerAsync(
            string id,
            global::Google.Gemini.NextGen.TriggerUpdate trigger,
            string requestId,
            string? updateMask = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}