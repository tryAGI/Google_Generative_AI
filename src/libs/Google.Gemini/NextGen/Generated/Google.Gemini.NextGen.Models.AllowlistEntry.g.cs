
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A single domain allowlist rule with optional header injection.
    /// </summary>
    public sealed partial class AllowlistEntry
    {
        /// <summary>
        /// Optional. Reference to a server-managed Credential resource by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Domain to allow outbound requests to. Supports wildcards (e.g.<br/>
        /// '*.googleapis.com'). Use '*' to allow all domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Headers to inject on all outbound requests matching this domain. Accepts a single dict or a list of dicts. The egress proxy injects these automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>))]
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>? Transform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistEntry" /> class.
        /// </summary>
        /// <param name="domain">
        /// Domain to allow outbound requests to. Supports wildcards (e.g.<br/>
        /// '*.googleapis.com'). Use '*' to allow all domains.
        /// </param>
        /// <param name="credential">
        /// Optional. Reference to a server-managed Credential resource by ID.
        /// </param>
        /// <param name="transform">
        /// Headers to inject on all outbound requests matching this domain. Accepts a single dict or a list of dicts. The egress proxy injects these automatically.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowlistEntry(
            string domain,
            string? credential,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>? transform)
        {
            this.Credential = credential;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Transform = transform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistEntry" /> class.
        /// </summary>
        public AllowlistEntry()
        {
        }

    }
}