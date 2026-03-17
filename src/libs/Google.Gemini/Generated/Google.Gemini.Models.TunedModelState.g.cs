
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The state of the tuned model.<br/>
    /// Included only in responses
    /// </summary>
    public enum TunedModelState
    {
        /// <summary>
        /// 
        /// </summary>
        StateUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Creating,
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
    public static class TunedModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TunedModelState value)
        {
            return value switch
            {
                TunedModelState.StateUnspecified => "STATE_UNSPECIFIED",
                TunedModelState.Creating => "CREATING",
                TunedModelState.Active => "ACTIVE",
                TunedModelState.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TunedModelState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_UNSPECIFIED" => TunedModelState.StateUnspecified,
                "CREATING" => TunedModelState.Creating,
                "ACTIVE" => TunedModelState.Active,
                "FAILED" => TunedModelState.Failed,
                _ => null,
            };
        }
    }
}