#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Runs a model's tokenizer on input content and returns the token count.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: gemini-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTokensResponse> CountTokensAsync(
            string modelId,
            global::Google.Gemini.CountTokensRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Runs a model's tokenizer on input content and returns the token count.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: gemini-pro
        /// </param>
        /// <param name="contents">
        /// Required. The input given to the model as a prompt.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountTokensResponse> CountTokensAsync(
            string modelId,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}