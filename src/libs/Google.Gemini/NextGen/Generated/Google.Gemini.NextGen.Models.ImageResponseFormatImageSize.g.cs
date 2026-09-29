
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The size of the image output.
    /// </summary>
    public enum ImageResponseFormatImageSize
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x512,
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
                ImageResponseFormatImageSize.x1k => "1K",
                ImageResponseFormatImageSize.x2k => "2K",
                ImageResponseFormatImageSize.x4k => "4K",
                ImageResponseFormatImageSize.x512 => "512",
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
                "1K" => ImageResponseFormatImageSize.x1k,
                "2K" => ImageResponseFormatImageSize.x2k,
                "4K" => ImageResponseFormatImageSize.x4k,
                "512" => ImageResponseFormatImageSize.x512,
                _ => null,
            };
        }
    }
}