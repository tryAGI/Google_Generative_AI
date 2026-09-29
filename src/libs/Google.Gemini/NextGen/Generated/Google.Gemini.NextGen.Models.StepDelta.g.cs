
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.StepDeltaDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.StepDeltaData Delta { get; set; }

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
        /// Optional metadata accompanying ANY streamed event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepDelta" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="eventType"></param>
        /// <param name="index"></param>
        /// <param name="eventId">
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata accompanying ANY streamed event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepDelta(
            global::Google.Gemini.NextGen.StepDeltaData delta,
            object eventType,
            int index,
            string? eventId,
            global::Google.Gemini.NextGen.StepDeltaMetadata? metadata)
        {
            this.Delta = delta;
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Index = index;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepDelta" /> class.
        /// </summary>
        public StepDelta()
        {
        }

    }
}