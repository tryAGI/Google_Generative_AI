
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Controls text normalization before speech synthesis.
    /// </summary>
    public enum SpeechConfigTextNormalization
    {
        /// <summary>
        /// Automatically determines whether to apply text normalization based on the model and speech mode.
        /// </summary>
        Auto,
        /// <summary>
        /// Disables text normalization for pre-normalized or phonetic inputs.
        /// </summary>
        Disabled,
        /// <summary>
        /// Enables text normalization for numbers, currencies, dates, and units.
        /// </summary>
        Enabled,
        /// <summary>
        /// Unspecified text normalization mode. Defaults to `AUTO`.
        /// </summary>
        TextNormalizationUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechConfigTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechConfigTextNormalization value)
        {
            return value switch
            {
                SpeechConfigTextNormalization.Auto => "AUTO",
                SpeechConfigTextNormalization.Disabled => "DISABLED",
                SpeechConfigTextNormalization.Enabled => "ENABLED",
                SpeechConfigTextNormalization.TextNormalizationUnspecified => "TEXT_NORMALIZATION_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechConfigTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => SpeechConfigTextNormalization.Auto,
                "DISABLED" => SpeechConfigTextNormalization.Disabled,
                "ENABLED" => SpeechConfigTextNormalization.Enabled,
                "TEXT_NORMALIZATION_UNSPECIFIED" => SpeechConfigTextNormalization.TextNormalizationUnspecified,
                _ => null,
            };
        }
    }
}