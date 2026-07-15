
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A request to create an ephemeral authentication token.
    /// </summary>
    public sealed partial class AuthToken
    {
        /// <summary>
        /// Optional. Input only. Immutable. The time after which new Live API sessions using the token resulting from this request will be rejected. If not set this defaults to 60 seconds in the future. If set, this value must be less than 20 hours in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newSessionExpireTime")]
        public string? NewSessionExpireTime { get; set; }

        /// <summary>
        /// Output only. Identifier. The token itself.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Message to be sent in the first (and only in the first) `BidiGenerateContentClientMessage`. Contains configuration that will apply for the duration of the streaming RPC. Clients should wait for a `BidiGenerateContentSetupComplete` message before sending any additional messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bidiGenerateContentSetup")]
        public global::Google.Gemini.BidiGenerateContentSetup? BidiGenerateContentSetup { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. An optional time after which, when using the resulting token, messages in BidiGenerateContent sessions will be rejected. (Gemini may preemptively close the session after this time.) If not set then this defaults to 30 minutes in the future. If set, this value must be less than 20 hours in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expireTime")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. If field_mask is empty, and `bidi_generate_content_setup` is not present, then the effective `BidiGenerateContentSetup` message is taken from the Live API connection. If field_mask is empty, and `bidi_generate_content_setup` _is_ present, then the effective `BidiGenerateContentSetup` message is taken entirely from `bidi_generate_content_setup` in this request. The setup message from the Live API connection is ignored. If field_mask is not empty, then the corresponding fields from `bidi_generate_content_setup` will overwrite the fields from the setup message in the Live API connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldMask")]
        public string? FieldMask { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. The number of times the token can be used. If this value is zero then no limit is applied. Resuming a Live API session does not count as a use. If unspecified, the default is 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uses")]
        public int? Uses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthToken" /> class.
        /// </summary>
        /// <param name="newSessionExpireTime">
        /// Optional. Input only. Immutable. The time after which new Live API sessions using the token resulting from this request will be rejected. If not set this defaults to 60 seconds in the future. If set, this value must be less than 20 hours in the future.
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. The token itself.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="bidiGenerateContentSetup">
        /// Message to be sent in the first (and only in the first) `BidiGenerateContentClientMessage`. Contains configuration that will apply for the duration of the streaming RPC. Clients should wait for a `BidiGenerateContentSetupComplete` message before sending any additional messages.
        /// </param>
        /// <param name="expireTime">
        /// Optional. Input only. Immutable. An optional time after which, when using the resulting token, messages in BidiGenerateContent sessions will be rejected. (Gemini may preemptively close the session after this time.) If not set then this defaults to 30 minutes in the future. If set, this value must be less than 20 hours in the future.
        /// </param>
        /// <param name="fieldMask">
        /// Optional. Input only. Immutable. If field_mask is empty, and `bidi_generate_content_setup` is not present, then the effective `BidiGenerateContentSetup` message is taken from the Live API connection. If field_mask is empty, and `bidi_generate_content_setup` _is_ present, then the effective `BidiGenerateContentSetup` message is taken entirely from `bidi_generate_content_setup` in this request. The setup message from the Live API connection is ignored. If field_mask is not empty, then the corresponding fields from `bidi_generate_content_setup` will overwrite the fields from the setup message in the Live API connection.
        /// </param>
        /// <param name="uses">
        /// Optional. Input only. Immutable. The number of times the token can be used. If this value is zero then no limit is applied. Resuming a Live API session does not count as a use. If unspecified, the default is 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthToken(
            string? newSessionExpireTime,
            string? name,
            global::Google.Gemini.BidiGenerateContentSetup? bidiGenerateContentSetup,
            string? expireTime,
            string? fieldMask,
            int? uses)
        {
            this.NewSessionExpireTime = newSessionExpireTime;
            this.Name = name;
            this.BidiGenerateContentSetup = bidiGenerateContentSetup;
            this.ExpireTime = expireTime;
            this.FieldMask = fieldMask;
            this.Uses = uses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthToken" /> class.
        /// </summary>
        public AuthToken()
        {
        }

    }
}