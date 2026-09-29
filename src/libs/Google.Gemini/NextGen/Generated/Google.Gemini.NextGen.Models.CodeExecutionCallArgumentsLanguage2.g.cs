
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Programming language of the `code`.
    /// </summary>
    public enum CodeExecutionCallArgumentsLanguage2
    {
        /// <summary>
        ///
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionCallArgumentsLanguage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionCallArgumentsLanguage2 value)
        {
            return value switch
            {
                CodeExecutionCallArgumentsLanguage2.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionCallArgumentsLanguage2? ToEnum(string value)
        {
            return value switch
            {
                "python" => CodeExecutionCallArgumentsLanguage2.Python,
                _ => null,
            };
        }
    }
}