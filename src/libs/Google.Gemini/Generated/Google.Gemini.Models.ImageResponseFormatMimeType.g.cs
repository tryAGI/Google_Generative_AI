
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The MIME type of the image output.
    /// </summary>
    public enum ImageResponseFormatMimeType
    {
        /// <summary>
        /// JPEG image format.
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        MimeTypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseFormatMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseFormatMimeType value)
        {
            return value switch
            {
                ImageResponseFormatMimeType.ImageJpeg => "IMAGE_JPEG",
                ImageResponseFormatMimeType.MimeTypeUnspecified => "MIME_TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseFormatMimeType? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_JPEG" => ImageResponseFormatMimeType.ImageJpeg,
                "MIME_TYPE_UNSPECIFIED" => ImageResponseFormatMimeType.MimeTypeUnspecified,
                _ => null,
            };
        }
    }
}