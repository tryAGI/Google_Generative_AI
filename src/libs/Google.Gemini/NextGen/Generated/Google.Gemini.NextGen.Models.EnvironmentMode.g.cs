
#nullable enable

namespace Google.Gemini.NextGen
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
                EnvironmentMode.OnDemand => "on_demand",
                EnvironmentMode.SelfHosted => "self_hosted",
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
                "on_demand" => EnvironmentMode.OnDemand,
                "self_hosted" => EnvironmentMode.SelfHosted,
                _ => null,
            };
        }
    }
}