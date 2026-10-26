
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for a custom environment.
    /// </summary>
    public sealed partial class EnvironmentConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Sources { get; set; }

        /// <summary>
        /// Network configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>? Network { get; set; }

        /// <summary>
        /// Optional. The environment ID for the interaction. If specified, the request will<br/>
        /// update the existing environment instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Environment variables to set in the sandbox environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>))]
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sources"></param>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="environmentId">
        /// Optional. The environment ID for the interaction. If specified, the request will<br/>
        /// update the existing environment instead of creating a new one.
        /// </param>
        /// <param name="env">
        /// Environment variables to set in the sandbox environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentConfig(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>? network,
            string? environmentId,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? env)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Sources = sources;
            this.Network = network;
            this.EnvironmentId = environmentId;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfig" /> class.
        /// </summary>
        public EnvironmentConfig()
        {
        }

    }
}