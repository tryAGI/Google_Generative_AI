
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The state of the batch.<br/>
    /// Included only in responses
    /// </summary>
    public enum GenerateContentBatchState
    {
        /// <summary>
        /// 
        /// </summary>
        BatchStateUnspecified,
        /// <summary>
        /// 
        /// </summary>
        BatchStatePending,
        /// <summary>
        /// 
        /// </summary>
        BatchStateRunning,
        /// <summary>
        /// 
        /// </summary>
        BatchStateSucceeded,
        /// <summary>
        /// 
        /// </summary>
        BatchStateFailed,
        /// <summary>
        /// 
        /// </summary>
        BatchStateCancelled,
        /// <summary>
        /// 
        /// </summary>
        BatchStateExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateContentBatchStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateContentBatchState value)
        {
            return value switch
            {
                GenerateContentBatchState.BatchStateUnspecified => "BATCH_STATE_UNSPECIFIED",
                GenerateContentBatchState.BatchStatePending => "BATCH_STATE_PENDING",
                GenerateContentBatchState.BatchStateRunning => "BATCH_STATE_RUNNING",
                GenerateContentBatchState.BatchStateSucceeded => "BATCH_STATE_SUCCEEDED",
                GenerateContentBatchState.BatchStateFailed => "BATCH_STATE_FAILED",
                GenerateContentBatchState.BatchStateCancelled => "BATCH_STATE_CANCELLED",
                GenerateContentBatchState.BatchStateExpired => "BATCH_STATE_EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateContentBatchState? ToEnum(string value)
        {
            return value switch
            {
                "BATCH_STATE_UNSPECIFIED" => GenerateContentBatchState.BatchStateUnspecified,
                "BATCH_STATE_PENDING" => GenerateContentBatchState.BatchStatePending,
                "BATCH_STATE_RUNNING" => GenerateContentBatchState.BatchStateRunning,
                "BATCH_STATE_SUCCEEDED" => GenerateContentBatchState.BatchStateSucceeded,
                "BATCH_STATE_FAILED" => GenerateContentBatchState.BatchStateFailed,
                "BATCH_STATE_CANCELLED" => GenerateContentBatchState.BatchStateCancelled,
                "BATCH_STATE_EXPIRED" => GenerateContentBatchState.BatchStateExpired,
                _ => null,
            };
        }
    }
}