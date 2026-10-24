
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An image content block.
    /// </summary>
    public sealed partial class ImageContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The image content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// The URI of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.MediaResolutionJsonConverter))]
        public global::Google.Gemini.NextGen.MediaResolution? Resolution { get; set; }

        /// <summary>
        /// The mime type of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageContentMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.ImageContentMimeType? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data">
        /// The image content.
        /// </param>
        /// <param name="uri">
        /// The URI of the image.
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="mimeType">
        /// The mime type of the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageContent(
            object type,
            byte[]? data,
            string? uri,
            global::Google.Gemini.NextGen.MediaResolution? resolution,
            global::Google.Gemini.NextGen.ImageContentMimeType? mimeType)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Data = data;
            this.Uri = uri;
            this.Resolution = resolution;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        public ImageContent()
        {
        }

    }
}