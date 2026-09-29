
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. The threshold for blocking content. If the harm probability<br/>
    /// exceeds this threshold, the content will be blocked.
    /// </summary>
    public enum SafetySettingThreshold
    {
        /// <summary>
        ///
        /// </summary>
        BlockLowAndAbove,
        /// <summary>
        ///
        /// </summary>
        BlockMediumAndAbove,
        /// <summary>
        ///
        /// </summary>
        BlockNone,
        /// <summary>
        ///
        /// </summary>
        BlockOnlyHigh,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetySettingThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingThreshold value)
        {
            return value switch
            {
                SafetySettingThreshold.BlockLowAndAbove => "block_low_and_above",
                SafetySettingThreshold.BlockMediumAndAbove => "block_medium_and_above",
                SafetySettingThreshold.BlockNone => "block_none",
                SafetySettingThreshold.BlockOnlyHigh => "block_only_high",
                SafetySettingThreshold.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetySettingThreshold? ToEnum(string value)
        {
            return value switch
            {
                "block_low_and_above" => SafetySettingThreshold.BlockLowAndAbove,
                "block_medium_and_above" => SafetySettingThreshold.BlockMediumAndAbove,
                "block_none" => SafetySettingThreshold.BlockNone,
                "block_only_high" => SafetySettingThreshold.BlockOnlyHigh,
                "off" => SafetySettingThreshold.Off,
                _ => null,
            };
        }
    }
}