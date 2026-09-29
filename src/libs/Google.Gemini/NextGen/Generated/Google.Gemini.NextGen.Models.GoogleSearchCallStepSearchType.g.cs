
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The type of search grounding enabled.
    /// </summary>
    public enum GoogleSearchCallStepSearchType
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
    public static class GoogleSearchCallStepSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSearchCallStepSearchType value)
        {
            return value switch
            {
                GoogleSearchCallStepSearchType.EnterpriseWebSearch => "enterprise_web_search",
                GoogleSearchCallStepSearchType.ImageSearch => "image_search",
                GoogleSearchCallStepSearchType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSearchCallStepSearchType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise_web_search" => GoogleSearchCallStepSearchType.EnterpriseWebSearch,
                "image_search" => GoogleSearchCallStepSearchType.ImageSearch,
                "web_search" => GoogleSearchCallStepSearchType.WebSearch,
                _ => null,
            };
        }
    }
}