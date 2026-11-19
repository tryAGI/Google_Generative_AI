
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum DocumentContentProcessing
    {
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentContentProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentContentProcessing value)
        {
            return value switch
            {
                DocumentContentProcessing.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentContentProcessing? ToEnum(string value)
        {
            return value switch
            {
                "static" => DocumentContentProcessing.Static,
                _ => null,
            };
        }
    }
}