
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata describes the input spreadsheet content. Set this in `Part.spreadsheet_metadata` or `FunctionResponsePart.spreadsheet_metadata` when `inline_data` or `file_data` contains a spreadsheet to configure static spreadsheet preprocessing.
    /// </summary>
    public sealed partial class SpreadsheetMetadata
    {
        /// <summary>
        /// Optional. The range of cells to extract, in A1 notation (e.g. "A1:D10"). If not set, the full occupied area of the sheet is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleCells")]
        public string? VisibleCells { get; set; }

        /// <summary>
        /// Optional. Content layers to return. If empty, defaults to [DATA, FORMULAS] when SpreadsheetMetadata is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLayers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpreadsheetMetadataContentLayer>? ContentLayers { get; set; }

        /// <summary>
        /// Optional. The 1-indexed index of the sheet to extract, in workbook order. If not set, all sheets are extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheetIndex")]
        public int? SheetIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetMetadata" /> class.
        /// </summary>
        /// <param name="visibleCells">
        /// Optional. The range of cells to extract, in A1 notation (e.g. "A1:D10"). If not set, the full occupied area of the sheet is used.
        /// </param>
        /// <param name="contentLayers">
        /// Optional. Content layers to return. If empty, defaults to [DATA, FORMULAS] when SpreadsheetMetadata is set.
        /// </param>
        /// <param name="sheetIndex">
        /// Optional. The 1-indexed index of the sheet to extract, in workbook order. If not set, all sheets are extracted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetMetadata(
            string? visibleCells,
            global::System.Collections.Generic.IList<global::Google.Gemini.SpreadsheetMetadataContentLayer>? contentLayers,
            int? sheetIndex)
        {
            this.VisibleCells = visibleCells;
            this.ContentLayers = contentLayers;
            this.SheetIndex = sheetIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetMetadata" /> class.
        /// </summary>
        public SpreadsheetMetadata()
        {
        }

    }
}