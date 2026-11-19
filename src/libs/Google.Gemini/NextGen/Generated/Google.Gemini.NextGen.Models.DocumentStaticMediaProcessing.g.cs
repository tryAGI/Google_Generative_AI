
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DocumentStaticMediaProcessing
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Processing options for paginated documents, such as PDFs, Office<br/>
        /// documents, and presentations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_options")]
        public global::Google.Gemini.NextGen.PageProcessingOptions? PageOptions { get; set; }

        /// <summary>
        /// Processing options for spreadsheets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_options")]
        public global::Google.Gemini.NextGen.SpreadsheetProcessingOptions? SpreadsheetOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStaticMediaProcessing" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageOptions">
        /// Processing options for paginated documents, such as PDFs, Office<br/>
        /// documents, and presentations.
        /// </param>
        /// <param name="spreadsheetOptions">
        /// Processing options for spreadsheets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStaticMediaProcessing(
            object type,
            global::Google.Gemini.NextGen.PageProcessingOptions? pageOptions,
            global::Google.Gemini.NextGen.SpreadsheetProcessingOptions? spreadsheetOptions)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PageOptions = pageOptions;
            this.SpreadsheetOptions = spreadsheetOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStaticMediaProcessing" /> class.
        /// </summary>
        public DocumentStaticMediaProcessing()
        {
        }

    }
}