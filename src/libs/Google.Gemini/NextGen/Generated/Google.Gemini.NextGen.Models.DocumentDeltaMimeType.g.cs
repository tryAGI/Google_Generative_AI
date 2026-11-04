
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
    public static class DocumentDeltaMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentDeltaMimeType value)
        {
            return value switch
            {
                DocumentDeltaMimeType.ApplicationMsword => "application/msword",
                DocumentDeltaMimeType.ApplicationPdf => "application/pdf",
                DocumentDeltaMimeType.ApplicationVndMsExcel => "application/vnd.ms-excel",
                DocumentDeltaMimeType.ApplicationVndMsPowerpoint => "application/vnd.ms-powerpoint",
                DocumentDeltaMimeType.ApplicationVndOasisOpendocumentPresentation => "application/vnd.oasis.opendocument.presentation",
                DocumentDeltaMimeType.ApplicationVndOasisOpendocumentSpreadsheet => "application/vnd.oasis.opendocument.spreadsheet",
                DocumentDeltaMimeType.ApplicationVndOasisOpendocumentText => "application/vnd.oasis.opendocument.text",
                DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate => "application/vnd.openxmlformats-officedocument.wordprocessingml.template",
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
                "application/msword" => DocumentDeltaMimeType.ApplicationMsword,
                "application/pdf" => DocumentDeltaMimeType.ApplicationPdf,
                "application/vnd.ms-excel" => DocumentDeltaMimeType.ApplicationVndMsExcel,
                "application/vnd.ms-powerpoint" => DocumentDeltaMimeType.ApplicationVndMsPowerpoint,
                "application/vnd.oasis.opendocument.presentation" => DocumentDeltaMimeType.ApplicationVndOasisOpendocumentPresentation,
                "application/vnd.oasis.opendocument.spreadsheet" => DocumentDeltaMimeType.ApplicationVndOasisOpendocumentSpreadsheet,
                "application/vnd.oasis.opendocument.text" => DocumentDeltaMimeType.ApplicationVndOasisOpendocumentText,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.template" => DocumentDeltaMimeType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate,
                "text/csv" => DocumentDeltaMimeType.TextCsv,
                _ => null,
            };
        }
    }
}