
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The configuration for image interaction.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ImageConfig
    {
        /// <summary>
        /// The aspect ratio of the image to generate. Supported aspect ratios: 1:1,<br/>
        /// 2:3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.<br/>
        /// If not specified, the model will choose a default aspect ratio based on any<br/>
        /// reference images provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigAspectRatioJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.NextGen.ImageConfigAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Specifies the size of generated images. Supported values are `1K`, `2K`,<br/>
        /// `4K`. If not specified, the model will use default value `1K`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigImageSizeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.NextGen.ImageConfigImageSize? ImageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConfig" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the image to generate. Supported aspect ratios: 1:1,<br/>
        /// 2:3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.<br/>
        /// If not specified, the model will choose a default aspect ratio based on any<br/>
        /// reference images provided.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the size of generated images. Supported values are `1K`, `2K`,<br/>
        /// `4K`. If not specified, the model will use default value `1K`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageConfig(
            global::Google.Gemini.NextGen.ImageConfigAspectRatio? aspectRatio,
            global::Google.Gemini.NextGen.ImageConfigImageSize? imageSize)
        {
            this.AspectRatio = aspectRatio;
            this.ImageSize = imageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConfig" /> class.
        /// </summary>
        public ImageConfig()
        {
        }

    }
}