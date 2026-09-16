
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request for `CreateEnvironment`.
    /// </summary>
    public sealed partial class CreateEnvironmentRequest
    {
        /// <summary>
        /// Network egress configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkAllowlist")]
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? NetworkAllowlist { get; set; }

        /// <summary>
        /// Network egress mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CreateEnvironmentRequestNetworkModeJsonConverter))]
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? NetworkMode { get; set; }

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Sources { get; set; }

        /// <summary>
        /// Optional. The source environment to copy/fork from. Format: `environments/{environment_id}` or `{environment_id}`. When specified, `sources` and `env` must be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromEnvironment")]
        public string? FromEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from. Format: `environments/{environment_id}` or `{environment_id}`. When specified, `sources` and `env` must be empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequest(
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist,
            global::Google.Gemini.CreateEnvironmentRequestNetworkMode? networkMode,
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources,
            string? fromEnvironment)
        {
            this.NetworkAllowlist = networkAllowlist;
            this.NetworkMode = networkMode;
            this.Sources = sources;
            this.FromEnvironment = fromEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        public CreateEnvironmentRequest()
        {
        }

    }
}