
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. If specified, the media resolution specified will be used.
    /// </summary>
    public enum GenerationConfigMediaResolution
    {
        /// <summary>
        /// Media resolution has not been set.
        /// </summary>
        MediaResolutionUnspecified,
        /// <summary>
        /// Media resolution set to low (64 tokens).
        /// </summary>
        MediaResolutionLow,
        /// <summary>
        /// Media resolution set to medium (256 tokens).
        /// </summary>
        MediaResolutionMedium,
        /// <summary>
        /// Media resolution set to high (zoomed reframing with 256 tokens).
        /// </summary>
        MediaResolutionHigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationConfigMediaResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationConfigMediaResolution value)
        {
            return value switch
            {
                GenerationConfigMediaResolution.MediaResolutionUnspecified => "MEDIA_RESOLUTION_UNSPECIFIED",
                GenerationConfigMediaResolution.MediaResolutionLow => "MEDIA_RESOLUTION_LOW",
                GenerationConfigMediaResolution.MediaResolutionMedium => "MEDIA_RESOLUTION_MEDIUM",
                GenerationConfigMediaResolution.MediaResolutionHigh => "MEDIA_RESOLUTION_HIGH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationConfigMediaResolution? ToEnum(string value)
        {
            return value switch
            {
                "MEDIA_RESOLUTION_UNSPECIFIED" => GenerationConfigMediaResolution.MediaResolutionUnspecified,
                "MEDIA_RESOLUTION_LOW" => GenerationConfigMediaResolution.MediaResolutionLow,
                "MEDIA_RESOLUTION_MEDIUM" => GenerationConfigMediaResolution.MediaResolutionMedium,
                "MEDIA_RESOLUTION_HIGH" => GenerationConfigMediaResolution.MediaResolutionHigh,
                _ => null,
            };
        }
    }
}