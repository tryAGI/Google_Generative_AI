
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The MIME type of the text output.
    /// </summary>
    public enum TextResponseFormatMimeType
    {
        /// <summary>
        /// JSON output format.
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        MimeTypeUnspecified,
        /// <summary>
        /// Plain text output format.
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
                TextResponseFormatMimeType.ApplicationJson => "APPLICATION_JSON",
                TextResponseFormatMimeType.MimeTypeUnspecified => "MIME_TYPE_UNSPECIFIED",
                TextResponseFormatMimeType.TextPlain => "TEXT_PLAIN",
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
                "APPLICATION_JSON" => TextResponseFormatMimeType.ApplicationJson,
                "MIME_TYPE_UNSPECIFIED" => TextResponseFormatMimeType.MimeTypeUnspecified,
                "TEXT_PLAIN" => TextResponseFormatMimeType.TextPlain,
                _ => null,
            };
        }
    }
}