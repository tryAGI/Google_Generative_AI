
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Controls text normalization before speech synthesis.
    /// </summary>
    public enum SpeakerConfigTextNormalization
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakerConfigTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakerConfigTextNormalization value)
        {
            return value switch
            {
                SpeakerConfigTextNormalization.Auto => "auto",
                SpeakerConfigTextNormalization.Disabled => "disabled",
                SpeakerConfigTextNormalization.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakerConfigTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SpeakerConfigTextNormalization.Auto,
                "disabled" => SpeakerConfigTextNormalization.Disabled,
                "enabled" => SpeakerConfigTextNormalization.Enabled,
                _ => null,
            };
        }
    }
}