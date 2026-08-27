
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The status of the environment container.<br/>
    /// Included only in responses
    /// </summary>
    public enum EnvironmentStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        StatusUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentStatus value)
        {
            return value switch
            {
                EnvironmentStatus.Active => "ACTIVE",
                EnvironmentStatus.Expired => "EXPIRED",
                EnvironmentStatus.StatusUnspecified => "STATUS_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => EnvironmentStatus.Active,
                "EXPIRED" => EnvironmentStatus.Expired,
                "STATUS_UNSPECIFIED" => EnvironmentStatus.StatusUnspecified,
                _ => null,
            };
        }
    }
}