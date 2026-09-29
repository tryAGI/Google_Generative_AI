
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum MediaResolution
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        UltraHigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaResolution value)
        {
            return value switch
            {
                MediaResolution.High => "high",
                MediaResolution.Low => "low",
                MediaResolution.Medium => "medium",
                MediaResolution.UltraHigh => "ultra_high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaResolution? ToEnum(string value)
        {
            return value switch
            {
                "high" => MediaResolution.High,
                "low" => MediaResolution.Low,
                "medium" => MediaResolution.Medium,
                "ultra_high" => MediaResolution.UltraHigh,
                _ => null,
            };
        }
    }
}