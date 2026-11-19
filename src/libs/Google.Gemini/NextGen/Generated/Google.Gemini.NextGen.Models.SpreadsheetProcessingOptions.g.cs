
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Processing options for spreadsheets.
    /// </summary>
    public sealed partial class SpreadsheetProcessingOptions
    {
        /// <summary>
        /// Optional. The range of cells to extract, in A1 notation (e.g. "A1:D10").<br/>
        /// If not set, the full occupied area of the sheet is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_cells")]
        public string? VisibleCells { get; set; }

        /// <summary>
        /// Optional. The 1-indexed index of the sheet to extract, in workbook<br/>
        /// order. If not set, all sheets are extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_index")]
        public int? SheetIndex { get; set; }

        /// <summary>
        /// Optional. Content layers to extract from a spreadsheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_layers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>? ContentLayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetProcessingOptions" /> class.
        /// </summary>
        /// <param name="visibleCells">
        /// Optional. The range of cells to extract, in A1 notation (e.g. "A1:D10").<br/>
        /// If not set, the full occupied area of the sheet is used.
        /// </param>
        /// <param name="sheetIndex">
        /// Optional. The 1-indexed index of the sheet to extract, in workbook<br/>
        /// order. If not set, all sheets are extracted.
        /// </param>
        /// <param name="contentLayers">
        /// Optional. Content layers to extract from a spreadsheet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetProcessingOptions(
            string? visibleCells,
            int? sheetIndex,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>? contentLayers)
        {
            this.VisibleCells = visibleCells;
            this.SheetIndex = sheetIndex;
            this.ContentLayers = contentLayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetProcessingOptions" /> class.
        /// </summary>
        public SpreadsheetProcessingOptions()
        {
        }

    }
}