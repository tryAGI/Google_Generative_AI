
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for updating OAuth2 credentials.
    /// </summary>
    public sealed partial class OAuth2UpdateConfig
    {
        /// <summary>
        /// Optional. OAuth2 client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Optional. Input only. OAuth2 client secret. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Optional. Input only. OAuth2 refresh token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Optional. List of OAuth2 scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Optional. OAuth2 token endpoint URL for refreshing access tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        public string? TokenUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2UpdateConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="clientId">
        /// Optional. OAuth2 client ID.
        /// </param>
        /// <param name="clientSecret">
        /// Optional. Input only. OAuth2 client secret. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="refreshToken">
        /// Optional. Input only. OAuth2 refresh token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="scopes">
        /// Optional. List of OAuth2 scopes.
        /// </param>
        /// <param name="tokenUrl">
        /// Optional. OAuth2 token endpoint URL for refreshing access tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2UpdateConfig(
            object type,
            string? clientId,
            string? clientSecret,
            string? refreshToken,
            global::System.Collections.Generic.IList<string>? scopes,
            string? tokenUrl)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.RefreshToken = refreshToken;
            this.Scopes = scopes;
            this.TokenUrl = tokenUrl;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2UpdateConfig" /> class.
        /// </summary>
        public OAuth2UpdateConfig()
        {
        }

    }
}