
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A single domain allowlist rule with optional header injection.
    /// </summary>
    public sealed partial class EgressRule
    {
        /// <summary>
        /// Optional. Reference to a server-managed Credential resource by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Domain to allow outbound requests to. Supports wildcards (e.g. '*.googleapis.com'). Use '*' to allow all domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Headers to inject into requests matching this rule. Key: header name (e.g., "Authorization"). Value: header value (e.g., "Bearer your-token").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::System.Collections.Generic.Dictionary<string, string>? Transform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRule" /> class.
        /// </summary>
        /// <param name="credential">
        /// Optional. Reference to a server-managed Credential resource by ID.
        /// </param>
        /// <param name="domain">
        /// Domain to allow outbound requests to. Supports wildcards (e.g. '*.googleapis.com'). Use '*' to allow all domains.
        /// </param>
        /// <param name="transform">
        /// Headers to inject into requests matching this rule. Key: header name (e.g., "Authorization"). Value: header value (e.g., "Bearer your-token").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EgressRule(
            string? credential,
            string? domain,
            global::System.Collections.Generic.Dictionary<string, string>? transform)
        {
            this.Credential = credential;
            this.Domain = domain;
            this.Transform = transform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRule" /> class.
        /// </summary>
        public EgressRule()
        {
        }

    }
}