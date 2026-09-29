
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoContentProcessing
    {
        /// <summary>
        ///
        /// </summary>
        Agentic,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContentProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContentProcessing value)
        {
            return value switch
            {
                VideoContentProcessing.Agentic => "agentic",
                VideoContentProcessing.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContentProcessing? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => VideoContentProcessing.Agentic,
                "static" => VideoContentProcessing.Static,
                _ => null,
            };
        }
    }
}