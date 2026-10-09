#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/environments \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "sources": [{<br/>
        ///       "type": "inline",<br/>
        ///       "target": "main.py",<br/>
        ///       "content": "print(\"Hello, World!\")"<br/>
        ///     }]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Environment2> CreateEnvironmentAsync(

            global::Google.Gemini.NextGen.CreateEnvironmentRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/environments \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "sources": [{<br/>
        ///       "type": "inline",<br/>
        ///       "target": "main.py",<br/>
        ///       "content": "print(\"Hello, World!\")"<br/>
        ///     }]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Environment2>> CreateEnvironmentAsResponseAsync(

            global::Google.Gemini.NextGen.CreateEnvironmentRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </param>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Environment2> CreateEnvironmentAsync(
            string? fromEnvironment = default,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? network = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}