#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Generates a grounded answer from the model given an input `GenerateAnswerRequest`.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateAnswerResponse> ModelsGenerateAnswerAsync(
            string modelsId,

            global::Google.Gemini.GenerateAnswerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a grounded answer from the model given an input `GenerateAnswerRequest`.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="inlinePassages">
        /// A repeated list of passages.
        /// </param>
        /// <param name="semanticRetriever">
        /// Configuration for retrieving grounding content from a `Corpus` or `Document` created using the Semantic Retriever API.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the `Model`. For single-turn queries, this is a single question to answer. For multi-turn queries, this is a repeated field that contains conversation history and the last `Content` in the list containing the question. Note: `GenerateAnswer` only supports queries in English.
        /// </param>
        /// <param name="answerStyle">
        /// Required. Style in which answers should be returned.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateAnswerRequest.contents` and `GenerateAnswerResponse.candidate`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Values can range from [0.0,1.0], inclusive. A value closer to 1.0 will produce responses that are more varied and creative, while a value closer to 0.0 will typically result in more straightforward responses from the model. A low temperature (~0.2) is usually recommended for Attributed-Question-Answering use cases.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateAnswerResponse> ModelsGenerateAnswerAsync(
            string modelsId,
            global::Google.Gemini.GroundingPassages? inlinePassages = default,
            global::Google.Gemini.SemanticRetrieverConfig? semanticRetriever = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::Google.Gemini.GenerateAnswerRequestAnswerStyle? answerStyle = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings = default,
            float? temperature = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}