
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Source of the File.
    /// </summary>
    public enum FileSource
    {
        /// <summary>
        /// 
        /// </summary>
        SourceUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Registered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSource value)
        {
            return value switch
            {
                FileSource.SourceUnspecified => "SOURCE_UNSPECIFIED",
                FileSource.Uploaded => "UPLOADED",
                FileSource.Generated => "GENERATED",
                FileSource.Registered => "REGISTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSource? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_UNSPECIFIED" => FileSource.SourceUnspecified,
                "UPLOADED" => FileSource.Uploaded,
                "GENERATED" => FileSource.Generated,
                "REGISTERED" => FileSource.Registered,
                _ => null,
            };
        }
    }
}