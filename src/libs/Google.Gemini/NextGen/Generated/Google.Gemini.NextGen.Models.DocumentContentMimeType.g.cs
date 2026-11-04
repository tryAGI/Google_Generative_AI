
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
        ApplicationMsword,
        /// <summary>
        ///
        /// </summary>
        ApplicationPdf,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndMsExcel,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndMsPowerpoint,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOasisOpendocumentPresentation,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOasisOpendocumentSpreadsheet,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOasisOpendocumentText,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        /// <summary>
        ///
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate,
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
                DocumentContentMimeType.ApplicationMsword => "application/msword",
                DocumentContentMimeType.ApplicationPdf => "application/pdf",
                DocumentContentMimeType.ApplicationVndMsExcel => "application/vnd.ms-excel",
                DocumentContentMimeType.ApplicationVndMsPowerpoint => "application/vnd.ms-powerpoint",
                DocumentContentMimeType.ApplicationVndOasisOpendocumentPresentation => "application/vnd.oasis.opendocument.presentation",
                DocumentContentMimeType.ApplicationVndOasisOpendocumentSpreadsheet => "application/vnd.oasis.opendocument.spreadsheet",
                DocumentContentMimeType.ApplicationVndOasisOpendocumentText => "application/vnd.oasis.opendocument.text",
                DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate => "application/vnd.openxmlformats-officedocument.wordprocessingml.template",
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
                "application/msword" => DocumentContentMimeType.ApplicationMsword,
                "application/pdf" => DocumentContentMimeType.ApplicationPdf,
                "application/vnd.ms-excel" => DocumentContentMimeType.ApplicationVndMsExcel,
                "application/vnd.ms-powerpoint" => DocumentContentMimeType.ApplicationVndMsPowerpoint,
                "application/vnd.oasis.opendocument.presentation" => DocumentContentMimeType.ApplicationVndOasisOpendocumentPresentation,
                "application/vnd.oasis.opendocument.spreadsheet" => DocumentContentMimeType.ApplicationVndOasisOpendocumentSpreadsheet,
                "application/vnd.oasis.opendocument.text" => DocumentContentMimeType.ApplicationVndOasisOpendocumentText,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.template" => DocumentContentMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate,
                "text/csv" => DocumentContentMimeType.TextCsv,
                _ => null,
            };
        }
    }
}