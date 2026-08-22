
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for image output format.
    /// </summary>
    public sealed partial class ImageResponseFormat
    {
        /// <summary>
        /// Optional. The aspect ratio for the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ImageResponseFormatAspectRatioJsonConverter))]
        public global::Google.Gemini.ImageResponseFormatAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Optional. The MIME type of the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ImageResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.ImageResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// Optional. The delivery mode for the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ImageResponseFormatDeliveryJsonConverter))]
        public global::Google.Gemini.ImageResponseFormatDelivery? Delivery { get; set; }

        /// <summary>
        /// Optional. The size of the image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageSize")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ImageResponseFormatImageSizeJsonConverter))]
        public global::Google.Gemini.ImageResponseFormatImageSize? ImageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseFormat" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Optional. The aspect ratio for the image output.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The MIME type of the image output.
        /// </param>
        /// <param name="delivery">
        /// Optional. The delivery mode for the image output.
        /// </param>
        /// <param name="imageSize">
        /// Optional. The size of the image output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageResponseFormat(
            global::Google.Gemini.ImageResponseFormatAspectRatio? aspectRatio,
            global::Google.Gemini.ImageResponseFormatMimeType? mimeType,
            global::Google.Gemini.ImageResponseFormatDelivery? delivery,
            global::Google.Gemini.ImageResponseFormatImageSize? imageSize)
        {
            this.AspectRatio = aspectRatio;
            this.MimeType = mimeType;
            this.Delivery = delivery;
            this.ImageSize = imageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseFormat" /> class.
        /// </summary>
        public ImageResponseFormat()
        {
        }

    }
}