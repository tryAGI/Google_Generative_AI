
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Controls the probability threshold at which harm is blocked.
    /// </summary>
    public enum SafetySettingThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        HarmBlockThresholdUnspecified,
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
        BlockOnlyHigh,
        /// <summary>
        /// 
        /// </summary>
        BlockNone,
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
                SafetySettingThreshold.HarmBlockThresholdUnspecified => "HARM_BLOCK_THRESHOLD_UNSPECIFIED",
                SafetySettingThreshold.BlockLowAndAbove => "BLOCK_LOW_AND_ABOVE",
                SafetySettingThreshold.BlockMediumAndAbove => "BLOCK_MEDIUM_AND_ABOVE",
                SafetySettingThreshold.BlockOnlyHigh => "BLOCK_ONLY_HIGH",
                SafetySettingThreshold.BlockNone => "BLOCK_NONE",
                SafetySettingThreshold.Off => "OFF",
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
                "HARM_BLOCK_THRESHOLD_UNSPECIFIED" => SafetySettingThreshold.HarmBlockThresholdUnspecified,
                "BLOCK_LOW_AND_ABOVE" => SafetySettingThreshold.BlockLowAndAbove,
                "BLOCK_MEDIUM_AND_ABOVE" => SafetySettingThreshold.BlockMediumAndAbove,
                "BLOCK_ONLY_HIGH" => SafetySettingThreshold.BlockOnlyHigh,
                "BLOCK_NONE" => SafetySettingThreshold.BlockNone,
                "OFF" => SafetySettingThreshold.Off,
                _ => null,
            };
        }
    }
}