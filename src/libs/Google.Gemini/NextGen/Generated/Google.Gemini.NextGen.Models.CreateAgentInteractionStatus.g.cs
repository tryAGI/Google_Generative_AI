
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Output only. The status of the interaction.<br/>
    /// Included only in responses
    /// </summary>
    public enum CreateAgentInteractionStatus
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
    public static class CreateAgentInteractionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentInteractionStatus value)
        {
            return value switch
            {
                CreateAgentInteractionStatus.BudgetExceeded => "budget_exceeded",
                CreateAgentInteractionStatus.Cancelled => "cancelled",
                CreateAgentInteractionStatus.Completed => "completed",
                CreateAgentInteractionStatus.Failed => "failed",
                CreateAgentInteractionStatus.InProgress => "in_progress",
                CreateAgentInteractionStatus.Incomplete => "incomplete",
                CreateAgentInteractionStatus.Queued => "queued",
                CreateAgentInteractionStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentInteractionStatus? ToEnum(string value)
        {
            return value switch
            {
                "budget_exceeded" => CreateAgentInteractionStatus.BudgetExceeded,
                "cancelled" => CreateAgentInteractionStatus.Cancelled,
                "completed" => CreateAgentInteractionStatus.Completed,
                "failed" => CreateAgentInteractionStatus.Failed,
                "in_progress" => CreateAgentInteractionStatus.InProgress,
                "incomplete" => CreateAgentInteractionStatus.Incomplete,
                "queued" => CreateAgentInteractionStatus.Queued,
                "requires_action" => CreateAgentInteractionStatus.RequiresAction,
                _ => null,
            };
        }
    }
}