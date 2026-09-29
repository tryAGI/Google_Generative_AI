
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for HTTP Bearer token credentials.
    /// </summary>
    public sealed partial class HttpBearerConfig
    {
        /// <summary>
        /// Optional. Header name to inject the token into. Defaults to<br/>
        /// 'Authorization'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional. Prefix to prepend to the token. Defaults to 'Bearer'. Set to ''<br/>
        /// for no prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Required. Input only. The static bearer token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

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
        /// Initializes a new instance of the <see cref="HttpBearerConfig" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="headerName">
        /// Optional. Header name to inject the token into. Defaults to<br/>
        /// 'Authorization'.
        /// </param>
        /// <param name="prefix">
        /// Optional. Prefix to prepend to the token. Defaults to 'Bearer'. Set to ''<br/>
        /// for no prefix.
        /// </param>
        /// <param name="token">
        /// Required. Input only. The static bearer token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpBearerConfig(
            string id,
            object type,
            string? headerName,
            string? prefix,
            string? token)
        {
            this.HeaderName = headerName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Prefix = prefix;
            this.Token = token;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBearerConfig" /> class.
        /// </summary>
        public HttpBearerConfig()
        {
        }

    }
}