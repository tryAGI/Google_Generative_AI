
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum InjectionLocation3
    {
        /// <summary>
        ///
        /// </summary>
        Body,
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InjectionLocation3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InjectionLocation3 value)
        {
            return value switch
            {
                InjectionLocation3.Body => "body",
                InjectionLocation3.Header => "header",
                InjectionLocation3.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InjectionLocation3? ToEnum(string value)
        {
            return value switch
            {
                "body" => InjectionLocation3.Body,
                "header" => InjectionLocation3.Header,
                "query" => InjectionLocation3.Query,
                _ => null,
            };
        }
    }
}