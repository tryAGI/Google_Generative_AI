
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mime type of the document.
    /// </summary>
    public enum DocumentContentMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationPdf,
        /// <summary>
        ///
        /// </summary>
        TextCsv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentContentMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentContentMimeType value)
        {
            return value switch
            {
                DocumentContentMimeType.ApplicationPdf => "application/pdf",
                DocumentContentMimeType.TextCsv => "text/csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentContentMimeType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => DocumentContentMimeType.ApplicationPdf,
                "text/csv" => DocumentContentMimeType.TextCsv,
                _ => null,
            };
        }
    }
}