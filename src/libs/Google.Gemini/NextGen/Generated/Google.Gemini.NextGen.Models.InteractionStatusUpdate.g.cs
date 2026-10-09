
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Example: {"event_type":"interaction.status_update","interaction_id":"v1_ChdTMjQ0YWJ5TUF1TzcxZThQdjRpcnFRcxIXUzI0NGFieU1BdU83MWU4UHY0aXJxUXM","status":"in_progress"}
    /// </summary>
    public sealed partial class InteractionStatusUpdate
    {
        /// <summary>
        /// An optional opaque continuation token used to resume decoding from the<br/>
        /// latest checkpoint after a disconnected stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuation_token")]
        public byte[]? ContinuationToken { get; set; }

        /// <summary>
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object EventType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InteractionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusUpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.InteractionStatusUpdateStatus Status { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Google.Gemini.NextGen.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionStatusUpdate" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="interactionId"></param>
        /// <param name="status"></param>
        /// <param name="continuationToken">
        /// An optional opaque continuation token used to resume decoding from the<br/>
        /// latest checkpoint after a disconnected stream.
        /// </param>
        /// <param name="eventId">
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionStatusUpdate(
            object eventType,
            string interactionId,
            global::Google.Gemini.NextGen.InteractionStatusUpdateStatus status,
            byte[]? continuationToken,
            string? eventId,
            global::Google.Gemini.NextGen.Usage? usage)
        {
            this.ContinuationToken = continuationToken;
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.InteractionId = interactionId ?? throw new global::System.ArgumentNullException(nameof(interactionId));
            this.Status = status;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionStatusUpdate" /> class.
        /// </summary>
        public InteractionStatusUpdate()
        {
        }

    }
}