
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Output only. The status of the interaction.<br/>
    /// Included only in responses
    /// </summary>
    public enum InteractionSseEventInteractionStatus
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
    public static class InteractionSseEventInteractionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionSseEventInteractionStatus value)
        {
            return value switch
            {
                InteractionSseEventInteractionStatus.BudgetExceeded => "budget_exceeded",
                InteractionSseEventInteractionStatus.Cancelled => "cancelled",
                InteractionSseEventInteractionStatus.Completed => "completed",
                InteractionSseEventInteractionStatus.Failed => "failed",
                InteractionSseEventInteractionStatus.InProgress => "in_progress",
                InteractionSseEventInteractionStatus.Incomplete => "incomplete",
                InteractionSseEventInteractionStatus.Queued => "queued",
                InteractionSseEventInteractionStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionSseEventInteractionStatus? ToEnum(string value)
        {
            return value switch
            {
                "budget_exceeded" => InteractionSseEventInteractionStatus.BudgetExceeded,
                "cancelled" => InteractionSseEventInteractionStatus.Cancelled,
                "completed" => InteractionSseEventInteractionStatus.Completed,
                "failed" => InteractionSseEventInteractionStatus.Failed,
                "in_progress" => InteractionSseEventInteractionStatus.InProgress,
                "incomplete" => InteractionSseEventInteractionStatus.Incomplete,
                "queued" => InteractionSseEventInteractionStatus.Queued,
                "requires_action" => InteractionSseEventInteractionStatus.RequiresAction,
                _ => null,
            };
        }
    }
}