
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. Processing state of the File.<br/>
    /// Included only in responses
    /// </summary>
    public enum FileState
    {
        /// <summary>
        /// 
        /// </summary>
        StateUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileState value)
        {
            return value switch
            {
                FileState.StateUnspecified => "STATE_UNSPECIFIED",
                FileState.Processing => "PROCESSING",
                FileState.Active => "ACTIVE",
                FileState.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_UNSPECIFIED" => FileState.StateUnspecified,
                "PROCESSING" => FileState.Processing,
                "ACTIVE" => FileState.Active,
                "FAILED" => FileState.Failed,
                _ => null,
            };
        }
    }
}