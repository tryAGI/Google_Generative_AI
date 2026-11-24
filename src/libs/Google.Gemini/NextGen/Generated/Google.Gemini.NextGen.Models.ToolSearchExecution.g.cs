
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The execution mode of the tool search.
    /// </summary>
    public enum ToolSearchExecution
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchExecution value)
        {
            return value switch
            {
                ToolSearchExecution.Client => "client",
                ToolSearchExecution.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolSearchExecution.Client,
                "server" => ToolSearchExecution.Server,
                _ => null,
            };
        }
    }
}