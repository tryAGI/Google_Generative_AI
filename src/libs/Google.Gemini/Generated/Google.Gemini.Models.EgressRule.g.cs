
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A network egress rule that controls which external domains the environment is allowed to reach. Each rule identifies a target domain and, optionally, a set of HTTP headers to inject into every matching outbound request.
    /// </summary>
    public sealed partial class EgressRule
    {
        /// <summary>
        /// Headers to inject into requests matching this rule. Key: header name (e.g., "Authorization"). Value: header value (e.g., "Bearer your-token").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::System.Collections.Generic.Dictionary<string, string>? Transform { get; set; }

        /// <summary>
        /// The domain pattern to match for this rule. Use an exact hostname (e.g., `github.com`), a wildcard prefix (e.g., `*.googleapis.com`), or `*` to match all domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRule" /> class.
        /// </summary>
        /// <param name="transform">
        /// Headers to inject into requests matching this rule. Key: header name (e.g., "Authorization"). Value: header value (e.g., "Bearer your-token").
        /// </param>
        /// <param name="domain">
        /// The domain pattern to match for this rule. Use an exact hostname (e.g., `github.com`), a wildcard prefix (e.g., `*.googleapis.com`), or `*` to match all domains.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EgressRule(
            global::System.Collections.Generic.Dictionary<string, string>? transform,
            string? domain)
        {
            this.Transform = transform;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRule" /> class.
        /// </summary>
        public EgressRule()
        {
        }

    }
}