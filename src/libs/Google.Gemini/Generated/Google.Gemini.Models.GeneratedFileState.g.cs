
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The state of the GeneratedFile.<br/>
    /// Included only in responses
    /// </summary>
    public enum GeneratedFileState
    {
        /// <summary>
        /// The default value. This value is used if the state is omitted.
        /// </summary>
        StateUnspecified,
        /// <summary>
        /// Being generated.
        /// </summary>
        Generating,
        /// <summary>
        /// Generated and is ready for download.
        /// </summary>
        Generated,
        /// <summary>
        /// Failed to generate the GeneratedFile.
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedFileStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedFileState value)
        {
            return value switch
            {
                GeneratedFileState.StateUnspecified => "STATE_UNSPECIFIED",
                GeneratedFileState.Generating => "GENERATING",
                GeneratedFileState.Generated => "GENERATED",
                GeneratedFileState.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedFileState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_UNSPECIFIED" => GeneratedFileState.StateUnspecified,
                "GENERATING" => GeneratedFileState.Generating,
                "GENERATED" => GeneratedFileState.Generated,
                "FAILED" => GeneratedFileState.Failed,
                _ => null,
            };
        }
    }
}