
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum SpreadsheetProcessingOptionsContentLayer
    {
        /// <summary>
        ///
        /// </summary>
        Data,
        /// <summary>
        ///
        /// </summary>
        Formulas,
        /// <summary>
        ///
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetProcessingOptionsContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetProcessingOptionsContentLayer value)
        {
            return value switch
            {
                SpreadsheetProcessingOptionsContentLayer.Data => "data",
                SpreadsheetProcessingOptionsContentLayer.Formulas => "formulas",
                SpreadsheetProcessingOptionsContentLayer.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetProcessingOptionsContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "data" => SpreadsheetProcessingOptionsContentLayer.Data,
                "formulas" => SpreadsheetProcessingOptionsContentLayer.Formulas,
                "visual" => SpreadsheetProcessingOptionsContentLayer.Visual,
                _ => null,
            };
        }
    }
}