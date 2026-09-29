
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request for InteractionService.GetInteraction.
    /// </summary>
    public sealed partial class GetInteractionRequest
    {
        /// <summary>
        /// If true, includes the input in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_input")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IncludeInput { get; set; }

        /// <summary>
        /// If set, resumes the interaction stream from the chunk after the event<br/>
        /// marked by the event id. Can only be used if `stream` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_event_id")]
        public string? LastEventId { get; set; }

        /// <summary>
        /// Required. The name of the interaction to retrieve.<br/>
        /// Format: interactions/{interaction}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// If true, streams the interaction events as Server-Sent Events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInteractionRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the interaction to retrieve.<br/>
        /// Format: interactions/{interaction}
        /// </param>
        /// <param name="lastEventId">
        /// If set, resumes the interaction stream from the chunk after the event<br/>
        /// marked by the event id. Can only be used if `stream` is true.
        /// </param>
        /// <param name="stream">
        /// If true, streams the interaction events as Server-Sent Events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInteractionRequest(
            string name,
            string? lastEventId,
            bool? stream)
        {
            this.LastEventId = lastEventId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInteractionRequest" /> class.
        /// </summary>
        public GetInteractionRequest()
        {
        }

    }
}