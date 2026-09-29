
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for image output format.
    /// </summary>
    public sealed partial class ImageResponseFormat
    {
        /// <summary>
        /// The aspect ratio for the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatAspectRatioJsonConverter))]
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The delivery mode for the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatDeliveryJsonConverter))]
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Delivery { get; set; }

        /// <summary>
        /// The size of the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatImageSizeJsonConverter))]
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? ImageSize { get; set; }

        /// <summary>
        /// The MIME type of the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="aspectRatio">
        /// The aspect ratio for the image output.
        /// </param>
        /// <param name="delivery">
        /// The delivery mode for the image output.
        /// </param>
        /// <param name="imageSize">
        /// The size of the image output.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the image output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageResponseFormat(
            object type,
            global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? aspectRatio,
            global::Google.Gemini.NextGen.ImageResponseFormatDelivery? delivery,
            global::Google.Gemini.NextGen.ImageResponseFormatImageSize? imageSize,
            global::Google.Gemini.NextGen.ImageResponseFormatMimeType? mimeType)
        {
            this.AspectRatio = aspectRatio;
            this.Delivery = delivery;
            this.ImageSize = imageSize;
            this.MimeType = mimeType;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseFormat" /> class.
        /// </summary>
        public ImageResponseFormat()
        {
        }

    }
}