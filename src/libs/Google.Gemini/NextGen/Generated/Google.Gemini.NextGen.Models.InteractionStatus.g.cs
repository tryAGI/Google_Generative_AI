
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Output only. The status of the interaction.<br/>
    /// Included only in responses
    /// </summary>
    public enum InteractionStatus
    {
        /// <summary>
        ///
        /// </summary>
        BudgetExceeded,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
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
        Incomplete,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InteractionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionStatus value)
        {
            return value switch
            {
                InteractionStatus.BudgetExceeded => "budget_exceeded",
                InteractionStatus.Cancelled => "cancelled",
                InteractionStatus.Completed => "completed",
                InteractionStatus.Failed => "failed",
                InteractionStatus.InProgress => "in_progress",
                InteractionStatus.Incomplete => "incomplete",
                InteractionStatus.Queued => "queued",
                InteractionStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionStatus? ToEnum(string value)
        {
            return value switch
            {
                "budget_exceeded" => InteractionStatus.BudgetExceeded,
                "cancelled" => InteractionStatus.Cancelled,
                "completed" => InteractionStatus.Completed,
                "failed" => InteractionStatus.Failed,
                "in_progress" => InteractionStatus.InProgress,
                "incomplete" => InteractionStatus.Incomplete,
                "queued" => InteractionStatus.Queued,
                "requires_action" => InteractionStatus.RequiresAction,
                _ => null,
            };
        }
    }
}