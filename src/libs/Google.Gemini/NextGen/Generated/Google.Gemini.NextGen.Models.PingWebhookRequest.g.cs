
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request message for WebhookService.PingWebhook.
    /// </summary>
    public sealed partial class PingWebhookRequest
    {
        /// <summary>
        /// Required. The ID of the webhook to ping.<br/>
        /// Format: `{webhook_id}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PingWebhookRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Required. The ID of the webhook to ping.<br/>
        /// Format: `{webhook_id}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PingWebhookRequest(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingWebhookRequest" /> class.
        /// </summary>
        public PingWebhookRequest()
        {
        }

    }
}