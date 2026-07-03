
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Determines how likely detected speech is ended.
    /// </summary>
    public enum AutomaticActivityDetectionEndOfSpeechSensitivity
    {
        /// <summary>
        /// Automatic detection ends speech more often.
        /// </summary>
        EndSensitivityHigh,
        /// <summary>
        /// Automatic detection ends speech less often.
        /// </summary>
        EndSensitivityLow,
        /// <summary>
        /// The default is END_SENSITIVITY_HIGH.
        /// </summary>
        EndSensitivityUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomaticActivityDetectionEndOfSpeechSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomaticActivityDetectionEndOfSpeechSensitivity value)
        {
            return value switch
            {
                AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityHigh => "END_SENSITIVITY_HIGH",
                AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityLow => "END_SENSITIVITY_LOW",
                AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityUnspecified => "END_SENSITIVITY_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomaticActivityDetectionEndOfSpeechSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "END_SENSITIVITY_HIGH" => AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityHigh,
                "END_SENSITIVITY_LOW" => AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityLow,
                "END_SENSITIVITY_UNSPECIFIED" => AutomaticActivityDetectionEndOfSpeechSensitivity.EndSensitivityUnspecified,
                _ => null,
            };
        }
    }
}