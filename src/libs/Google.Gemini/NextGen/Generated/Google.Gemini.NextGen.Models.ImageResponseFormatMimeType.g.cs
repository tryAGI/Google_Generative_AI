
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The MIME type of the image output.
    /// </summary>
    public enum ImageResponseFormatMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
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
                ImageResponseFormatMimeType.ImageJpeg => "image/jpeg",
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
                "image/jpeg" => ImageResponseFormatMimeType.ImageJpeg,
                _ => null,
            };
        }
    }
}