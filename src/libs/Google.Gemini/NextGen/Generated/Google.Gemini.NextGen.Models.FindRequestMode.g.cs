
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mode of the find session.
    /// </summary>
    public enum FindRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        Scan,
        /// <summary>
        ///
        /// </summary>
        Verify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FindRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindRequestMode value)
        {
            return value switch
            {
                FindRequestMode.Scan => "scan",
                FindRequestMode.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "scan" => FindRequestMode.Scan,
                "verify" => FindRequestMode.Verify,
                _ => null,
            };
        }
    }
}