
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A safety setting that affects the safety-blocking behavior.<br/>
    /// A SafetySetting consists of a<br/>
    /// harm category and a<br/>
    /// threshold for that<br/>
    /// category.
    /// </summary>
    public sealed partial class SafetySetting
    {
        /// <summary>
        /// Optional. The method for blocking content. If not specified, the default<br/>
        /// behavior is to use the probability score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingMethodJsonConverter))]
        public global::Google.Gemini.NextGen.SafetySettingMethod? Method { get; set; }

        /// <summary>
        /// Required. The threshold for blocking content. If the harm probability<br/>
        /// exceeds this threshold, the content will be blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingThresholdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.SafetySettingThreshold Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.HarmCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.HarmCategory Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        /// <param name="threshold">
        /// Required. The threshold for blocking content. If the harm probability<br/>
        /// exceeds this threshold, the content will be blocked.
        /// </param>
        /// <param name="type"></param>
        /// <param name="method">
        /// Optional. The method for blocking content. If not specified, the default<br/>
        /// behavior is to use the probability score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetySetting(
            global::Google.Gemini.NextGen.SafetySettingThreshold threshold,
            global::Google.Gemini.NextGen.HarmCategory type,
            global::Google.Gemini.NextGen.SafetySettingMethod? method)
        {
            this.Method = method;
            this.Threshold = threshold;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        public SafetySetting()
        {
        }

    }
}