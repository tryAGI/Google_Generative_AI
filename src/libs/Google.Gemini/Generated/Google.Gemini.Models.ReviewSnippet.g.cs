
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Encapsulates a snippet of a user review that answers a question about the features of a specific place in Google Maps.
    /// </summary>
    public sealed partial class ReviewSnippet
    {
        /// <summary>
        /// Title of the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The ID of the review snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewId")]
        public string? ReviewId { get; set; }

        /// <summary>
        /// A link that corresponds to the user review on Google Maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("googleMapsUri")]
        public string? GoogleMapsUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSnippet" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the review.
        /// </param>
        /// <param name="reviewId">
        /// The ID of the review snippet.
        /// </param>
        /// <param name="googleMapsUri">
        /// A link that corresponds to the user review on Google Maps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSnippet(
            string? title,
            string? reviewId,
            string? googleMapsUri)
        {
            this.Title = title;
            this.ReviewId = reviewId;
            this.GoogleMapsUri = googleMapsUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSnippet" /> class.
        /// </summary>
        public ReviewSnippet()
        {
        }
    }
}