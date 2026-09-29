
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum GoogleSearchSearchType
    {
        /// <summary>
        ///
        /// </summary>
        EnterpriseWebSearch,
        /// <summary>
        ///
        /// </summary>
        ImageSearch,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleSearchSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSearchSearchType value)
        {
            return value switch
            {
                GoogleSearchSearchType.EnterpriseWebSearch => "enterprise_web_search",
                GoogleSearchSearchType.ImageSearch => "image_search",
                GoogleSearchSearchType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSearchSearchType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise_web_search" => GoogleSearchSearchType.EnterpriseWebSearch,
                "image_search" => GoogleSearchSearchType.ImageSearch,
                "web_search" => GoogleSearchSearchType.WebSearch,
                _ => null,
            };
        }
    }
}