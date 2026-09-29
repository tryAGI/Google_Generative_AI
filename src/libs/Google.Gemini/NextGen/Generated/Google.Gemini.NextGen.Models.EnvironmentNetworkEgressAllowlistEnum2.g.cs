
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Turns all network off.
    /// </summary>
    public enum EnvironmentNetworkEgressAllowlistEnum2
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentNetworkEgressAllowlistEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentNetworkEgressAllowlistEnum2 value)
        {
            return value switch
            {
                EnvironmentNetworkEgressAllowlistEnum2.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentNetworkEgressAllowlistEnum2? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => EnvironmentNetworkEgressAllowlistEnum2.Disabled,
                _ => null,
            };
        }
    }
}