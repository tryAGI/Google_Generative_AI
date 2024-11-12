
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response from the model supporting multiple candidates. Note on safety ratings and content filtering. They are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API contract is that: - either all requested candidates are returned or no candidates at all - no candidates are returned only if there was something wrong with the prompt (see `prompt_feedback`) - feedback on each candidate is reported on `finish_reason` and `safety_ratings`.
    /// </summary>
    public sealed partial class GenerateContentResponse
    {
        /// <summary>
        /// Candidate responses from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Candidates { get; set; }

        /// <summary>
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptFeedback")]
        public global::Google.Gemini.PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Candidate responses from the model.
        /// </param>
        /// <param name="promptFeedback">
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerateContentResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? candidates,
            global::Google.Gemini.PromptFeedback? promptFeedback)
        {
            this.Candidates = candidates;
            this.PromptFeedback = promptFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        public GenerateContentResponse()
        {
        }
    }
}