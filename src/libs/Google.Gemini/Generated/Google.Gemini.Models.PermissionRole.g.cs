
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The role granted by this permission.
    /// </summary>
    public enum PermissionRole
    {
        /// <summary>
        /// The default value. This value is unused.
        /// </summary>
        RoleUnspecified,
        /// <summary>
        /// Owner can use, update, share and delete the resource.
        /// </summary>
        Owner,
        /// <summary>
        /// Writer can use, update and share the resource.
        /// </summary>
        Writer,
        /// <summary>
        /// Reader can use the resource.
        /// </summary>
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionRole value)
        {
            return value switch
            {
                PermissionRole.RoleUnspecified => "ROLE_UNSPECIFIED",
                PermissionRole.Owner => "OWNER",
                PermissionRole.Writer => "WRITER",
                PermissionRole.Reader => "READER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionRole? ToEnum(string value)
        {
            return value switch
            {
                "ROLE_UNSPECIFIED" => PermissionRole.RoleUnspecified,
                "OWNER" => PermissionRole.Owner,
                "WRITER" => PermissionRole.Writer,
                "READER" => PermissionRole.Reader,
                _ => null,
            };
        }
    }
}