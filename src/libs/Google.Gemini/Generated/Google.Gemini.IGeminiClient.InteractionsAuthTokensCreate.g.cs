#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Creates a short-lived auth token for client-side authentication (HTTP).
        /// </summary>
        /// <param name="interactionsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.HttpBody> InteractionsAuthTokensCreateAsync(
            string interactionsId,

            global::Google.Gemini.HttpBody request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a short-lived auth token for client-side authentication (HTTP).
        /// </summary>
        /// <param name="interactionsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.HttpBody>> InteractionsAuthTokensCreateAsResponseAsync(
            string interactionsId,

            global::Google.Gemini.HttpBody request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a short-lived auth token for client-side authentication (HTTP).
        /// </summary>
        /// <param name="interactionsId"></param>
        /// <param name="extensions">
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </param>
        /// <param name="contentType">
        /// The HTTP Content-Type header value specifying the content type of the body.
        /// </param>
        /// <param name="data">
        /// The HTTP request/response body as raw binary.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.HttpBody> InteractionsAuthTokensCreateAsync(
            string interactionsId,
            global::System.Collections.Generic.IList<object>? extensions = default,
            string? contentType = default,
            byte[]? data = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}