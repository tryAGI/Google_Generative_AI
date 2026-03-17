
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request to generate a grounded answer from the `Model`.
    /// </summary>
    public sealed partial class GenerateAnswerRequest
    {
        /// <summary>
        /// A repeated list of passages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlinePassages")]
        public global::Google.Gemini.GroundingPassages? InlinePassages { get; set; }

        /// <summary>
        /// Configuration for retrieving grounding content from a `Corpus` or `Document` created using the Semantic Retriever API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semanticRetriever")]
        public global::Google.Gemini.SemanticRetrieverConfig? SemanticRetriever { get; set; }

        /// <summary>
        /// Required. The content of the current conversation with the `Model`. For single-turn queries, this is a single question to answer. For multi-turn queries, this is a repeated field that contains conversation history and the last `Content` in the list containing the question. Note: `GenerateAnswer` only supports queries in English.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Contents { get; set; }

        /// <summary>
        /// Required. Style in which answers should be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.GenerateAnswerRequestAnswerStyleJsonConverter))]
        public global::Google.Gemini.GenerateAnswerRequestAnswerStyle? AnswerStyle { get; set; }

        /// <summary>
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateAnswerRequest.contents` and `GenerateAnswerResponse.candidate`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetySettings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. Values can range from [0.0,1.0], inclusive. A value closer to 1.0 will produce responses that are more varied and creative, while a value closer to 0.0 will typically result in more straightforward responses from the model. A low temperature (~0.2) is usually recommended for Attributed-Question-Answering use cases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAnswerRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateAnswerRequest(
            global::Google.Gemini.GroundingPassages? inlinePassages,
            global::Google.Gemini.SemanticRetrieverConfig? semanticRetriever,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents,
            global::Google.Gemini.GenerateAnswerRequestAnswerStyle? answerStyle,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings,
            float? temperature)
        {
            this.InlinePassages = inlinePassages;
            this.SemanticRetriever = semanticRetriever;
            this.Contents = contents;
            this.AnswerStyle = answerStyle;
            this.SafetySettings = safetySettings;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAnswerRequest" /> class.
        /// </summary>
        public GenerateAnswerRequest()
        {
        }
    }
}