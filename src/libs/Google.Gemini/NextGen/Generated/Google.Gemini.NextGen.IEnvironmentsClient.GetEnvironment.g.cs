#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Gets an environment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/environments/env_abc123 \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Environment2> GetEnvironmentAsync(
            string id,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets an environment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/environments/env_abc123 \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Environment2>> GetEnvironmentAsResponseAsync(
            string id,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}