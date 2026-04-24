
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Chunk from image search.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// The web page URI for attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUri")]
        public string? SourceUri { get; set; }

        /// <summary>
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The title of the web page that the image is from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The image asset URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="sourceUri">
        /// The web page URI for attribution.
        /// </param>
        /// <param name="domain">
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </param>
        /// <param name="title">
        /// The title of the web page that the image is from.
        /// </param>
        /// <param name="imageUri">
        /// The image asset URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Image(
            string? sourceUri,
            string? domain,
            string? title,
            string? imageUri)
        {
            this.SourceUri = sourceUri;
            this.Domain = domain;
            this.Title = title;
            this.ImageUri = imageUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}