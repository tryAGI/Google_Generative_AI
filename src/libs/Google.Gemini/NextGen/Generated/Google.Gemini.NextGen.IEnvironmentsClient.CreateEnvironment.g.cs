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
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Environment> CreateEnvironmentAsync(

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
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Environment>> CreateEnvironmentAsResponseAsync(

            global::Google.Gemini.NextGen.CreateEnvironmentRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an environment.
        /// </summary>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="env">
        /// Environment variables to set in the sandbox environment.
        /// </param>
        /// <param name="mode">
        /// The compute lifecycle mode for this environment.
        /// </param>
        /// <param name="customConfig">
        /// Optional. Arbitrary customer-defined JSON configuration passed through<br/>
        /// to the self-hosted environment poller. Only supported when `mode` is<br/>
        /// `SELF_HOSTED`.
        /// </param>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </param>
        /// <param name="systemInstruction">
        /// Optional. System instruction applied to interactions running in this<br/>
        /// environment. Only supported for `SELF_HOSTED` environments, where it is<br/>
        /// recommended.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Environment> CreateEnvironmentAsync(
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? network = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources = default,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? env = default,
            global::Google.Gemini.NextGen.CreateEnvironmentRequestMode? mode = default,
            object? customConfig = default,
            string? fromEnvironment = default,
            string? systemInstruction = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}