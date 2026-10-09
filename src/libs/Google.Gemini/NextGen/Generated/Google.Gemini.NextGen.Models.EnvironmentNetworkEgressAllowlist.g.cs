
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Network egress configuration for the environment.<br/>
    /// Example: {"allowlist":[{"domain":"github.com","transform":[{"Authorization":"Bearer your-token"}]},{"domain":"*.googleapis.com"}]}
    /// </summary>
    public sealed partial class EnvironmentNetworkEgressAllowlist
    {
        /// <summary>
        /// List of allowed domains and their configurations. Set to `"disabled"`<br/>
        /// to block all network egress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlist")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>))]
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Allowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkEgressAllowlist" /> class.
        /// </summary>
        /// <param name="allowlist">
        /// List of allowed domains and their configurations. Set to `"disabled"`<br/>
        /// to block all network egress.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentNetworkEgressAllowlist(
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? allowlist)
        {
            this.Allowlist = allowlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkEgressAllowlist" /> class.
        /// </summary>
        public EnvironmentNetworkEgressAllowlist()
        {
        }

    }
}