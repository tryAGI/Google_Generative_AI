
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request message for WebhookService.RotateSigningSecret.
    /// </summary>
    public sealed partial class RotateSigningSecretRequest
    {
        /// <summary>
        /// Required. The ID of the webhook for which to generate a signing secret.<br/>
        /// Format: `{webhook_id}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional. The revocation behavior for previous signing secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revocation_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.RotateSigningSecretRequestRevocationBehaviorJsonConverter))]
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? RevocationBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateSigningSecretRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Required. The ID of the webhook for which to generate a signing secret.<br/>
        /// Format: `{webhook_id}`
        /// </param>
        /// <param name="revocationBehavior">
        /// Optional. The revocation behavior for previous signing secrets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateSigningSecretRequest(
            string id,
            global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? revocationBehavior)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RevocationBehavior = revocationBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateSigningSecretRequest" /> class.
        /// </summary>
        public RotateSigningSecretRequest()
        {
        }

    }
}