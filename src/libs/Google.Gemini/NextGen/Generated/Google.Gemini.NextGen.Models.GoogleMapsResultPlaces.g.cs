
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
        [global::System.Text.Json.Serialization.JsonPropertyName("place_id")]
        public string? PlaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_snippets")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? ReviewSnippets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultPlaces" /> class.
        /// </summary>
        /// <param name="placeId"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="reviewSnippets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsResultPlaces(
            string? placeId,
            string? name,
            string? url,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? reviewSnippets)
        {
            this.PlaceId = placeId;
            this.Name = name;
            this.Url = url;
            this.ReviewSnippets = reviewSnippets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultPlaces" /> class.
        /// </summary>
        public GoogleMapsResultPlaces()
        {
        }

    }
}