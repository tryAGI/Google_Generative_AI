
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. The status of the execution.<br/>
    /// Included only in responses
    /// </summary>
    public enum TriggerExecutionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerExecutionStatus value)
        {
            return value switch
            {
                TriggerExecutionStatus.Completed => "completed",
                TriggerExecutionStatus.Failed => "failed",
                TriggerExecutionStatus.InProgress => "in_progress",
                TriggerExecutionStatus.Skipped => "skipped",
                TriggerExecutionStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TriggerExecutionStatus.Completed,
                "failed" => TriggerExecutionStatus.Failed,
                "in_progress" => TriggerExecutionStatus.InProgress,
                "skipped" => TriggerExecutionStatus.Skipped,
                "timed_out" => TriggerExecutionStatus.TimedOut,
                _ => null,
            };
        }
    }
}