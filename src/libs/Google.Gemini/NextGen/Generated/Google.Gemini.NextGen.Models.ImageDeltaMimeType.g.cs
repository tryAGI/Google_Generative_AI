
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageDeltaMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ImageBmp,
        /// <summary>
        ///
        /// </summary>
        ImageGif,
        /// <summary>
        ///
        /// </summary>
        ImageHeic,
        /// <summary>
        ///
        /// </summary>
        ImageHeif,
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
        /// <summary>
        ///
        /// </summary>
        ImagePng,
        /// <summary>
        ///
        /// </summary>
        ImageTiff,
        /// <summary>
        ///
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageDeltaMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageDeltaMimeType value)
        {
            return value switch
            {
                ImageDeltaMimeType.ImageBmp => "image/bmp",
                ImageDeltaMimeType.ImageGif => "image/gif",
                ImageDeltaMimeType.ImageHeic => "image/heic",
                ImageDeltaMimeType.ImageHeif => "image/heif",
                ImageDeltaMimeType.ImageJpeg => "image/jpeg",
                ImageDeltaMimeType.ImagePng => "image/png",
                ImageDeltaMimeType.ImageTiff => "image/tiff",
                ImageDeltaMimeType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageDeltaMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/bmp" => ImageDeltaMimeType.ImageBmp,
                "image/gif" => ImageDeltaMimeType.ImageGif,
                "image/heic" => ImageDeltaMimeType.ImageHeic,
                "image/heif" => ImageDeltaMimeType.ImageHeif,
                "image/jpeg" => ImageDeltaMimeType.ImageJpeg,
                "image/png" => ImageDeltaMimeType.ImagePng,
                "image/tiff" => ImageDeltaMimeType.ImageTiff,
                "image/webp" => ImageDeltaMimeType.ImageWebp,
                _ => null,
            };
        }
    }
}