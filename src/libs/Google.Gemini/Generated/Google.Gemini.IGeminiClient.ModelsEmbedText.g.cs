#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Generates an embedding from the model given an input message.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EmbedTextResponse> ModelsEmbedTextAsync(
            string modelsId,

            global::Google.Gemini.EmbedTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates an embedding from the model given an input message.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="model">
        /// Required. The model name to use with the format model=models/{model}.
        /// </param>
        /// <param name="text">
        /// Optional. The free-form input text that the model will turn into an embedding.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EmbedTextResponse> ModelsEmbedTextAsync(
            string modelsId,
            string? model = default,
            string? text = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}