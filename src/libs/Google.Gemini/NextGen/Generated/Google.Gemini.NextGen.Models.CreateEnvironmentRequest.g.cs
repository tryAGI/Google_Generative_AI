
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request for creating an environment.
    /// </summary>
    public sealed partial class CreateEnvironmentRequest
    {
        /// <summary>
        /// Network configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Network { get; set; }

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Sources { get; set; }

        /// <summary>
        /// Environment variables to set in the sandbox environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>))]
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Env { get; set; }

        /// <summary>
        /// The compute lifecycle mode for this environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.CreateEnvironmentRequestModeJsonConverter))]
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestMode? Mode { get; set; }

        /// <summary>
        /// Optional. Arbitrary customer-defined JSON configuration passed through<br/>
        /// to the self-hosted environment poller. Only supported when `mode` is<br/>
        /// `SELF_HOSTED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_config")]
        public object? CustomConfig { get; set; }

        /// <summary>
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_environment")]
        public string? FromEnvironment { get; set; }

        /// <summary>
        /// Optional. System instruction applied to interactions running in this<br/>
        /// environment. Only supported for `SELF_HOSTED` environments, where it is<br/>
        /// recommended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instruction")]
        public string? SystemInstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="env">
        /// Environment variables to set in the sandbox environment.
        /// </param>
        /// <param name="mode">
        /// The compute lifecycle mode for this environment.
        /// </param>
        /// <param name="customConfig">
        /// Optional. Arbitrary customer-defined JSON configuration passed through<br/>
        /// to the self-hosted environment poller. Only supported when `mode` is<br/>
        /// `SELF_HOSTED`.
        /// </param>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </param>
        /// <param name="systemInstruction">
        /// Optional. System instruction applied to interactions running in this<br/>
        /// environment. Only supported for `SELF_HOSTED` environments, where it is<br/>
        /// recommended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequest(
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? network,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? env,
            global::Google.Gemini.NextGen.CreateEnvironmentRequestMode? mode,
            object? customConfig,
            string? fromEnvironment,
            string? systemInstruction)
        {
            this.Network = network;
            this.Sources = sources;
            this.Env = env;
            this.Mode = mode;
            this.CustomConfig = customConfig;
            this.FromEnvironment = fromEnvironment;
            this.SystemInstruction = systemInstruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        public CreateEnvironmentRequest()
        {
        }

    }
}