
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum InteractionStatusUpdateStatus
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
    public static class InteractionStatusUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionStatusUpdateStatus value)
        {
            return value switch
            {
                InteractionStatusUpdateStatus.BudgetExceeded => "budget_exceeded",
                InteractionStatusUpdateStatus.Cancelled => "cancelled",
                InteractionStatusUpdateStatus.Completed => "completed",
                InteractionStatusUpdateStatus.Failed => "failed",
                InteractionStatusUpdateStatus.InProgress => "in_progress",
                InteractionStatusUpdateStatus.Incomplete => "incomplete",
                InteractionStatusUpdateStatus.Queued => "queued",
                InteractionStatusUpdateStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionStatusUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "budget_exceeded" => InteractionStatusUpdateStatus.BudgetExceeded,
                "cancelled" => InteractionStatusUpdateStatus.Cancelled,
                "completed" => InteractionStatusUpdateStatus.Completed,
                "failed" => InteractionStatusUpdateStatus.Failed,
                "in_progress" => InteractionStatusUpdateStatus.InProgress,
                "incomplete" => InteractionStatusUpdateStatus.Incomplete,
                "queued" => InteractionStatusUpdateStatus.Queued,
                "requires_action" => InteractionStatusUpdateStatus.RequiresAction,
                _ => null,
            };
        }
    }
}