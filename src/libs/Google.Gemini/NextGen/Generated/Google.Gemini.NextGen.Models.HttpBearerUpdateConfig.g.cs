
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for updating HTTP Bearer token credentials.
    /// </summary>
    public sealed partial class HttpBearerUpdateConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Optional. Input only. The static bearer token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Optional. Header name to inject the token into. Defaults to<br/>
        /// 'Authorization'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Optional. Prefix to prepend to the token. Defaults to 'Bearer'. Set to ''<br/>
        /// for no prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBearerUpdateConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="token">
        /// Optional. Input only. The static bearer token. Write-only; never returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="headerName">
        /// Optional. Header name to inject the token into. Defaults to<br/>
        /// 'Authorization'.
        /// </param>
        /// <param name="prefix">
        /// Optional. Prefix to prepend to the token. Defaults to 'Bearer'. Set to ''<br/>
        /// for no prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpBearerUpdateConfig(
            object type,
            string? token,
            string? headerName,
            string? prefix)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Token = token;
            this.HeaderName = headerName;
            this.Prefix = prefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBearerUpdateConfig" /> class.
        /// </summary>
        public HttpBearerUpdateConfig()
        {
        }

    }
}