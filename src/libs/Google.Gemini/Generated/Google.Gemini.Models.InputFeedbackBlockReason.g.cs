
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. If set, the input was blocked and no candidates are returned. Rephrase the input.
    /// </summary>
    public enum InputFeedbackBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        BlockReasonUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Safety,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFeedbackBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFeedbackBlockReason value)
        {
            return value switch
            {
                InputFeedbackBlockReason.BlockReasonUnspecified => "BLOCK_REASON_UNSPECIFIED",
                InputFeedbackBlockReason.Safety => "SAFETY",
                InputFeedbackBlockReason.Other => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFeedbackBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_REASON_UNSPECIFIED" => InputFeedbackBlockReason.BlockReasonUnspecified,
                "SAFETY" => InputFeedbackBlockReason.Safety,
                "OTHER" => InputFeedbackBlockReason.Other,
                _ => null,
            };
        }
    }
}