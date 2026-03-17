
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Outcome of the code execution.
    /// </summary>
    public enum CodeExecutionResultOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        OutcomeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        OutcomeOk,
        /// <summary>
        /// 
        /// </summary>
        OutcomeFailed,
        /// <summary>
        /// 
        /// </summary>
        OutcomeDeadlineExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionResultOutcome value)
        {
            return value switch
            {
                CodeExecutionResultOutcome.OutcomeUnspecified => "OUTCOME_UNSPECIFIED",
                CodeExecutionResultOutcome.OutcomeOk => "OUTCOME_OK",
                CodeExecutionResultOutcome.OutcomeFailed => "OUTCOME_FAILED",
                CodeExecutionResultOutcome.OutcomeDeadlineExceeded => "OUTCOME_DEADLINE_EXCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "OUTCOME_UNSPECIFIED" => CodeExecutionResultOutcome.OutcomeUnspecified,
                "OUTCOME_OK" => CodeExecutionResultOutcome.OutcomeOk,
                "OUTCOME_FAILED" => CodeExecutionResultOutcome.OutcomeFailed,
                "OUTCOME_DEADLINE_EXCEEDED" => CodeExecutionResultOutcome.OutcomeDeadlineExceeded,
                _ => null,
            };
        }
    }
}