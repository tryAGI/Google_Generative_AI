#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific `Model` such as its version number, token limits, [parameters](https://ai.google.dev/gemini-api/docs/models/generative-models#model-parameters) and other metadata. Refer to the [Gemini models guide](https://ai.google.dev/gemini-api/docs/models/gemini) for detailed model information.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Model> ModelsGetAsync(
            string modelsId,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}