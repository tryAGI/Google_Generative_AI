
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Used to specify configuration for ExaAISearch.
    /// </summary>
    public sealed partial class ExaAISearchConfig
    {
        /// <summary>
        /// Required. The API key for ExaAiSearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Optional. This field can be used to pass any parameter from the Exa.ai Search API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_config")]
        public object? CustomConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExaAISearchConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Required. The API key for ExaAiSearch.
        /// </param>
        /// <param name="customConfig">
        /// Optional. This field can be used to pass any parameter from the Exa.ai Search API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExaAISearchConfig(
            string apiKey,
            object? customConfig)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.CustomConfig = customConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExaAISearchConfig" /> class.
        /// </summary>
        public ExaAISearchConfig()
        {
        }

    }
}