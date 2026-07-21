
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The tokenization quality used for given media. for Gemini API support .
    /// </summary>
    public enum V1mainMediaResolutionLevel
    {
        /// <summary>
        /// Media resolution set to high.
        /// </summary>
        MediaResolutionHigh,
        /// <summary>
        /// Media resolution set to low.
        /// </summary>
        MediaResolutionLow,
        /// <summary>
        /// Media resolution set to medium.
        /// </summary>
        MediaResolutionMedium,
        /// <summary>
        /// Media resolution set to ultra high.
        /// </summary>
        MediaResolutionUltraHigh,
        /// <summary>
        /// Media resolution has not been set.
        /// </summary>
        MediaResolutionUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1mainMediaResolutionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1mainMediaResolutionLevel value)
        {
            return value switch
            {
                V1mainMediaResolutionLevel.MediaResolutionHigh => "MEDIA_RESOLUTION_HIGH",
                V1mainMediaResolutionLevel.MediaResolutionLow => "MEDIA_RESOLUTION_LOW",
                V1mainMediaResolutionLevel.MediaResolutionMedium => "MEDIA_RESOLUTION_MEDIUM",
                V1mainMediaResolutionLevel.MediaResolutionUltraHigh => "MEDIA_RESOLUTION_ULTRA_HIGH",
                V1mainMediaResolutionLevel.MediaResolutionUnspecified => "MEDIA_RESOLUTION_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1mainMediaResolutionLevel? ToEnum(string value)
        {
            return value switch
            {
                "MEDIA_RESOLUTION_HIGH" => V1mainMediaResolutionLevel.MediaResolutionHigh,
                "MEDIA_RESOLUTION_LOW" => V1mainMediaResolutionLevel.MediaResolutionLow,
                "MEDIA_RESOLUTION_MEDIUM" => V1mainMediaResolutionLevel.MediaResolutionMedium,
                "MEDIA_RESOLUTION_ULTRA_HIGH" => V1mainMediaResolutionLevel.MediaResolutionUltraHigh,
                "MEDIA_RESOLUTION_UNSPECIFIED" => V1mainMediaResolutionLevel.MediaResolutionUnspecified,
                _ => null,
            };
        }
    }
}