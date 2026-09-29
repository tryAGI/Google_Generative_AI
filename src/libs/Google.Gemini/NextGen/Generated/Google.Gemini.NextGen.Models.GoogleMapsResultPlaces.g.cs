
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoogleMapsResultPlaces
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("place_id")]
        public string? PlaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_snippets")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? ReviewSnippets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultPlaces" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="placeId"></param>
        /// <param name="reviewSnippets"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsResultPlaces(
            string? name,
            string? placeId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? reviewSnippets,
            string? url)
        {
            this.Name = name;
            this.PlaceId = placeId;
            this.ReviewSnippets = reviewSnippets;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultPlaces" /> class.
        /// </summary>
        public GoogleMapsResultPlaces()
        {
        }

    }
}