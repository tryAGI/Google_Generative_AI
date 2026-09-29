
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InteractionSSEStreamEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSSEEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.InteractionSSEEvent InteractionSSEEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSSEStreamEvent" /> class.
        /// </summary>
        /// <param name="interactionSSEEvent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionSSEStreamEvent(
            global::Google.Gemini.NextGen.InteractionSSEEvent interactionSSEEvent)
        {
            this.InteractionSSEEvent = interactionSSEEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSSEStreamEvent" /> class.
        /// </summary>
        public InteractionSSEStreamEvent()
        {
        }

    }
}