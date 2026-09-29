
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. The status of the trigger.
    /// </summary>
    public enum TriggerUpdateStatus
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
    public static class TriggerUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerUpdateStatus value)
        {
            return value switch
            {
                TriggerUpdateStatus.Active => "active",
                TriggerUpdateStatus.Error => "error",
                TriggerUpdateStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => TriggerUpdateStatus.Active,
                "error" => TriggerUpdateStatus.Error,
                "paused" => TriggerUpdateStatus.Paused,
                _ => null,
            };
        }
    }
}