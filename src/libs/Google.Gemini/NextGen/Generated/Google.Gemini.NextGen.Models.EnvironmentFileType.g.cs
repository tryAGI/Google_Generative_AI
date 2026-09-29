
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. The type of the entry.<br/>
    /// Included only in responses
    /// </summary>
    public enum EnvironmentFileType
    {
        /// <summary>
        ///
        /// </summary>
        Directory,
        /// <summary>
        ///
        /// </summary>
        File,
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
                EnvironmentFileType.Directory => "directory",
                EnvironmentFileType.File => "file",
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
                "directory" => EnvironmentFileType.Directory,
                "file" => EnvironmentFileType.File,
                _ => null,
            };
        }
    }
}