
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Encapsulates a snippet of a user review that answers a question about<br/>
    /// the features of a specific place in Google Maps.
    /// </summary>
    public sealed partial class ReviewSnippet
    {
        /// <summary>
        /// The ID of the review snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_id")]
        public string? ReviewId { get; set; }

        /// <summary>
        /// Title of the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A link that corresponds to the user review on Google Maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSnippet" /> class.
        /// </summary>
        /// <param name="reviewId">
        /// The ID of the review snippet.
        /// </param>
        /// <param name="title">
        /// Title of the review.
        /// </param>
        /// <param name="url">
        /// A link that corresponds to the user review on Google Maps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSnippet(
            string? reviewId,
            string? title,
            string? url)
        {
            this.ReviewId = reviewId;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSnippet" /> class.
        /// </summary>
        public ReviewSnippet()
        {
        }

    }
}