
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentNetworkEgressAllowlistAllowlist
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentNetworkEgressAllowlistAllowlistExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentNetworkEgressAllowlistAllowlist value)
        {
            return value switch
            {
                EnvironmentNetworkEgressAllowlistAllowlist.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentNetworkEgressAllowlistAllowlist? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => EnvironmentNetworkEgressAllowlistAllowlist.Disabled,
                _ => null,
            };
        }
    }
}