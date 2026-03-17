
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response from the model for a grounded answer.
    /// </summary>
    public sealed partial class GenerateAnswerResponse
    {
        /// <summary>
        /// A response candidate generated from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public global::Google.Gemini.Candidate? Answer { get; set; }

        /// <summary>
        /// Output only. The model's estimate of the probability that its answer is correct and grounded in the input passages. A low `answerable_probability` indicates that the answer might not be grounded in the sources. When `answerable_probability` is low, you may want to: * Display a message to the effect of "We couldn’t answer that question" to the user. * Fall back to a general-purpose LLM that answers the question from world knowledge. The threshold and nature of such fallbacks will depend on individual use cases. `0.5` is a good starting threshold.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerableProbability")]
        public float? AnswerableProbability { get; set; }

        /// <summary>
        /// Feedback related to the input data used to answer the question, as opposed to the model-generated response to the question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputFeedback")]
        public global::Google.Gemini.InputFeedback? InputFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAnswerResponse" /> class.
        /// </summary>
        /// <param name="answer">
        /// A response candidate generated from the model.
        /// </param>
        /// <param name="answerableProbability">
        /// Output only. The model's estimate of the probability that its answer is correct and grounded in the input passages. A low `answerable_probability` indicates that the answer might not be grounded in the sources. When `answerable_probability` is low, you may want to: * Display a message to the effect of "We couldn’t answer that question" to the user. * Fall back to a general-purpose LLM that answers the question from world knowledge. The threshold and nature of such fallbacks will depend on individual use cases. `0.5` is a good starting threshold.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputFeedback">
        /// Feedback related to the input data used to answer the question, as opposed to the model-generated response to the question.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateAnswerResponse(
            global::Google.Gemini.Candidate? answer,
            float? answerableProbability,
            global::Google.Gemini.InputFeedback? inputFeedback)
        {
            this.Answer = answer;
            this.AnswerableProbability = answerableProbability;
            this.InputFeedback = inputFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAnswerResponse" /> class.
        /// </summary>
        public GenerateAnswerResponse()
        {
        }
    }
}