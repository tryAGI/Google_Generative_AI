#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Generates a response from the model given an input message.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateTextResponse> TunedModelsGenerateTextAsync(
            string tunedModelsId,

            global::Google.Gemini.GenerateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a response from the model given an input message.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="prompt">
        /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned the `getModel` function. Values can range from [0.0,1.0], inclusive. A value closer to 1.0 will produce responses that are more varied and creative, while a value closer to 0.0 will typically result in more straightforward responses from the model.
        /// </param>
        /// <param name="candidateCount">
        /// Optional. Number of generated responses to return. This value must be between [1, 8], inclusive. If unset, this will default to 1.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Optional. The maximum number of tokens to include in a candidate. If unset, this will default to output_token_limit specified in the `Model` specification.
        /// </param>
        /// <param name="topP">
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits number of tokens based on the cumulative probability. Note: The default value varies by model, see the `Model.top_p` attribute of the `Model` returned the `getModel` function.
        /// </param>
        /// <param name="topK">
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Defaults to 40. Note: The default value varies by model, see the `Model.top_k` attribute of the `Model` returned the `getModel` function.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. that will be enforced on the `GenerateTextRequest.prompt` and `GenerateTextResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any prompts and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_DEROGATORY, HARM_CATEGORY_TOXICITY, HARM_CATEGORY_VIOLENCE, HARM_CATEGORY_SEXUAL, HARM_CATEGORY_MEDICAL, HARM_CATEGORY_DANGEROUS are supported in text service.
        /// </param>
        /// <param name="stopSequences">
        /// The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a stop sequence. The stop sequence will not be included as part of the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateTextResponse> TunedModelsGenerateTextAsync(
            string tunedModelsId,
            global::Google.Gemini.TextPrompt? prompt = default,
            float? temperature = default,
            int? candidateCount = default,
            int? maxOutputTokens = default,
            float? topP = default,
            int? topK = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}