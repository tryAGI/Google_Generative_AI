
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Signals that the Interaction completed. Sent when the Interaction receives<br/>
    /// Complete/Cancel or naturally terminates. No more input can be sent to the<br/>
    /// Interaction after this.
    /// </summary>
    public sealed partial class InteractionCompletedEvent
    {
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
        /// Partial interaction resource emitted by interaction lifecycle SSE events.<br/>
        /// Streaming lifecycle payloads may omit fields that are only available on<br/>
        /// full non-streaming Interaction responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.InteractionSseEventInteraction Interaction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionCompletedEvent" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="interaction">
        /// Partial interaction resource emitted by interaction lifecycle SSE events.<br/>
        /// Streaming lifecycle payloads may omit fields that are only available on<br/>
        /// full non-streaming Interaction responses.
        /// </param>
        /// <param name="eventId">
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionCompletedEvent(
            object eventType,
            global::Google.Gemini.NextGen.InteractionSseEventInteraction interaction,
            string? eventId)
        {
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Interaction = interaction ?? throw new global::System.ArgumentNullException(nameof(interaction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionCompletedEvent" /> class.
        /// </summary>
        public InteractionCompletedEvent()
        {
        }

    }
}