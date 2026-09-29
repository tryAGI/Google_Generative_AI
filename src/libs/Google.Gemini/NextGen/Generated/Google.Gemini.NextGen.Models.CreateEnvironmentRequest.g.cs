
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request for `CreateEnvironment`.
    /// </summary>
    public sealed partial class CreateEnvironmentRequest
    {
        /// <summary>
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_environment")]
        public string? FromEnvironment { get; set; }

        /// <summary>
        /// Network configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Network { get; set; }

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="fromEnvironment">
        /// Optional. The source environment to copy/fork from.<br/>
        /// Format: `environments/{environment_id}` or `{environment_id}`.<br/>
        /// When specified, `sources` and `env` must be empty.
        /// </param>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequest(
            string? fromEnvironment,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? network,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources)
        {
            this.FromEnvironment = fromEnvironment;
            this.Network = network;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        public CreateEnvironmentRequest()
        {
        }

    }
}