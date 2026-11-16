
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The compute lifecycle mode for this environment.
    /// </summary>
    public enum EnvironmentConfigMode
    {
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
    public static class EnvironmentConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentConfigMode value)
        {
            return value switch
            {
                EnvironmentConfigMode.OnDemand => "on_demand",
                EnvironmentConfigMode.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "on_demand" => EnvironmentConfigMode.OnDemand,
                "self_hosted" => EnvironmentConfigMode.SelfHosted,
                _ => null,
            };
        }
    }
}