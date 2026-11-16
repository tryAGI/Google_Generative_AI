
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ListEnvironmentsMode
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
    public static class ListEnvironmentsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEnvironmentsMode value)
        {
            return value switch
            {
                ListEnvironmentsMode.OnDemand => "on_demand",
                ListEnvironmentsMode.SelfHosted => "self_hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEnvironmentsMode? ToEnum(string value)
        {
            return value switch
            {
                "on_demand" => ListEnvironmentsMode.OnDemand,
                "self_hosted" => ListEnvironmentsMode.SelfHosted,
                _ => null,
            };
        }
    }
}