
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The MIME type of the text output.
    /// </summary>
    public enum TextResponseFormatMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationJson,
        /// <summary>
        ///
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextResponseFormatMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextResponseFormatMimeType value)
        {
            return value switch
            {
                TextResponseFormatMimeType.ApplicationJson => "application/json",
                TextResponseFormatMimeType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextResponseFormatMimeType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => TextResponseFormatMimeType.ApplicationJson,
                "text/plain" => TextResponseFormatMimeType.TextPlain,
                _ => null,
            };
        }
    }
}