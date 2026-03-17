
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. Current state of the `Document`.<br/>
    /// Included only in responses
    /// </summary>
    public enum DocumentState
    {
        /// <summary>
        /// 
        /// </summary>
        StateUnspecified,
        /// <summary>
        /// 
        /// </summary>
        StatePending,
        /// <summary>
        /// 
        /// </summary>
        StateActive,
        /// <summary>
        /// 
        /// </summary>
        StateFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentState value)
        {
            return value switch
            {
                DocumentState.StateUnspecified => "STATE_UNSPECIFIED",
                DocumentState.StatePending => "STATE_PENDING",
                DocumentState.StateActive => "STATE_ACTIVE",
                DocumentState.StateFailed => "STATE_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_UNSPECIFIED" => DocumentState.StateUnspecified,
                "STATE_PENDING" => DocumentState.StatePending,
                "STATE_ACTIVE" => DocumentState.StateActive,
                "STATE_FAILED" => DocumentState.StateFailed,
                _ => null,
            };
        }
    }
}