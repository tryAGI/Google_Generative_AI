
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum TranscriptionConfigMode
    {
        /// <summary>
        ///
        /// </summary>
        Smart,
        /// <summary>
        ///
        /// </summary>
        Verbatim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionConfigMode value)
        {
            return value switch
            {
                TranscriptionConfigMode.Smart => "smart",
                TranscriptionConfigMode.Verbatim => "verbatim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "smart" => TranscriptionConfigMode.Smart,
                "verbatim" => TranscriptionConfigMode.Verbatim,
                _ => null,
            };
        }
    }
}