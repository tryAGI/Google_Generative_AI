
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Safety feedback for an entire request. This field is populated if content in the input and/or response is blocked due to safety settings. SafetyFeedback may not exist for every HarmCategory. Each SafetyFeedback will return the safety settings used by the request as well as the lowest HarmProbability that should be allowed in order to return a result.
    /// </summary>
    public sealed partial class SafetyFeedback
    {
        /// <summary>
        /// Safety rating for a piece of content. The safety rating contains the category of harm and the harm probability level in that category for a piece of content. Content is classified for safety across a number of harm categories and the probability of the harm classification is included here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public global::Google.Gemini.SafetyRating? Rating { get; set; }

        /// <summary>
        /// Safety setting, affecting the safety-blocking behavior. Passing a safety setting for a category changes the allowed probability that content is blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setting")]
        public global::Google.Gemini.SafetySetting? Setting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyFeedback" /> class.
        /// </summary>
        /// <param name="rating">
        /// Safety rating for a piece of content. The safety rating contains the category of harm and the harm probability level in that category for a piece of content. Content is classified for safety across a number of harm categories and the probability of the harm classification is included here.
        /// </param>
        /// <param name="setting">
        /// Safety setting, affecting the safety-blocking behavior. Passing a safety setting for a category changes the allowed probability that content is blocked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyFeedback(
            global::Google.Gemini.SafetyRating? rating,
            global::Google.Gemini.SafetySetting? setting)
        {
            this.Rating = rating;
            this.Setting = setting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyFeedback" /> class.
        /// </summary>
        public SafetyFeedback()
        {
        }
    }
}