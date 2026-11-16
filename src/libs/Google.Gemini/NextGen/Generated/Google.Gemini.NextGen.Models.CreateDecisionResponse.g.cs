
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The response from evaluating a batch of decision questions.
    /// </summary>
    public sealed partial class CreateDecisionResponse
    {
        /// <summary>
        /// Output only. Decision answers keyed by the question identifiers from `questions`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Answer>? Answers { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Google.Gemini.NextGen.Usage? Usage { get; set; }

        /// <summary>
        /// Feedback from input content filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_feedback")]
        public global::Google.Gemini.NextGen.PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionResponse" /> class.
        /// </summary>
        /// <param name="answers">
        /// Output only. Decision answers keyed by the question identifiers from `questions`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.
        /// </param>
        /// <param name="promptFeedback">
        /// Feedback from input content filters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDecisionResponse(
            global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Answer>? answers,
            global::Google.Gemini.NextGen.Usage? usage,
            global::Google.Gemini.NextGen.PromptFeedback? promptFeedback)
        {
            this.Answers = answers;
            this.Usage = usage;
            this.PromptFeedback = promptFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionResponse" /> class.
        /// </summary>
        public CreateDecisionResponse()
        {
        }

    }
}