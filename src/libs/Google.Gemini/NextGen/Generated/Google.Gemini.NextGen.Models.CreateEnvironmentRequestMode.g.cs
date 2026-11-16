
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The compute lifecycle mode for this environment.
    /// </summary>
    public enum CreateEnvironmentRequestMode
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
    public static class CreateEnvironmentRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentRequestMode value)
        {
            return value switch
            {
                CreateEnvironmentRequestMode.OnDemand => "on_demand",
                CreateEnvironmentRequestMode.SelfHosted => "self_hosted",
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
                "on_demand" => CreateEnvironmentRequestMode.OnDemand,
                "self_hosted" => CreateEnvironmentRequestMode.SelfHosted,
                _ => null,
            };
        }
    }
}