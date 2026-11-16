
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum InjectionLocation
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
    public static class InjectionLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InjectionLocation value)
        {
            return value switch
            {
                InjectionLocation.Body => "body",
                InjectionLocation.Header => "header",
                InjectionLocation.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InjectionLocation? ToEnum(string value)
        {
            return value switch
            {
                "body" => InjectionLocation.Body,
                "header" => InjectionLocation.Header,
                "query" => InjectionLocation.Query,
                _ => null,
            };
        }
    }
}