
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request for `CreateEnvironment`.
    /// </summary>
    public sealed partial class CreateEnvironmentRequest
    {
        /// <summary>
        /// Environment variables to set in the sandbox environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.EnvVar>? Env { get; set; }

        /// <summary>
        /// Network egress mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CreateEnvironmentRequestNetworkModeJsonConverter))]
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? NetworkMode { get; set; }

        /// <summary>
        /// Optional. The source environment to copy/fork from. Format: `environments/{environment_id}` or `{environment_id}`. When specified, `sources` and `env` must be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromEnvironment")]
        public string? FromEnvironment { get; set; }

        /// <summary>
        /// Network egress configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkAllowlist")]
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? NetworkAllowlist { get; set; }

        /// <summary>
        /// Optional. System instruction applied to interactions running in this environment. Only supported for `SELF_HOSTED` environments, where it is recommended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemInstruction")]
        public string? SystemInstruction { get; set; }

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Sources { get; set; }

        /// <summary>
        /// Optional. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only supported when `mode` is `SELF_HOSTED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customConfig")]
        public object? CustomConfig { get; set; }

        /// <summary>
        /// The compute lifecycle mode for this environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CreateEnvironmentRequestModeJsonConverter))]
        public global::Google.Gemini.CreateEnvironmentRequestMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="env">
        /// Environment variables to set in the sandbox environment.
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from. Format: `environments/{environment_id}` or `{environment_id}`. When specified, `sources` and `env` must be empty.
        /// </param>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="systemInstruction">
        /// Optional. System instruction applied to interactions running in this environment. Only supported for `SELF_HOSTED` environments, where it is recommended.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="customConfig">
        /// Optional. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only supported when `mode` is `SELF_HOSTED`.
        /// </param>
        /// <param name="mode">
        /// The compute lifecycle mode for this environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequest(
            global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.EnvVar>? env,
            global::Google.Gemini.CreateEnvironmentRequestNetworkMode? networkMode,
            string? fromEnvironment,
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist,
            string? systemInstruction,
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources,
            object? customConfig,
            global::Google.Gemini.CreateEnvironmentRequestMode? mode)
        {
            this.Env = env;
            this.NetworkMode = networkMode;
            this.FromEnvironment = fromEnvironment;
            this.NetworkAllowlist = networkAllowlist;
            this.SystemInstruction = systemInstruction;
            this.Sources = sources;
            this.CustomConfig = customConfig;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        public CreateEnvironmentRequest()
        {
        }

    }
}