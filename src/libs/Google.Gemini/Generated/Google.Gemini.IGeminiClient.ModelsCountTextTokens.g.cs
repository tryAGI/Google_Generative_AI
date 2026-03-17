#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Runs a model's tokenizer on a text and returns the token count.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTextTokensResponse> ModelsCountTextTokensAsync(
            string modelsId,

            global::Google.Gemini.CountTextTokensRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Runs a model's tokenizer on a text and returns the token count.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="prompt">
        /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTextTokensResponse> ModelsCountTextTokensAsync(
            string modelsId,
            global::Google.Gemini.TextPrompt? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}