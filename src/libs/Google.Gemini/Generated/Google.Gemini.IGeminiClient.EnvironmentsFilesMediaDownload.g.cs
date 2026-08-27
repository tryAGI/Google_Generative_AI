#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Retrieves a file or directory from an environment's snapshot (HTTP endpoint).
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="environmentsId"></param>
        /// <param name="filesId"></param>
        /// <param name="recursive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GetEnvironmentFilesResponse> EnvironmentsFilesMediaDownloadAsync(
            string environmentsId,
            string filesId,
            int? pageSize = default,
            string? pageToken = default,
            bool? recursive = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a file or directory from an environment's snapshot (HTTP endpoint).
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="environmentsId"></param>
        /// <param name="filesId"></param>
        /// <param name="recursive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.GetEnvironmentFilesResponse>> EnvironmentsFilesMediaDownloadAsResponseAsync(
            string environmentsId,
            string filesId,
            int? pageSize = default,
            string? pageToken = default,
            bool? recursive = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}