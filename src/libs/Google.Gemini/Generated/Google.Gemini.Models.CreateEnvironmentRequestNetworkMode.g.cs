
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Network egress mode.
    /// </summary>
    public enum CreateEnvironmentRequestNetworkMode
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
    public static class CreateEnvironmentRequestNetworkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentRequestNetworkMode value)
        {
            return value switch
            {
                CreateEnvironmentRequestNetworkMode.Disabled => "DISABLED",
                CreateEnvironmentRequestNetworkMode.NetworkModeUnspecified => "NETWORK_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentRequestNetworkMode? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => CreateEnvironmentRequestNetworkMode.Disabled,
                "NETWORK_MODE_UNSPECIFIED" => CreateEnvironmentRequestNetworkMode.NetworkModeUnspecified,
                _ => null,
            };
        }
    }
}