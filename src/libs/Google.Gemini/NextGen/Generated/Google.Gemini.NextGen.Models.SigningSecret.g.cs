
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Represents a signing secret used to verify webhook payloads.
    /// </summary>
    public sealed partial class SigningSecret
    {
        /// <summary>
        /// Output only. The expiration date of the signing secret.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public global::System.DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Output only. The truncated version of the signing secret.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated_secret")]
        public string? TruncatedSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningSecret" /> class.
        /// </summary>
        /// <param name="expireTime">
        /// Output only. The expiration date of the signing secret.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="truncatedSecret">
        /// Output only. The truncated version of the signing secret.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SigningSecret(
            global::System.DateTime? expireTime,
            string? truncatedSecret)
        {
            this.ExpireTime = expireTime;
            this.TruncatedSecret = truncatedSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningSecret" /> class.
        /// </summary>
        public SigningSecret()
        {
        }

    }
}