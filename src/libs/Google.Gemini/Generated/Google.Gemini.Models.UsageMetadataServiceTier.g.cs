
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. Service tier of the request.<br/>
    /// Included only in responses
    /// </summary>
    public enum UsageMetadataServiceTier
    {
        /// <summary>
        /// Flex service tier.
        /// </summary>
        Flex,
        /// <summary>
        /// Priority service tier.
        /// </summary>
        Priority,
        /// <summary>
        /// Standard service tier.
        /// </summary>
        Standard,
        /// <summary>
        /// Default service tier, which is standard.
        /// </summary>
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageMetadataServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageMetadataServiceTier value)
        {
            return value switch
            {
                UsageMetadataServiceTier.Flex => "flex",
                UsageMetadataServiceTier.Priority => "priority",
                UsageMetadataServiceTier.Standard => "standard",
                UsageMetadataServiceTier.Unspecified => "unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageMetadataServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "flex" => UsageMetadataServiceTier.Flex,
                "priority" => UsageMetadataServiceTier.Priority,
                "standard" => UsageMetadataServiceTier.Standard,
                "unspecified" => UsageMetadataServiceTier.Unspecified,
                _ => null,
            };
        }
    }
}