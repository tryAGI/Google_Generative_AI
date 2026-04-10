
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Stats about the batch.
    /// </summary>
    public sealed partial class BatchStats
    {
        /// <summary>
        /// Output only. The number of requests that failed to be processed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedRequestCount")]
        public string? FailedRequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests that were successfully processed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successfulRequestCount")]
        public string? SuccessfulRequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCount")]
        public string? RequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests that are still pending processing.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingRequestCount")]
        public string? PendingRequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        /// <param name="failedRequestCount">
        /// Output only. The number of requests that failed to be processed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="successfulRequestCount">
        /// Output only. The number of requests that were successfully processed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requestCount">
        /// Output only. The number of requests in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pendingRequestCount">
        /// Output only. The number of requests that are still pending processing.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchStats(
            string? failedRequestCount,
            string? successfulRequestCount,
            string? requestCount,
            string? pendingRequestCount)
        {
            this.FailedRequestCount = failedRequestCount;
            this.SuccessfulRequestCount = successfulRequestCount;
            this.RequestCount = requestCount;
            this.PendingRequestCount = pendingRequestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        public BatchStats()
        {
        }
    }
}