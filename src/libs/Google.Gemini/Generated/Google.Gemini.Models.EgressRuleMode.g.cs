
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Network egress mode. Set via the `"allowlist": "disabled"` short form; must be the only rule in the allowlist and cannot be combined with `domain`, `transform` or `credential`.
    /// </summary>
    public enum EgressRuleMode
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
    public static class EgressRuleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EgressRuleMode value)
        {
            return value switch
            {
                EgressRuleMode.Disabled => "DISABLED",
                EgressRuleMode.NetworkModeUnspecified => "NETWORK_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EgressRuleMode? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => EgressRuleMode.Disabled,
                "NETWORK_MODE_UNSPECIFIED" => EgressRuleMode.NetworkModeUnspecified,
                _ => null,
            };
        }
    }
}