
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The compute lifecycle mode for this environment.<br/>
    /// Included only in responses
    /// </summary>
    public enum EnvironmentMode
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
    public static class EnvironmentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentMode value)
        {
            return value switch
            {
                EnvironmentMode.EnvironmentModeUnspecified => "ENVIRONMENT_MODE_UNSPECIFIED",
                EnvironmentMode.OnDemand => "ON_DEMAND",
                EnvironmentMode.SelfHosted => "SELF_HOSTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentMode? ToEnum(string value)
        {
            return value switch
            {
                "ENVIRONMENT_MODE_UNSPECIFIED" => EnvironmentMode.EnvironmentModeUnspecified,
                "ON_DEMAND" => EnvironmentMode.OnDemand,
                "SELF_HOSTED" => EnvironmentMode.SelfHosted,
                _ => null,
            };
        }
    }
}