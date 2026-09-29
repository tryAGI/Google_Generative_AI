
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Deferred,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Priority,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier value)
        {
            return value switch
            {
                ServiceTier.Deferred => "deferred",
                ServiceTier.Flex => "flex",
                ServiceTier.Priority => "priority",
                ServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "deferred" => ServiceTier.Deferred,
                "flex" => ServiceTier.Flex,
                "priority" => ServiceTier.Priority,
                "standard" => ServiceTier.Standard,
                _ => null,
            };
        }
    }
}