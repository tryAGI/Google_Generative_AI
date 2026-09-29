
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        ///
        /// </summary>
        Gcs,
        /// <summary>
        ///
        /// </summary>
        Inline,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        SkillRegistry,
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
                SourceType.Gcs => "gcs",
                SourceType.Inline => "inline",
                SourceType.Repository => "repository",
                SourceType.SkillRegistry => "skill_registry",
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
                "gcs" => SourceType.Gcs,
                "inline" => SourceType.Inline,
                "repository" => SourceType.Repository,
                "skill_registry" => SourceType.SkillRegistry,
                _ => null,
            };
        }
    }
}