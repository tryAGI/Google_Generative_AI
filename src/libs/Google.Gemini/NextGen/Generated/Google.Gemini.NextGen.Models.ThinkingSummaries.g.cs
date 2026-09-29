
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ThinkingSummaries
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingSummariesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingSummaries value)
        {
            return value switch
            {
                ThinkingSummaries.Auto => "auto",
                ThinkingSummaries.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingSummaries? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ThinkingSummaries.Auto,
                "none" => ThinkingSummaries.None,
                _ => null,
            };
        }
    }
}