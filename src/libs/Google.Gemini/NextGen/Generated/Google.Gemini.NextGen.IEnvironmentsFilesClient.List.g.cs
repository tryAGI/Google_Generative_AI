#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IEnvironmentsFilesClient
    {
        /// <summary>
        /// Retrieves file metadata or directory contents from an environment's snapshot. To download file content, use the download URL returned in the response.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="recursive"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://generativelanguage.googleapis.com/v1beta/environments/env_abc123/files/src' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.GetEnvironmentFilesResponse> ListAsync(
            string environment,
            string path,
            int? pageSize = default,
            string? pageToken = default,
            bool? recursive = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves file metadata or directory contents from an environment's snapshot. To download file content, use the download URL returned in the response.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="recursive"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://generativelanguage.googleapis.com/v1beta/environments/env_abc123/files/src' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.GetEnvironmentFilesResponse>> ListAsResponseAsync(
            string environment,
            string path,
            int? pageSize = default,
            string? pageToken = default,
            bool? recursive = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}