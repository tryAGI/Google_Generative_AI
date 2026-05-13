
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The size of the image output.
    /// </summary>
    public enum ImageResponseFormatImageSize
    {
        /// <summary>
        /// 512px image size.
        /// </summary>
        ImageSizeFiveTwelve,
        /// <summary>
        /// 4K image size.
        /// </summary>
        ImageSizeFourK,
        /// <summary>
        /// 1K image size.
        /// </summary>
        ImageSizeOneK,
        /// <summary>
        /// 2K image size.
        /// </summary>
        ImageSizeTwoK,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        ImageSizeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseFormatImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseFormatImageSize value)
        {
            return value switch
            {
                ImageResponseFormatImageSize.ImageSizeFiveTwelve => "IMAGE_SIZE_FIVE_TWELVE",
                ImageResponseFormatImageSize.ImageSizeFourK => "IMAGE_SIZE_FOUR_K",
                ImageResponseFormatImageSize.ImageSizeOneK => "IMAGE_SIZE_ONE_K",
                ImageResponseFormatImageSize.ImageSizeTwoK => "IMAGE_SIZE_TWO_K",
                ImageResponseFormatImageSize.ImageSizeUnspecified => "IMAGE_SIZE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseFormatImageSize? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_SIZE_FIVE_TWELVE" => ImageResponseFormatImageSize.ImageSizeFiveTwelve,
                "IMAGE_SIZE_FOUR_K" => ImageResponseFormatImageSize.ImageSizeFourK,
                "IMAGE_SIZE_ONE_K" => ImageResponseFormatImageSize.ImageSizeOneK,
                "IMAGE_SIZE_TWO_K" => ImageResponseFormatImageSize.ImageSizeTwoK,
                "IMAGE_SIZE_UNSPECIFIED" => ImageResponseFormatImageSize.ImageSizeUnspecified,
                _ => null,
            };
        }
    }
}