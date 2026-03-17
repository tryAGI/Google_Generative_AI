
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The reason content was blocked during request processing.
    /// </summary>
    public enum ContentFilterReason
    {
        /// <summary>
        /// 
        /// </summary>
        BlockedReasonUnspecified,
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
    public static class ContentFilterReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterReason value)
        {
            return value switch
            {
                ContentFilterReason.BlockedReasonUnspecified => "BLOCKED_REASON_UNSPECIFIED",
                ContentFilterReason.Safety => "SAFETY",
                ContentFilterReason.Other => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_REASON_UNSPECIFIED" => ContentFilterReason.BlockedReasonUnspecified,
                "SAFETY" => ContentFilterReason.Safety,
                "OTHER" => ContentFilterReason.Other,
                _ => null,
            };
        }
    }
}