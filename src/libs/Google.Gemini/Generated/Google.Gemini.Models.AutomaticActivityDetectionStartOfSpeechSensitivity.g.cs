
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Determines how likely speech is to be detected.
    /// </summary>
    public enum AutomaticActivityDetectionStartOfSpeechSensitivity
    {
        /// <summary>
        /// Automatic detection will detect the start of speech more often.
        /// </summary>
        StartSensitivityHigh,
        /// <summary>
        /// Automatic detection will detect the start of speech less often.
        /// </summary>
        StartSensitivityLow,
        /// <summary>
        /// The default is START_SENSITIVITY_HIGH.
        /// </summary>
        StartSensitivityUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomaticActivityDetectionStartOfSpeechSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomaticActivityDetectionStartOfSpeechSensitivity value)
        {
            return value switch
            {
                AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityHigh => "START_SENSITIVITY_HIGH",
                AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityLow => "START_SENSITIVITY_LOW",
                AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityUnspecified => "START_SENSITIVITY_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomaticActivityDetectionStartOfSpeechSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "START_SENSITIVITY_HIGH" => AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityHigh,
                "START_SENSITIVITY_LOW" => AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityLow,
                "START_SENSITIVITY_UNSPECIFIED" => AutomaticActivityDetectionStartOfSpeechSensitivity.StartSensitivityUnspecified,
                _ => null,
            };
        }
    }
}