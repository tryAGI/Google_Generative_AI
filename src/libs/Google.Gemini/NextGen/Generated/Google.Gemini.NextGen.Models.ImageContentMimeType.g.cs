
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mime type of the image.
    /// </summary>
    public enum ImageContentMimeType
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
    public static class ImageContentMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageContentMimeType value)
        {
            return value switch
            {
                ImageContentMimeType.ImageBmp => "image/bmp",
                ImageContentMimeType.ImageGif => "image/gif",
                ImageContentMimeType.ImageHeic => "image/heic",
                ImageContentMimeType.ImageHeif => "image/heif",
                ImageContentMimeType.ImageJpeg => "image/jpeg",
                ImageContentMimeType.ImagePng => "image/png",
                ImageContentMimeType.ImageTiff => "image/tiff",
                ImageContentMimeType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageContentMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/bmp" => ImageContentMimeType.ImageBmp,
                "image/gif" => ImageContentMimeType.ImageGif,
                "image/heic" => ImageContentMimeType.ImageHeic,
                "image/heif" => ImageContentMimeType.ImageHeif,
                "image/jpeg" => ImageContentMimeType.ImageJpeg,
                "image/png" => ImageContentMimeType.ImagePng,
                "image/tiff" => ImageContentMimeType.ImageTiff,
                "image/webp" => ImageContentMimeType.ImageWebp,
                _ => null,
            };
        }
    }
}