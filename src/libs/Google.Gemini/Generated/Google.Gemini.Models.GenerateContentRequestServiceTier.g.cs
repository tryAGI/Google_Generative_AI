
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The service tier of the request.
    /// </summary>
    public enum GenerateContentRequestServiceTier
    {
        /// <summary>
        /// Flex service tier.
        /// </summary>
        ServiceTierFlex,
        /// <summary>
        /// Priority service tier.
        /// </summary>
        ServiceTierPriority,
        /// <summary>
        /// Standard service tier.
        /// </summary>
        ServiceTierStandard,
        /// <summary>
        /// Default service tier, which is standard.
        /// </summary>
        ServiceTierUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateContentRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateContentRequestServiceTier value)
        {
            return value switch
            {
                GenerateContentRequestServiceTier.ServiceTierFlex => "SERVICE_TIER_FLEX",
                GenerateContentRequestServiceTier.ServiceTierPriority => "SERVICE_TIER_PRIORITY",
                GenerateContentRequestServiceTier.ServiceTierStandard => "SERVICE_TIER_STANDARD",
                GenerateContentRequestServiceTier.ServiceTierUnspecified => "SERVICE_TIER_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateContentRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "SERVICE_TIER_FLEX" => GenerateContentRequestServiceTier.ServiceTierFlex,
                "SERVICE_TIER_PRIORITY" => GenerateContentRequestServiceTier.ServiceTierPriority,
                "SERVICE_TIER_STANDARD" => GenerateContentRequestServiceTier.ServiceTierStandard,
                "SERVICE_TIER_UNSPECIFIED" => GenerateContentRequestServiceTier.ServiceTierUnspecified,
                _ => null,
            };
        }
    }
}