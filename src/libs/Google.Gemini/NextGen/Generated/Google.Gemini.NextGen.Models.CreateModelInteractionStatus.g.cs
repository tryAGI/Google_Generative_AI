
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Output only. The status of the interaction.<br/>
    /// Included only in responses
    /// </summary>
    public enum CreateModelInteractionStatus
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
    public static class CreateModelInteractionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelInteractionStatus value)
        {
            return value switch
            {
                CreateModelInteractionStatus.BudgetExceeded => "budget_exceeded",
                CreateModelInteractionStatus.Cancelled => "cancelled",
                CreateModelInteractionStatus.Completed => "completed",
                CreateModelInteractionStatus.Failed => "failed",
                CreateModelInteractionStatus.InProgress => "in_progress",
                CreateModelInteractionStatus.Incomplete => "incomplete",
                CreateModelInteractionStatus.Queued => "queued",
                CreateModelInteractionStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelInteractionStatus? ToEnum(string value)
        {
            return value switch
            {
                "budget_exceeded" => CreateModelInteractionStatus.BudgetExceeded,
                "cancelled" => CreateModelInteractionStatus.Cancelled,
                "completed" => CreateModelInteractionStatus.Completed,
                "failed" => CreateModelInteractionStatus.Failed,
                "in_progress" => CreateModelInteractionStatus.InProgress,
                "incomplete" => CreateModelInteractionStatus.Incomplete,
                "queued" => CreateModelInteractionStatus.Queued,
                "requires_action" => CreateModelInteractionStatus.RequiresAction,
                _ => null,
            };
        }
    }
}