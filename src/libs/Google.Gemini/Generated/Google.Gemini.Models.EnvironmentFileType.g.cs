
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The type of the entry.<br/>
    /// Included only in responses
    /// </summary>
    public enum EnvironmentFileType
    {
        /// <summary>
        /// A directory.
        /// </summary>
        Directory,
        /// <summary>
        /// A regular file.
        /// </summary>
        File,
        /// <summary>
        /// Unspecified type.
        /// </summary>
        TypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentFileType value)
        {
            return value switch
            {
                EnvironmentFileType.Directory => "DIRECTORY",
                EnvironmentFileType.File => "FILE",
                EnvironmentFileType.TypeUnspecified => "TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentFileType? ToEnum(string value)
        {
            return value switch
            {
                "DIRECTORY" => EnvironmentFileType.Directory,
                "FILE" => EnvironmentFileType.File,
                "TYPE_UNSPECIFIED" => EnvironmentFileType.TypeUnspecified,
                _ => null,
            };
        }
    }
}