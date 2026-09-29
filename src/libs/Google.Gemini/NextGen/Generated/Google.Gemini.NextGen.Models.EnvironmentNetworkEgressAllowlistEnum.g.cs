
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Outbound networking configuration for the sandbox. When specified, restricts which external domains the sandbox can reach. Omit entirely to allow all outbound traffic with no header injection.
    /// </summary>
    public sealed partial class EnvironmentNetworkEgressAllowlistEnum
    {
        /// <summary>
        /// List of allowed outbound domains. Only requests to listed domains are permitted. Use [{'domain': '*'}] to allow all domains while still injecting headers on specific ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlist")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>? Allowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkEgressAllowlistEnum" /> class.
        /// </summary>
        /// <param name="allowlist">
        /// List of allowed outbound domains. Only requests to listed domains are permitted. Use [{'domain': '*'}] to allow all domains while still injecting headers on specific ones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentNetworkEgressAllowlistEnum(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>? allowlist)
        {
            this.Allowlist = allowlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkEgressAllowlistEnum" /> class.
        /// </summary>
        public EnvironmentNetworkEgressAllowlistEnum()
        {
        }

    }
}