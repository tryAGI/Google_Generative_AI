
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentNetwork2
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentNetwork2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentNetwork2 value)
        {
            return value switch
            {
                EnvironmentNetwork2.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentNetwork2? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => EnvironmentNetwork2.Disabled,
                _ => null,
            };
        }
    }
}