
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Specifies the size of generated images. Supported values are `1K`, `2K`,<br/>
    /// `4K`. If not specified, the model will use default value `1K`.
    /// </summary>
    public enum ImageConfigImageSize
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
    public static class ImageConfigImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageConfigImageSize value)
        {
            return value switch
            {
                ImageConfigImageSize.x1k => "1K",
                ImageConfigImageSize.x2k => "2K",
                ImageConfigImageSize.x4k => "4K",
                ImageConfigImageSize.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageConfigImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1K" => ImageConfigImageSize.x1k,
                "2K" => ImageConfigImageSize.x2k,
                "4K" => ImageConfigImageSize.x4k,
                "512" => ImageConfigImageSize.x512,
                _ => null,
            };
        }
    }
}