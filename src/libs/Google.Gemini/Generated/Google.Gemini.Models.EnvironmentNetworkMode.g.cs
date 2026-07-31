
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Network egress mode.
    /// </summary>
    public enum EnvironmentNetworkMode
    {
        /// <summary>
        /// All network egress is blocked.
        /// </summary>
        Disabled,
        /// <summary>
        /// Default value. Unused.
        /// </summary>
        NetworkModeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentNetworkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentNetworkMode value)
        {
            return value switch
            {
                EnvironmentNetworkMode.Disabled => "DISABLED",
                EnvironmentNetworkMode.NetworkModeUnspecified => "NETWORK_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentNetworkMode? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => EnvironmentNetworkMode.Disabled,
                "NETWORK_MODE_UNSPECIFIED" => EnvironmentNetworkMode.NetworkModeUnspecified,
                _ => null,
            };
        }
    }
}