#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Runs a model's tokenizer on input `Content` and returns the token count. Refer to the [tokens guide](https://ai.google.dev/gemini-api/docs/tokens) to learn more about tokens.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTokensResponse> ModelsCountTokensAsync(
            string modelsId,

            global::Google.Gemini.CountTokensRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Runs a model's tokenizer on input `Content` and returns the token count. Refer to the [tokens guide](https://ai.google.dev/gemini-api/docs/tokens) to learn more about tokens.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="contents">
        /// Optional. The input given to the model as a prompt. This field is ignored when `generate_content_request` is set.
        /// </param>
        /// <param name="generateContentRequest">
        /// Request to generate a completion from the model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTokensResponse> ModelsCountTokensAsync(
            string modelsId,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::Google.Gemini.GenerateContentRequest? generateContentRequest = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}