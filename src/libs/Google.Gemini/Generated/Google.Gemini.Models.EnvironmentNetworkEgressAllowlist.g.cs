
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Network egress configuration for the environment.
    /// </summary>
    public sealed partial class EnvironmentNetworkEgressAllowlist
    {
        /// <summary>
        /// List of allowed domains and their configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlist")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Allowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkEgressAllowlist" /> class.
        /// </summary>
        /// <param name="allowlist">
        /// List of allowed domains and their configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentNetworkEgressAllowlist(
            global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? allowlist)
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