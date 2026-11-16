
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. If set, the input was blocked and no answers are returned.
    /// </summary>
    public enum PromptFeedbackBlockReason
    {
        /// <summary>
        ///
        /// </summary>
        Blocklist,
        /// <summary>
        ///
        /// </summary>
        ImageSafety,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        ProhibitedContent,
        /// <summary>
        ///
        /// </summary>
        Safety,
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
                PromptFeedbackBlockReason.Blocklist => "blocklist",
                PromptFeedbackBlockReason.ImageSafety => "image_safety",
                PromptFeedbackBlockReason.Other => "other",
                PromptFeedbackBlockReason.ProhibitedContent => "prohibited_content",
                PromptFeedbackBlockReason.Safety => "safety",
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
                "blocklist" => PromptFeedbackBlockReason.Blocklist,
                "image_safety" => PromptFeedbackBlockReason.ImageSafety,
                "other" => PromptFeedbackBlockReason.Other,
                "prohibited_content" => PromptFeedbackBlockReason.ProhibitedContent,
                "safety" => PromptFeedbackBlockReason.Safety,
                _ => null,
            };
        }
    }
}