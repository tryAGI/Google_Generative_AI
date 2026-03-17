
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Operator applied to the given key-value pair to trigger the condition.
    /// </summary>
    public enum ConditionOperation
    {
        /// <summary>
        /// 
        /// </summary>
        OperatorUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Less,
        /// <summary>
        /// 
        /// </summary>
        LessEqual,
        /// <summary>
        /// 
        /// </summary>
        Equal,
        /// <summary>
        /// 
        /// </summary>
        GreaterEqual,
        /// <summary>
        /// 
        /// </summary>
        Greater,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        Includes,
        /// <summary>
        /// 
        /// </summary>
        Excludes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionOperation value)
        {
            return value switch
            {
                ConditionOperation.OperatorUnspecified => "OPERATOR_UNSPECIFIED",
                ConditionOperation.Less => "LESS",
                ConditionOperation.LessEqual => "LESS_EQUAL",
                ConditionOperation.Equal => "EQUAL",
                ConditionOperation.GreaterEqual => "GREATER_EQUAL",
                ConditionOperation.Greater => "GREATER",
                ConditionOperation.NotEqual => "NOT_EQUAL",
                ConditionOperation.Includes => "INCLUDES",
                ConditionOperation.Excludes => "EXCLUDES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionOperation? ToEnum(string value)
        {
            return value switch
            {
                "OPERATOR_UNSPECIFIED" => ConditionOperation.OperatorUnspecified,
                "LESS" => ConditionOperation.Less,
                "LESS_EQUAL" => ConditionOperation.LessEqual,
                "EQUAL" => ConditionOperation.Equal,
                "GREATER_EQUAL" => ConditionOperation.GreaterEqual,
                "GREATER" => ConditionOperation.Greater,
                "NOT_EQUAL" => ConditionOperation.NotEqual,
                "INCLUDES" => ConditionOperation.Includes,
                "EXCLUDES" => ConditionOperation.Excludes,
                _ => null,
            };
        }
    }
}