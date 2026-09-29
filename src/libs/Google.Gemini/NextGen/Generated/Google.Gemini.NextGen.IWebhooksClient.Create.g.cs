#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Creates a new Webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> CreateAsync(

            global::Google.Gemini.NextGen.Webhook request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Webhook>> CreateAsResponseAsync(

            global::Google.Gemini.NextGen.Webhook request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Webhook.
        /// </summary>
        /// <param name="name">
        /// Optional. The user-provided name of the webhook.
        /// </param>
        /// <param name="subscribedEvents">
        /// Required. The events that the webhook is subscribed to.<br/>
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
        /// Required. The URI to which webhook events will be sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> CreateAsync(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent> subscribedEvents,
            string uri,
            string? name = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}