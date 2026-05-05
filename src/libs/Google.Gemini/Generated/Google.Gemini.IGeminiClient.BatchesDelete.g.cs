#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the operation result. It does not cancel the operation. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Empty> BatchesDeleteAsync(
            string batchesId,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the operation result. It does not cancel the operation. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.Empty>> BatchesDeleteAsResponseAsync(
            string batchesId,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}