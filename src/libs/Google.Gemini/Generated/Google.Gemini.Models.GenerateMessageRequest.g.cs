
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request to generate a message response from the model.
    /// </summary>
    public sealed partial class GenerateMessageRequest
    {
        /// <summary>
        /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Google.Gemini.MessagePrompt? Prompt { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. The number of generated response messages to return. This value must be between `[1, 8]`, inclusive. If unset, this will default to `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidateCount")]
        public int? CandidateCount { get; set; }

        /// <summary>
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMessageRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateMessageRequest(
            global::Google.Gemini.MessagePrompt? prompt,
            float? temperature,
            int? candidateCount,
            float? topP,
            int? topK)
        {
            this.Prompt = prompt;
            this.Temperature = temperature;
            this.CandidateCount = candidateCount;
            this.TopP = topP;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMessageRequest" /> class.
        /// </summary>
        public GenerateMessageRequest()
        {
        }
    }
}