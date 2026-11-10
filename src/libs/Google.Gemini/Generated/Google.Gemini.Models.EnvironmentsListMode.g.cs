
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentsListMode
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
    public static class EnvironmentsListModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsListMode value)
        {
            return value switch
            {
                EnvironmentsListMode.EnvironmentModeUnspecified => "ENVIRONMENT_MODE_UNSPECIFIED",
                EnvironmentsListMode.OnDemand => "ON_DEMAND",
                EnvironmentsListMode.SelfHosted => "SELF_HOSTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsListMode? ToEnum(string value)
        {
            return value switch
            {
                "ENVIRONMENT_MODE_UNSPECIFIED" => EnvironmentsListMode.EnvironmentModeUnspecified,
                "ON_DEMAND" => EnvironmentsListMode.OnDemand,
                "SELF_HOSTED" => EnvironmentsListMode.SelfHosted,
                _ => null,
            };
        }
    }
}