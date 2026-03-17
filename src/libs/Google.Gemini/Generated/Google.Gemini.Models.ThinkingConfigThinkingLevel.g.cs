
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
    /// </summary>
    public enum ThinkingConfigThinkingLevel
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingLevelUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
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
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingConfigThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingConfigThinkingLevel value)
        {
            return value switch
            {
                ThinkingConfigThinkingLevel.ThinkingLevelUnspecified => "THINKING_LEVEL_UNSPECIFIED",
                ThinkingConfigThinkingLevel.Minimal => "MINIMAL",
                ThinkingConfigThinkingLevel.Low => "LOW",
                ThinkingConfigThinkingLevel.Medium => "MEDIUM",
                ThinkingConfigThinkingLevel.High => "HIGH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingConfigThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "THINKING_LEVEL_UNSPECIFIED" => ThinkingConfigThinkingLevel.ThinkingLevelUnspecified,
                "MINIMAL" => ThinkingConfigThinkingLevel.Minimal,
                "LOW" => ThinkingConfigThinkingLevel.Low,
                "MEDIUM" => ThinkingConfigThinkingLevel.Medium,
                "HIGH" => ThinkingConfigThinkingLevel.High,
                _ => null,
            };
        }
    }
}