#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.TunedModel> TunedModelsGetAsync(
            string tunedModelsId,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.TunedModel>> TunedModelsGetAsResponseAsync(
            string tunedModelsId,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}