
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The status of the URL retrieval.
    /// </summary>
    public enum URLContextResultStatus
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
    public static class URLContextResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this URLContextResultStatus value)
        {
            return value switch
            {
                URLContextResultStatus.Error => "error",
                URLContextResultStatus.Paywall => "paywall",
                URLContextResultStatus.Success => "success",
                URLContextResultStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static URLContextResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => URLContextResultStatus.Error,
                "paywall" => URLContextResultStatus.Paywall,
                "success" => URLContextResultStatus.Success,
                "unsafe" => URLContextResultStatus.Unsafe,
                _ => null,
            };
        }
    }
}