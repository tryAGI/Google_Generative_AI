
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
    /// </summary>
    public enum FunctionResponseScheduling
    {
        /// <summary>
        /// 
        /// </summary>
        SchedulingUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Silent,
        /// <summary>
        /// 
        /// </summary>
        WhenIdle,
        /// <summary>
        /// 
        /// </summary>
        Interrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionResponseSchedulingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResponseScheduling value)
        {
            return value switch
            {
                FunctionResponseScheduling.SchedulingUnspecified => "SCHEDULING_UNSPECIFIED",
                FunctionResponseScheduling.Silent => "SILENT",
                FunctionResponseScheduling.WhenIdle => "WHEN_IDLE",
                FunctionResponseScheduling.Interrupt => "INTERRUPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResponseScheduling? ToEnum(string value)
        {
            return value switch
            {
                "SCHEDULING_UNSPECIFIED" => FunctionResponseScheduling.SchedulingUnspecified,
                "SILENT" => FunctionResponseScheduling.Silent,
                "WHEN_IDLE" => FunctionResponseScheduling.WhenIdle,
                "INTERRUPT" => FunctionResponseScheduling.Interrupt,
                _ => null,
            };
        }
    }
}