
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for a custom environment.
    /// </summary>
    public sealed partial class EnvironmentConfig
    {
        /// <summary>
        /// Optional. The environment ID for the interaction. If specified, the request will update the existing environment instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Network egress configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkAllowlist")]
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? NetworkAllowlist { get; set; }

        /// <summary>
        /// Network egress mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentConfigNetworkModeJsonConverter))]
        public global::Google.Gemini.EnvironmentConfigNetworkMode? NetworkMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfig" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// Optional. The environment ID for the interaction. If specified, the request will update the existing environment instead of creating a new one.
        /// </param>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentConfig(
            string? environmentId,
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist,
            global::Google.Gemini.EnvironmentConfigNetworkMode? networkMode,
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources)
        {
            this.EnvironmentId = environmentId;
            this.NetworkAllowlist = networkAllowlist;
            this.NetworkMode = networkMode;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfig" /> class.
        /// </summary>
        public EnvironmentConfig()
        {
        }

    }
}