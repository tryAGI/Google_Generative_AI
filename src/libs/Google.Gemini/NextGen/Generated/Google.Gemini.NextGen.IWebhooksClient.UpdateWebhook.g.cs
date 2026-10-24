#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> UpdateWebhookAsync(
            string id,

            global::Google.Gemini.NextGen.UpdateWebhookRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Webhook>> UpdateWebhookAsResponseAsync(
            string id,

            global::Google.Gemini.NextGen.UpdateWebhookRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webhook"></param>
        /// <param name="requestId">
        /// Required. The ID of the webhook to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Webhook> UpdateWebhookAsync(
            string id,
            global::Google.Gemini.NextGen.WebhookUpdate webhook,
            string requestId,
            string? updateMask = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}