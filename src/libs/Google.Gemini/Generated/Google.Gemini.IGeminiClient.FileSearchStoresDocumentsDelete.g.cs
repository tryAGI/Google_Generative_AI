#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a `Document`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="force"></param>
        /// <param name="documentsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Empty> FileSearchStoresDocumentsDeleteAsync(
            string fileSearchStoresId,
            string documentsId,
            bool? force = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a `Document`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="force"></param>
        /// <param name="documentsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.Empty>> FileSearchStoresDocumentsDeleteAsResponseAsync(
            string fileSearchStoresId,
            string documentsId,
            bool? force = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}