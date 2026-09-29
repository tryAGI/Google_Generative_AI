
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum DocumentDeltaMimeType
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
    public static class DocumentDeltaMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentDeltaMimeType value)
        {
            return value switch
            {
                DocumentDeltaMimeType.ApplicationPdf => "application/pdf",
                DocumentDeltaMimeType.TextCsv => "text/csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentDeltaMimeType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => DocumentDeltaMimeType.ApplicationPdf,
                "text/csv" => DocumentDeltaMimeType.TextCsv,
                _ => null,
            };
        }
    }
}