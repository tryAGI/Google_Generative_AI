
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Safety setting, affecting the safety-blocking behavior. Passing a safety setting for a category changes the allowed proability that content is blocked.
    /// </summary>
    public sealed partial class SafetySetting
    {
        /// <summary>
        /// Required. The category for this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryJsonConverter))]
        public global::Google.Gemini.SafetySettingCategory? Category { get; set; }

        /// <summary>
        /// Required. Controls the probability threshold at which harm is blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdJsonConverter))]
        public global::Google.Gemini.SafetySettingThreshold? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        /// <param name="category">
        /// Required. The category for this setting.
        /// </param>
        /// <param name="threshold">
        /// Required. Controls the probability threshold at which harm is blocked.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SafetySetting(
            global::Google.Gemini.SafetySettingCategory? category,
            global::Google.Gemini.SafetySettingThreshold? threshold)
        {
            this.Category = category;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        public SafetySetting()
        {
        }
    }
}