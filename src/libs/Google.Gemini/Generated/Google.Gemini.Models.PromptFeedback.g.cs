
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
    /// </summary>
    public sealed partial class PromptFeedback
    {
        /// <summary>
        /// Ratings for safety of the prompt. There is at most one rating per category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetyRatings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonJsonConverter))]
        public global::Google.Gemini.PromptFeedbackBlockReason? BlockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        /// <param name="safetyRatings">
        /// Ratings for safety of the prompt. There is at most one rating per category.
        /// </param>
        /// <param name="blockReason">
        /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptFeedback(
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? safetyRatings,
            global::Google.Gemini.PromptFeedbackBlockReason? blockReason)
        {
            this.SafetyRatings = safetyRatings;
            this.BlockReason = blockReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        public PromptFeedback()
        {
        }
    }
}