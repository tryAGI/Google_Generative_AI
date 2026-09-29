
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookUpdate
    {
        /// <summary>
        /// Optional. The user-provided name of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. The state of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateStateJsonConverter))]
        public global::Google.Gemini.NextGen.WebhookUpdateState? State { get; set; }

        /// <summary>
        /// Optional. The events that the webhook is subscribed to.<br/>
        /// Available events:<br/>
        /// - batch.succeeded<br/>
        /// - batch.expired<br/>
        /// - batch.failed<br/>
        /// - interaction.requires_action<br/>
        /// - interaction.completed<br/>
        /// - interaction.failed<br/>
        /// - video.generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribed_events")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? SubscribedEvents { get; set; }

        /// <summary>
        /// Optional. The URI to which webhook events will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional. The user-provided name of the webhook.
        /// </param>
        /// <param name="state">
        /// Optional. The state of the webhook.
        /// </param>
        /// <param name="subscribedEvents">
        /// Optional. The events that the webhook is subscribed to.<br/>
        /// Available events:<br/>
        /// - batch.succeeded<br/>
        /// - batch.expired<br/>
        /// - batch.failed<br/>
        /// - interaction.requires_action<br/>
        /// - interaction.completed<br/>
        /// - interaction.failed<br/>
        /// - video.generated
        /// </param>
        /// <param name="uri">
        /// Optional. The URI to which webhook events will be sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookUpdate(
            string? name,
            global::Google.Gemini.NextGen.WebhookUpdateState? state,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? subscribedEvents,
            string? uri)
        {
            this.Name = name;
            this.State = state;
            this.SubscribedEvents = subscribedEvents;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdate" /> class.
        /// </summary>
        public WebhookUpdate()
        {
        }

    }
}