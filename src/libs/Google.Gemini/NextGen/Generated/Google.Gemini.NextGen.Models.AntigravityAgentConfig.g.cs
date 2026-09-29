
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for the Antigravity agent runtime.<br/>
    /// Provides server-side control over the agent's execution environment<br/>
    /// and tool configuration.
    /// </summary>
    public sealed partial class AntigravityAgentConfig
    {
        /// <summary>
        /// Max total tokens for the agent run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_tokens")]
        public string? MaxTotalTokens { get; set; }

        /// <summary>
        /// The model to use for agent reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AntigravityAgentConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="maxTotalTokens">
        /// Max total tokens for the agent run.
        /// </param>
        /// <param name="model">
        /// The model to use for agent reasoning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AntigravityAgentConfig(
            object type,
            string? maxTotalTokens,
            string? model)
        {
            this.MaxTotalTokens = maxTotalTokens;
            this.Model = model;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntigravityAgentConfig" /> class.
        /// </summary>
        public AntigravityAgentConfig()
        {
        }

    }
}