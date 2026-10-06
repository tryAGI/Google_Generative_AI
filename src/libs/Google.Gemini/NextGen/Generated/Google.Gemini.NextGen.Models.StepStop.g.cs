
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Example: {"event_type":"step.stop","index":0}
    /// </summary>
    public sealed partial class StepStop
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_usage")]
        public global::Google.Gemini.NextGen.Usage? StepUsage { get; set; }

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
        /// Initializes a new instance of the <see cref="StepStop" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="index"></param>
        /// <param name="eventId">
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </param>
        /// <param name="stepUsage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepStop(
            object eventType,
            int index,
            string? eventId,
            global::Google.Gemini.NextGen.Usage? stepUsage,
            global::Google.Gemini.NextGen.Usage? usage)
        {
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Index = index;
            this.StepUsage = stepUsage;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepStop" /> class.
        /// </summary>
        public StepStop()
        {
        }

    }
}