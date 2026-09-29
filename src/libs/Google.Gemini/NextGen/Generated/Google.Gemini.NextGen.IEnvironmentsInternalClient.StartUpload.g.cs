#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IEnvironmentsInternalClient
    {
        /// <summary>
        /// Start an environment file upload<br/>
        /// Starts a resumable upload session for a file in an environment workspace.<br/>
        /// Upload the file bytes to the URL returned in the `X-Goog-Upload-URL`<br/>
        /// response header, using the resumable upload protocol.
        /// </summary>
        /// <param name="extract"></param>
        /// <param name="overwrite"></param>
        /// <param name="xGoogUploadCommand">
        /// Default Value: start
        /// </param>
        /// <param name="xGoogUploadHeaderContentLength"></param>
        /// <param name="xGoogUploadHeaderContentType"></param>
        /// <param name="xGoogUploadProtocol">
        /// Default Value: resumable
        /// </param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -i -X PUT \<br/>
        ///   'https://generativelanguage.googleapis.com/upload/v1beta/environments/env_abc123/files/main.py?overwrite=true' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H 'X-Goog-Upload-Protocol: resumable' \<br/>
        ///   -H 'X-Goog-Upload-Command: start' \<br/>
        ///   -H "X-Goog-Upload-Header-Content-Length: $(wc -c &lt; main.py)" \<br/>
        ///   -H 'X-Goog-Upload-Header-Content-Type: text/x-python'
        /// </remarks>
        global::System.Threading.Tasks.Task StartUploadAsync(
            long xGoogUploadHeaderContentLength,
            string xGoogUploadHeaderContentType,
            string environment,
            string path,
            bool? extract = default,
            bool? overwrite = default,
            string xGoogUploadCommand = "start",
            string xGoogUploadProtocol = "resumable",
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an environment file upload<br/>
        /// Starts a resumable upload session for a file in an environment workspace.<br/>
        /// Upload the file bytes to the URL returned in the `X-Goog-Upload-URL`<br/>
        /// response header, using the resumable upload protocol.
        /// </summary>
        /// <param name="extract"></param>
        /// <param name="overwrite"></param>
        /// <param name="xGoogUploadCommand">
        /// Default Value: start
        /// </param>
        /// <param name="xGoogUploadHeaderContentLength"></param>
        /// <param name="xGoogUploadHeaderContentType"></param>
        /// <param name="xGoogUploadProtocol">
        /// Default Value: resumable
        /// </param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -i -X PUT \<br/>
        ///   'https://generativelanguage.googleapis.com/upload/v1beta/environments/env_abc123/files/main.py?overwrite=true' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H 'X-Goog-Upload-Protocol: resumable' \<br/>
        ///   -H 'X-Goog-Upload-Command: start' \<br/>
        ///   -H "X-Goog-Upload-Header-Content-Length: $(wc -c &lt; main.py)" \<br/>
        ///   -H 'X-Goog-Upload-Header-Content-Type: text/x-python'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse> StartUploadAsResponseAsync(
            long xGoogUploadHeaderContentLength,
            string xGoogUploadHeaderContentType,
            string environment,
            string path,
            bool? extract = default,
            bool? overwrite = default,
            string xGoogUploadCommand = "start",
            string xGoogUploadProtocol = "resumable",
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}