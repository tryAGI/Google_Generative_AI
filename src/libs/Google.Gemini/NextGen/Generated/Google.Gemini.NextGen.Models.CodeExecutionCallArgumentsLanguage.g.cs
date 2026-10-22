
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Programming language of the `code`.
    /// </summary>
    public enum CodeExecutionCallArgumentsLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Bash,
        /// <summary>
        ///
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionCallArgumentsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionCallArgumentsLanguage value)
        {
            return value switch
            {
                CodeExecutionCallArgumentsLanguage.Bash => "bash",
                CodeExecutionCallArgumentsLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionCallArgumentsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bash" => CodeExecutionCallArgumentsLanguage.Bash,
                "python" => CodeExecutionCallArgumentsLanguage.Python,
                _ => null,
            };
        }
    }
}