#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> UpdateAsync(
            string id,

            global::Google.Gemini.NextGen.WebhookUpdate request,
            string? updateMask = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Webhook>> UpdateAsResponseAsync(
            string id,

            global::Google.Gemini.NextGen.WebhookUpdate request,
            string? updateMask = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// Optional. The user-provided name of the webhook.
        /// </param>
        /// <param name="state">
        /// Optional. The state of the webhook.
        /// </param>
        /// <param name="subscribedEvents">
        /// Optional. The events that the webhook is subscribed to.<br/>
        /// Available events:<br/>
        /// - batch.succeeded<br/>
        /// - batch.expired<br/>
        /// - batch.failed<br/>
        /// - interaction.requires_action<br/>
        /// - interaction.completed<br/>
        /// - interaction.failed<br/>
        /// - video.generated
        /// </param>
        /// <param name="uri">
        /// Optional. The URI to which webhook events will be sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> UpdateAsync(
            string id,
            string? updateMask = default,
            string? name = default,
            global::Google.Gemini.NextGen.WebhookUpdateState? state = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? subscribedEvents = default,
            string? uri = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}