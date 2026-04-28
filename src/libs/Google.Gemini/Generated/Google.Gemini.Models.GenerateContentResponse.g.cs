
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response from the model supporting multiple candidate responses. Safety ratings and content filtering are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API: - Returns either all requested candidates or none of them - Returns no candidates at all only if there was something wrong with the prompt (check `prompt_feedback`) - Reports feedback on each candidate in `finish_reason` and `safety_ratings`.
    /// </summary>
    public sealed partial class GenerateContentResponse
    {
        /// <summary>
        /// Metadata on the generation request's token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageMetadata")]
        public global::Google.Gemini.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Output only. response_id is used to identify each response.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseId")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The status of the underlying model. This is used to indicate the stage of the underlying model and the retirement time if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelStatus")]
        public global::Google.Gemini.ModelStatus? ModelStatus { get; set; }

        /// <summary>
        /// Output only. The model version used to generate the response.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptFeedback")]
        public global::Google.Gemini.PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// Candidate responses from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        /// <param name="usageMetadata">
        /// Metadata on the generation request's token usage.
        /// </param>
        /// <param name="responseId">
        /// Output only. response_id is used to identify each response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modelStatus">
        /// The status of the underlying model. This is used to indicate the stage of the underlying model and the retirement time if applicable.
        /// </param>
        /// <param name="modelVersion">
        /// Output only. The model version used to generate the response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="promptFeedback">
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </param>
        /// <param name="candidates">
        /// Candidate responses from the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentResponse(
            global::Google.Gemini.UsageMetadata? usageMetadata,
            string? responseId,
            global::Google.Gemini.ModelStatus? modelStatus,
            string? modelVersion,
            global::Google.Gemini.PromptFeedback? promptFeedback,
            global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? candidates)
        {
            this.UsageMetadata = usageMetadata;
            this.ResponseId = responseId;
            this.ModelStatus = modelStatus;
            this.ModelVersion = modelVersion;
            this.PromptFeedback = promptFeedback;
            this.Candidates = candidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        public GenerateContentResponse()
        {
        }
    }
}