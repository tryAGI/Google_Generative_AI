
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request message for WebhookService.UpdateWebhook.
    /// </summary>
    public sealed partial class UpdateWebhookRequest
    {
        /// <summary>
        /// Required. The ID of the webhook to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional. The list of fields to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_mask")]
        public string? UpdateMask { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.WebhookUpdate Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Required. The ID of the webhook to update.
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookRequest(
            string id,
            global::Google.Gemini.NextGen.WebhookUpdate webhook,
            string? updateMask)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UpdateMask = updateMask;
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        public UpdateWebhookRequest()
        {
        }

    }
}