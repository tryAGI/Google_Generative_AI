
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. The state of the batch.<br/>
    /// Included only in responses
    /// </summary>
    public enum EmbedContentBatchState
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
    public static class EmbedContentBatchStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentBatchState value)
        {
            return value switch
            {
                EmbedContentBatchState.BatchStateUnspecified => "BATCH_STATE_UNSPECIFIED",
                EmbedContentBatchState.BatchStatePending => "BATCH_STATE_PENDING",
                EmbedContentBatchState.BatchStateRunning => "BATCH_STATE_RUNNING",
                EmbedContentBatchState.BatchStateSucceeded => "BATCH_STATE_SUCCEEDED",
                EmbedContentBatchState.BatchStateFailed => "BATCH_STATE_FAILED",
                EmbedContentBatchState.BatchStateCancelled => "BATCH_STATE_CANCELLED",
                EmbedContentBatchState.BatchStateExpired => "BATCH_STATE_EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentBatchState? ToEnum(string value)
        {
            return value switch
            {
                "BATCH_STATE_UNSPECIFIED" => EmbedContentBatchState.BatchStateUnspecified,
                "BATCH_STATE_PENDING" => EmbedContentBatchState.BatchStatePending,
                "BATCH_STATE_RUNNING" => EmbedContentBatchState.BatchStateRunning,
                "BATCH_STATE_SUCCEEDED" => EmbedContentBatchState.BatchStateSucceeded,
                "BATCH_STATE_FAILED" => EmbedContentBatchState.BatchStateFailed,
                "BATCH_STATE_CANCELLED" => EmbedContentBatchState.BatchStateCancelled,
                "BATCH_STATE_EXPIRED" => EmbedContentBatchState.BatchStateExpired,
                _ => null,
            };
        }
    }
}