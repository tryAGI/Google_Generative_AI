
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Chunk from image search.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// The title of the web page that the image is from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The image asset URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// The web page URI for attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUri")]
        public string? SourceUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the web page that the image is from.
        /// </param>
        /// <param name="domain">
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </param>
        /// <param name="imageUri">
        /// The image asset URL.
        /// </param>
        /// <param name="sourceUri">
        /// The web page URI for attribution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Image(
            string? title,
            string? domain,
            string? imageUri,
            string? sourceUri)
        {
            this.Title = title;
            this.Domain = domain;
            this.ImageUri = imageUri;
            this.SourceUri = sourceUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}