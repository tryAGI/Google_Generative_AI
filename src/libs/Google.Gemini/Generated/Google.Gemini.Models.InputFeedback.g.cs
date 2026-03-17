
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Feedback related to the input data used to answer the question, as opposed to the model-generated response to the question.
    /// </summary>
    public sealed partial class InputFeedback
    {
        /// <summary>
        /// Optional. If set, the input was blocked and no candidates are returned. Rephrase the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.InputFeedbackBlockReasonJsonConverter))]
        public global::Google.Gemini.InputFeedbackBlockReason? BlockReason { get; set; }

        /// <summary>
        /// Ratings for safety of the input. There is at most one rating per category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetyRatings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFeedback" /> class.
        /// </summary>
        /// <param name="blockReason">
        /// Optional. If set, the input was blocked and no candidates are returned. Rephrase the input.
        /// </param>
        /// <param name="safetyRatings">
        /// Ratings for safety of the input. There is at most one rating per category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFeedback(
            global::Google.Gemini.InputFeedbackBlockReason? blockReason,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? safetyRatings)
        {
            this.BlockReason = blockReason;
            this.SafetyRatings = safetyRatings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFeedback" /> class.
        /// </summary>
        public InputFeedback()
        {
        }
    }
}