
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for OAuth2 credentials with automatic token refresh.
    /// </summary>
    public sealed partial class OAuth2Config
    {
        /// <summary>
        /// Required. OAuth2 client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Required. Input only. OAuth2 client secret. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Required. Input only. OAuth2 refresh token. Write-only; never returned in responses.<br/>
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
        /// Required. OAuth2 token endpoint URL for refreshing access tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="OAuth2Config" /> class.
        /// </summary>
        /// <param name="clientId">
        /// Required. OAuth2 client ID.
        /// </param>
        /// <param name="id"></param>
        /// <param name="tokenUrl">
        /// Required. OAuth2 token endpoint URL for refreshing access tokens.
        /// </param>
        /// <param name="type"></param>
        /// <param name="clientSecret">
        /// Required. Input only. OAuth2 client secret. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="refreshToken">
        /// Required. Input only. OAuth2 refresh token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="scopes">
        /// Optional. List of OAuth2 scopes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2Config(
            string clientId,
            string id,
            string tokenUrl,
            object type,
            string? clientSecret,
            string? refreshToken,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RefreshToken = refreshToken;
            this.Scopes = scopes;
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Config" /> class.
        /// </summary>
        public OAuth2Config()
        {
        }

    }
}