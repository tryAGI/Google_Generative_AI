
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
    /// </summary>
    public enum PromptFeedbackBlockReason
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
        /// <summary>
        /// 
        /// </summary>
        Blocklist,
        /// <summary>
        /// 
        /// </summary>
        ProhibitedContent,
        /// <summary>
        /// 
        /// </summary>
        ImageSafety,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptFeedbackBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptFeedbackBlockReason value)
        {
            return value switch
            {
                PromptFeedbackBlockReason.BlockReasonUnspecified => "BLOCK_REASON_UNSPECIFIED",
                PromptFeedbackBlockReason.Safety => "SAFETY",
                PromptFeedbackBlockReason.Other => "OTHER",
                PromptFeedbackBlockReason.Blocklist => "BLOCKLIST",
                PromptFeedbackBlockReason.ProhibitedContent => "PROHIBITED_CONTENT",
                PromptFeedbackBlockReason.ImageSafety => "IMAGE_SAFETY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptFeedbackBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_REASON_UNSPECIFIED" => PromptFeedbackBlockReason.BlockReasonUnspecified,
                "SAFETY" => PromptFeedbackBlockReason.Safety,
                "OTHER" => PromptFeedbackBlockReason.Other,
                "BLOCKLIST" => PromptFeedbackBlockReason.Blocklist,
                "PROHIBITED_CONTENT" => PromptFeedbackBlockReason.ProhibitedContent,
                "IMAGE_SAFETY" => PromptFeedbackBlockReason.ImageSafety,
                _ => null,
            };
        }
    }
}