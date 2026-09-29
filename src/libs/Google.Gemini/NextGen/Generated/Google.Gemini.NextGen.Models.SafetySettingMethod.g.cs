
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. The method for blocking content. If not specified, the default<br/>
    /// behavior is to use the probability score.
    /// </summary>
    public enum SafetySettingMethod
    {
        /// <summary>
        ///
        /// </summary>
        Probability,
        /// <summary>
        ///
        /// </summary>
        Severity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetySettingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingMethod value)
        {
            return value switch
            {
                SafetySettingMethod.Probability => "probability",
                SafetySettingMethod.Severity => "severity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetySettingMethod? ToEnum(string value)
        {
            return value switch
            {
                "probability" => SafetySettingMethod.Probability,
                "severity" => SafetySettingMethod.Severity,
                _ => null,
            };
        }
    }
}