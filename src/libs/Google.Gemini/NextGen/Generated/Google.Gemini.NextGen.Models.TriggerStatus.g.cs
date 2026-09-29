
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. The current status of the trigger.<br/>
    /// Included only in responses
    /// </summary>
    public enum TriggerStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerStatus value)
        {
            return value switch
            {
                TriggerStatus.Active => "active",
                TriggerStatus.Error => "error",
                TriggerStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => TriggerStatus.Active,
                "error" => TriggerStatus.Error,
                "paused" => TriggerStatus.Paused,
                _ => null,
            };
        }
    }
}