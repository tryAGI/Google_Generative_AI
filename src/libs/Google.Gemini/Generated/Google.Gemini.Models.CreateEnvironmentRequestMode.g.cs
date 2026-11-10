
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The compute lifecycle mode for this environment.
    /// </summary>
    public enum CreateEnvironmentRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentModeUnspecified,
        /// <summary>
        ///
        /// </summary>
        OnDemand,
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnvironmentRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentRequestMode value)
        {
            return value switch
            {
                CreateEnvironmentRequestMode.EnvironmentModeUnspecified => "ENVIRONMENT_MODE_UNSPECIFIED",
                CreateEnvironmentRequestMode.OnDemand => "ON_DEMAND",
                CreateEnvironmentRequestMode.SelfHosted => "SELF_HOSTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "ENVIRONMENT_MODE_UNSPECIFIED" => CreateEnvironmentRequestMode.EnvironmentModeUnspecified,
                "ON_DEMAND" => CreateEnvironmentRequestMode.OnDemand,
                "SELF_HOSTED" => CreateEnvironmentRequestMode.SelfHosted,
                _ => null,
            };
        }
    }
}