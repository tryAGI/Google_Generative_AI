
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Used to specify configuration for ParallelAISearch.
    /// </summary>
    public sealed partial class ParallelAISearchConfig
    {
        /// <summary>
        /// Optional. The API key for ParallelAiSearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Optional. Custom configs for ParallelAiSearch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_config")]
        public object? CustomConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParallelAISearchConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Optional. The API key for ParallelAiSearch.
        /// </param>
        /// <param name="customConfig">
        /// Optional. Custom configs for ParallelAiSearch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParallelAISearchConfig(
            string? apiKey,
            object? customConfig)
        {
            this.ApiKey = apiKey;
            this.CustomConfig = customConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParallelAISearchConfig" /> class.
        /// </summary>
        public ParallelAISearchConfig()
        {
        }

    }
}