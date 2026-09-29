
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A place citation annotation.
    /// </summary>
    public sealed partial class PlaceCitation
    {
        /// <summary>
        /// End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Title of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the place, in `places/{place_id}` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("place_id")]
        public string? PlaceId { get; set; }

        /// <summary>
        /// Snippets of reviews that are used to generate answers about the<br/>
        /// features of a given place in Google Maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_snippets")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? ReviewSnippets { get; set; }

        /// <summary>
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// URI reference of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endIndex">
        /// End of the attributed segment, exclusive.
        /// </param>
        /// <param name="name">
        /// Title of the place.
        /// </param>
        /// <param name="placeId">
        /// The ID of the place, in `places/{place_id}` format.
        /// </param>
        /// <param name="reviewSnippets">
        /// Snippets of reviews that are used to generate answers about the<br/>
        /// features of a given place in Google Maps.
        /// </param>
        /// <param name="startIndex">
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="url">
        /// URI reference of the place.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaceCitation(
            object type,
            int? endIndex,
            string? name,
            string? placeId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? reviewSnippets,
            int? startIndex,
            string? url)
        {
            this.EndIndex = endIndex;
            this.Name = name;
            this.PlaceId = placeId;
            this.ReviewSnippets = reviewSnippets;
            this.StartIndex = startIndex;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceCitation" /> class.
        /// </summary>
        public PlaceCitation()
        {
        }

    }
}