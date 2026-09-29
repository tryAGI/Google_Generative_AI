
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The video output resolution. Defaults to 720p.
    /// </summary>
    public enum VideoResponseFormatResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x360p,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseFormatResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseFormatResolution value)
        {
            return value switch
            {
                VideoResponseFormatResolution.x1080p => "1080p",
                VideoResponseFormatResolution.x360p => "360p",
                VideoResponseFormatResolution.x4k => "4k",
                VideoResponseFormatResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseFormatResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => VideoResponseFormatResolution.x1080p,
                "360p" => VideoResponseFormatResolution.x360p,
                "4k" => VideoResponseFormatResolution.x4k,
                "720p" => VideoResponseFormatResolution.x720p,
                _ => null,
            };
        }
    }
}