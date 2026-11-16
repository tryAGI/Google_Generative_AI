
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    ///
    /// </summary>
    public enum SpreadsheetMetadataContentLayer
    {
        /// <summary>
        /// Default value.
        /// </summary>
        ContentLayerUnspecified,
        /// <summary>
        /// Cell values, merges, and formats.
        /// </summary>
        Data,
        /// <summary>
        /// Formula expressions and their computed results.
        /// </summary>
        Formulas,
        /// <summary>
        /// A rendered image of the sheet.
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetMetadataContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetMetadataContentLayer value)
        {
            return value switch
            {
                SpreadsheetMetadataContentLayer.ContentLayerUnspecified => "CONTENT_LAYER_UNSPECIFIED",
                SpreadsheetMetadataContentLayer.Data => "DATA",
                SpreadsheetMetadataContentLayer.Formulas => "FORMULAS",
                SpreadsheetMetadataContentLayer.Visual => "VISUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetMetadataContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_LAYER_UNSPECIFIED" => SpreadsheetMetadataContentLayer.ContentLayerUnspecified,
                "DATA" => SpreadsheetMetadataContentLayer.Data,
                "FORMULAS" => SpreadsheetMetadataContentLayer.Formulas,
                "VISUAL" => SpreadsheetMetadataContentLayer.Visual,
                _ => null,
            };
        }
    }
}