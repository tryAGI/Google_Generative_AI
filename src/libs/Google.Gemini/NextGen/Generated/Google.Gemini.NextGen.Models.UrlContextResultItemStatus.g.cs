
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The status of the URL retrieval.
    /// </summary>
    public enum UrlContextResultItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Paywall,
        /// <summary>
        ///
        /// </summary>
        Success,
        /// <summary>
        ///
        /// </summary>
        Unsafe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlContextResultItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlContextResultItemStatus value)
        {
            return value switch
            {
                UrlContextResultItemStatus.Error => "error",
                UrlContextResultItemStatus.Paywall => "paywall",
                UrlContextResultItemStatus.Success => "success",
                UrlContextResultItemStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlContextResultItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UrlContextResultItemStatus.Error,
                "paywall" => UrlContextResultItemStatus.Paywall,
                "success" => UrlContextResultItemStatus.Success,
                "unsafe" => UrlContextResultItemStatus.Unsafe,
                _ => null,
            };
        }
    }
}