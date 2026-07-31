
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// 
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// A GCS bucket.
        /// </summary>
        Gcs,
        /// <summary>
        /// Inline content.
        /// </summary>
        Inline,
        /// <summary>
        /// A generic repository. The protocol prefix in the source URL identifies the provider (e.g., github://, gcs://).
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        TypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceType value)
        {
            return value switch
            {
                SourceType.Gcs => "GCS",
                SourceType.Inline => "INLINE",
                SourceType.Repository => "REPOSITORY",
                SourceType.TypeUnspecified => "TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceType? ToEnum(string value)
        {
            return value switch
            {
                "GCS" => SourceType.Gcs,
                "INLINE" => SourceType.Inline,
                "REPOSITORY" => SourceType.Repository,
                "TYPE_UNSPECIFIED" => SourceType.TypeUnspecified,
                _ => null,
            };
        }
    }
}