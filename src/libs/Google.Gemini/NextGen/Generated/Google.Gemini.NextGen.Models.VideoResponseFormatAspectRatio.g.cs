
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The aspect ratio for the video output.
    /// </summary>
    public enum VideoResponseFormatAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseFormatAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseFormatAspectRatio value)
        {
            return value switch
            {
                VideoResponseFormatAspectRatio.x16_9 => "16:9",
                VideoResponseFormatAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseFormatAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => VideoResponseFormatAspectRatio.x16_9,
                "9:16" => VideoResponseFormatAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}