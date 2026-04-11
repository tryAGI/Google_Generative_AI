
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Safety rating for a piece of content. The safety rating contains the category of harm and the harm probability level in that category for a piece of content. Content is classified for safety across a number of harm categories and the probability of the harm classification is included here.
    /// </summary>
    public sealed partial class SafetyRating
    {
        /// <summary>
        /// Was this content blocked because of this rating?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Required. The category for this rating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryJsonConverter))]
        public global::Google.Gemini.SafetyRatingCategory? Category { get; set; }

        /// <summary>
        /// Required. The probability of harm for this content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityJsonConverter))]
        public global::Google.Gemini.SafetyRatingProbability? Probability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyRating" /> class.
        /// </summary>
        /// <param name="blocked">
        /// Was this content blocked because of this rating?
        /// </param>
        /// <param name="category">
        /// Required. The category for this rating.
        /// </param>
        /// <param name="probability">
        /// Required. The probability of harm for this content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyRating(
            bool? blocked,
            global::Google.Gemini.SafetyRatingCategory? category,
            global::Google.Gemini.SafetyRatingProbability? probability)
        {
            this.Blocked = blocked;
            this.Category = category;
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyRating" /> class.
        /// </summary>
        public SafetyRating()
        {
        }
    }
}