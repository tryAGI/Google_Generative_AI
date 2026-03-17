
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Immutable. The type of the grantee.
    /// </summary>
    public enum PermissionGranteeType
    {
        /// <summary>
        /// 
        /// </summary>
        GranteeTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        Everyone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionGranteeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionGranteeType value)
        {
            return value switch
            {
                PermissionGranteeType.GranteeTypeUnspecified => "GRANTEE_TYPE_UNSPECIFIED",
                PermissionGranteeType.User => "USER",
                PermissionGranteeType.Group => "GROUP",
                PermissionGranteeType.Everyone => "EVERYONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionGranteeType? ToEnum(string value)
        {
            return value switch
            {
                "GRANTEE_TYPE_UNSPECIFIED" => PermissionGranteeType.GranteeTypeUnspecified,
                "USER" => PermissionGranteeType.User,
                "GROUP" => PermissionGranteeType.Group,
                "EVERYONE" => PermissionGranteeType.Everyone,
                _ => null,
            };
        }
    }
}