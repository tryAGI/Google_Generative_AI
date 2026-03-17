#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Generates a response from the model given an input `MessagePrompt`.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateMessageResponse> ModelsGenerateMessageAsync(
            string modelsId,

            global::Google.Gemini.GenerateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a response from the model given an input `MessagePrompt`.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="prompt">
        /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model.
        /// </param>
        /// <param name="candidateCount">
        /// Optional. The number of generated response messages to return. This value must be between `[1, 8]`, inclusive. If unset, this will default to `1`.
        /// </param>
        /// <param name="topP">
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`.
        /// </param>
        /// <param name="topK">
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateMessageResponse> ModelsGenerateMessageAsync(
            string modelsId,
            global::Google.Gemini.MessagePrompt? prompt = default,
            float? temperature = default,
            int? candidateCount = default,
            float? topP = default,
            int? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}