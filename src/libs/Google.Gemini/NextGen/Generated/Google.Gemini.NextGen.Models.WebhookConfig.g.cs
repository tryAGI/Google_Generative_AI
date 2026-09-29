
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Message for configuring webhook events for a request.
    /// </summary>
    public sealed partial class WebhookConfig
    {
        /// <summary>
        /// Optional. If set, these webhook URIs will be used for webhook events instead of the<br/>
        /// registered webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// Optional. The user metadata that will be returned on each event emission to the<br/>
        /// webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfig" /> class.
        /// </summary>
        /// <param name="uris">
        /// Optional. If set, these webhook URIs will be used for webhook events instead of the<br/>
        /// registered webhooks.
        /// </param>
        /// <param name="userMetadata">
        /// Optional. The user metadata that will be returned on each event emission to the<br/>
        /// webhooks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfig(
            global::System.Collections.Generic.IList<string>? uris,
            object? userMetadata)
        {
            this.Uris = uris;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfig" /> class.
        /// </summary>
        public WebhookConfig()
        {
        }

    }
}