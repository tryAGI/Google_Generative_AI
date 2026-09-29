
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A URL citation annotation.
    /// </summary>
    public sealed partial class URLCitation
    {
        /// <summary>
        /// End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The title of the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endIndex">
        /// End of the attributed segment, exclusive.
        /// </param>
        /// <param name="startIndex">
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="title">
        /// The title of the URL.
        /// </param>
        /// <param name="url">
        /// The URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public URLCitation(
            object type,
            int? endIndex,
            int? startIndex,
            string? title,
            string? url)
        {
            this.EndIndex = endIndex;
            this.StartIndex = startIndex;
            this.Title = title;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLCitation" /> class.
        /// </summary>
        public URLCitation()
        {
        }

    }
}