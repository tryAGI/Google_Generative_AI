
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepStart
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
        /// A step in the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.StepJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.Step Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepStart" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="index"></param>
        /// <param name="step">
        /// A step in the interaction.
        /// </param>
        /// <param name="eventId">
        /// The event_id token to be used to resume the interaction stream, from<br/>
        /// this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepStart(
            object eventType,
            int index,
            global::Google.Gemini.NextGen.Step step,
            string? eventId)
        {
            this.EventId = eventId;
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Index = index;
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepStart" /> class.
        /// </summary>
        public StepStart()
        {
        }

    }
}