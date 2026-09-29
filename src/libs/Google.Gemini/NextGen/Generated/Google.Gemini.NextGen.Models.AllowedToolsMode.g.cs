
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mode of the tool choice.
    /// </summary>
    public enum AllowedToolsMode
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedToolsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedToolsMode value)
        {
            return value switch
            {
                AllowedToolsMode.Any => "any",
                AllowedToolsMode.Auto => "auto",
                AllowedToolsMode.None => "none",
                AllowedToolsMode.Validated => "validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedToolsMode? ToEnum(string value)
        {
            return value switch
            {
                "any" => AllowedToolsMode.Any,
                "auto" => AllowedToolsMode.Auto,
                "none" => AllowedToolsMode.None,
                "validated" => AllowedToolsMode.Validated,
                _ => null,
            };
        }
    }
}