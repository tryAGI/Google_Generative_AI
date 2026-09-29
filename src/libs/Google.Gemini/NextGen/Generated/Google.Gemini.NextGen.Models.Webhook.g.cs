
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A Webhook resource.
    /// </summary>
    public sealed partial class Webhook
    {
        /// <summary>
        /// Output only. The timestamp when the webhook was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Output only. The ID of the webhook.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Optional. The user-provided name of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Output only. The new signing secret for the webhook. Only populated on create.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_signing_secret")]
        public string? NewSigningSecret { get; set; }

        /// <summary>
        /// Output only. The signing secrets associated with this webhook.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secrets")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? SigningSecrets { get; set; }

        /// <summary>
        /// Output only. The state of the webhook.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookStateJsonConverter))]
        public global::Google.Gemini.NextGen.WebhookState? State { get; set; }

        /// <summary>
        /// Required. The events that the webhook is subscribed to.<br/>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent> SubscribedEvents { get; set; }

        /// <summary>
        /// Output only. The timestamp when the webhook was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Required. The URI to which webhook events will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="subscribedEvents">
        /// Required. The events that the webhook is subscribed to.<br/>
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
        /// Required. The URI to which webhook events will be sent.
        /// </param>
        /// <param name="createTime">
        /// Output only. The timestamp when the webhook was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Output only. The ID of the webhook.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Optional. The user-provided name of the webhook.
        /// </param>
        /// <param name="newSigningSecret">
        /// Output only. The new signing secret for the webhook. Only populated on create.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="signingSecrets">
        /// Output only. The signing secrets associated with this webhook.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Output only. The state of the webhook.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The timestamp when the webhook was last updated.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webhook(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent> subscribedEvents,
            string uri,
            global::System.DateTime? createTime,
            string? id,
            string? name,
            string? newSigningSecret,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? signingSecrets,
            global::Google.Gemini.NextGen.WebhookState? state,
            global::System.DateTime? updateTime)
        {
            this.CreateTime = createTime;
            this.Id = id;
            this.Name = name;
            this.NewSigningSecret = newSigningSecret;
            this.SigningSecrets = signingSecrets;
            this.State = state;
            this.SubscribedEvents = subscribedEvents ?? throw new global::System.ArgumentNullException(nameof(subscribedEvents));
            this.UpdateTime = updateTime;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        public Webhook()
        {
        }

    }
}