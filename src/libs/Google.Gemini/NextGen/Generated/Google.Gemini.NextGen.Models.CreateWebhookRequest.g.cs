
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request message for WebhookService.CreateWebhook.
    /// </summary>
    public sealed partial class CreateWebhookRequest
    {
        /// <summary>
        /// A Webhook resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.Webhook Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="webhook">
        /// A Webhook resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookRequest(
            global::Google.Gemini.NextGen.Webhook webhook)
        {
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        public CreateWebhookRequest()
        {
        }

    }
}