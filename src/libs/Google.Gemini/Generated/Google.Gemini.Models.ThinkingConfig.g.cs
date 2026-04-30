
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Config for thinking features.
    /// </summary>
    public sealed partial class ThinkingConfig
    {
        /// <summary>
        /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinkingLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ThinkingConfigThinkingLevelJsonConverter))]
        public global::Google.Gemini.ThinkingConfigThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        /// Indicates whether to include thoughts in the response. If true, thoughts are returned only when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeThoughts")]
        public bool? IncludeThoughts { get; set; }

        /// <summary>
        /// The number of thoughts tokens that the model should generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinkingBudget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfig" /> class.
        /// </summary>
        /// <param name="thinkingLevel">
        /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
        /// </param>
        /// <param name="includeThoughts">
        /// Indicates whether to include thoughts in the response. If true, thoughts are returned only when available.
        /// </param>
        /// <param name="thinkingBudget">
        /// The number of thoughts tokens that the model should generate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingConfig(
            global::Google.Gemini.ThinkingConfigThinkingLevel? thinkingLevel,
            bool? includeThoughts,
            int? thinkingBudget)
        {
            this.ThinkingLevel = thinkingLevel;
            this.IncludeThoughts = includeThoughts;
            this.ThinkingBudget = thinkingBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfig" /> class.
        /// </summary>
        public ThinkingConfig()
        {
        }
    }
}