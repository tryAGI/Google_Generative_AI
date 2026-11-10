#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Uploads (creates or updates) a file in an environment's workspace.
        /// </summary>
        /// <param name="environmentsId"></param>
        /// <param name="filesId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.UploadEnvironmentFileResponse> EnvironmentsFilesMediaUploadAsync(
            string environmentsId,
            string filesId,

            global::Google.Gemini.UploadEnvironmentFileRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads (creates or updates) a file in an environment's workspace.
        /// </summary>
        /// <param name="environmentsId"></param>
        /// <param name="filesId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.UploadEnvironmentFileResponse>> EnvironmentsFilesMediaUploadAsResponseAsync(
            string environmentsId,
            string filesId,

            global::Google.Gemini.UploadEnvironmentFileRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads (creates or updates) a file in an environment's workspace.
        /// </summary>
        /// <param name="environmentsId"></param>
        /// <param name="filesId"></param>
        /// <param name="overwrite">
        /// Optional. Whether to overwrite the destination file if it already exists.
        /// </param>
        /// <param name="extract">
        /// Optional. If true, treats the uploaded file as a tar/tar.gz archive and unpacks it into `path`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.UploadEnvironmentFileResponse> EnvironmentsFilesMediaUploadAsync(
            string environmentsId,
            string filesId,
            bool? overwrite = default,
            bool? extract = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}