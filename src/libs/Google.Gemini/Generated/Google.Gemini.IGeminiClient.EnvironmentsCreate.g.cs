#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EnvironmentConfig> EnvironmentsCreateAsync(

            global::Google.Gemini.EnvironmentConfig request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.EnvironmentConfig>> EnvironmentsCreateAsResponseAsync(

            global::Google.Gemini.EnvironmentConfig request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
        /// <param name="environmentId">
        /// Optional. The environment ID for the interaction. If specified, the request will update the existing environment instead of creating a new one.
        /// </param>
        /// <param name="sources"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EnvironmentConfig> EnvironmentsCreateAsync(
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist = default,
            global::Google.Gemini.EnvironmentConfigNetworkMode? networkMode = default,
            string? environmentId = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}