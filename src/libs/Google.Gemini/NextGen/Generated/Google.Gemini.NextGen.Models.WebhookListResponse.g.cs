
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response message for WebhookService.ListWebhooks.
    /// </summary>
    public sealed partial class WebhookListResponse
    {
        /// <summary>
        /// The webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Webhooks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page.<br/>
        /// If this field is omitted, there are no subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListResponse" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// The webhooks.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page.<br/>
        /// If this field is omitted, there are no subsequent pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookListResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? webhooks,
            string? nextPageToken)
        {
            this.Webhooks = webhooks;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListResponse" /> class.
        /// </summary>
        public WebhookListResponse()
        {
        }

    }
}