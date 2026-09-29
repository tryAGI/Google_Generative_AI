#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Generates a new signing secret for a Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse> RotateSigningSecretAsync(
            string id,

            global::Google.Gemini.NextGen.RotateSigningSecretRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates a new signing secret for a Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse>> RotateSigningSecretAsResponseAsync(
            string id,

            global::Google.Gemini.NextGen.RotateSigningSecretRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates a new signing secret for a Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="revocationBehavior">
        /// Optional. The revocation behavior for previous signing secrets.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse> RotateSigningSecretAsync(
            string id,
            global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? revocationBehavior = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}