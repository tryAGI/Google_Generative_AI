#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Runs a model's tokenizer on a string and returns the token count.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountMessageTokensResponse> ModelsCountMessageTokensAsync(
            string modelsId,

            global::Google.Gemini.CountMessageTokensRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Runs a model's tokenizer on a string and returns the token count.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="prompt">
        /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CountMessageTokensResponse> ModelsCountMessageTokensAsync(
            string modelsId,
            global::Google.Gemini.MessagePrompt? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}