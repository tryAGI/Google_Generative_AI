
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Network egress mode.
    /// </summary>
    public enum EnvironmentConfigNetworkMode
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
    public static class EnvironmentConfigNetworkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentConfigNetworkMode value)
        {
            return value switch
            {
                EnvironmentConfigNetworkMode.Disabled => "DISABLED",
                EnvironmentConfigNetworkMode.NetworkModeUnspecified => "NETWORK_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentConfigNetworkMode? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => EnvironmentConfigNetworkMode.Disabled,
                "NETWORK_MODE_UNSPECIFIED" => EnvironmentConfigNetworkMode.NetworkModeUnspecified,
                _ => null,
            };
        }
    }
}