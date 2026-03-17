
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request to generate a text completion response from the model.
    /// </summary>
    public sealed partial class GenerateTextRequest
    {
        /// <summary>
        /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Google.Gemini.TextPrompt? Prompt { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned the `getModel` function. Values can range from [0.0,1.0], inclusive. A value closer to 1.0 will produce responses that are more varied and creative, while a value closer to 0.0 will typically result in more straightforward responses from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. Number of generated responses to return. This value must be between [1, 8], inclusive. If unset, this will default to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidateCount")]
        public int? CandidateCount { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to include in a candidate. If unset, this will default to output_token_limit specified in the `Model` specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits number of tokens based on the cumulative probability. Note: The default value varies by model, see the `Model.top_p` attribute of the `Model` returned the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Defaults to 40. Note: The default value varies by model, see the `Model.top_k` attribute of the `Model` returned the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. that will be enforced on the `GenerateTextRequest.prompt` and `GenerateTextResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any prompts and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_DEROGATORY, HARM_CATEGORY_TOXICITY, HARM_CATEGORY_VIOLENCE, HARM_CATEGORY_SEXUAL, HARM_CATEGORY_MEDICAL, HARM_CATEGORY_DANGEROUS are supported in text service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetySettings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        /// The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a stop sequence. The stop sequence will not be included as part of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTextRequest(
            global::Google.Gemini.TextPrompt? prompt,
            float? temperature,
            int? candidateCount,
            int? maxOutputTokens,
            float? topP,
            int? topK,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings,
            global::System.Collections.Generic.IList<string>? stopSequences)
        {
            this.Prompt = prompt;
            this.Temperature = temperature;
            this.CandidateCount = candidateCount;
            this.MaxOutputTokens = maxOutputTokens;
            this.TopP = topP;
            this.TopK = topK;
            this.SafetySettings = safetySettings;
            this.StopSequences = stopSequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
        public GenerateTextRequest()
        {
        }
    }
}