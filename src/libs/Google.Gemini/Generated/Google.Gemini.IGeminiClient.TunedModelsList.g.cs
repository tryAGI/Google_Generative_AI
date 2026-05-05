#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Lists created tuned models.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.ListTunedModelsResponse> TunedModelsListAsync(
            string? filter = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists created tuned models.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.ListTunedModelsResponse>> TunedModelsListAsResponseAsync(
            string? filter = default,
            int? pageSize = default,
            string? pageToken = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}