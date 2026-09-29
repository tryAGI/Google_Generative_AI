
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response message for WebhookService.RotateSigningSecret.
    /// </summary>
    public sealed partial class WebhookRotateSigningSecretResponse
    {
        /// <summary>
        /// Output only. The newly generated signing secret.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRotateSigningSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// Output only. The newly generated signing secret.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRotateSigningSecretResponse(
            string? secret)
        {
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRotateSigningSecretResponse" /> class.
        /// </summary>
        public WebhookRotateSigningSecretResponse()
        {
        }

    }
}