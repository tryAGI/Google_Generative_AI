
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Describes the options to customize dynamic retrieval.
    /// </summary>
    public sealed partial class DynamicRetrievalConfig
    {
        /// <summary>
        /// The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicThreshold")]
        public float? DynamicThreshold { get; set; }

        /// <summary>
        /// The mode of the predictor to be used in dynamic retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.DynamicRetrievalConfigModeJsonConverter))]
        public global::Google.Gemini.DynamicRetrievalConfigMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicRetrievalConfig" /> class.
        /// </summary>
        /// <param name="dynamicThreshold">
        /// The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </param>
        /// <param name="mode">
        /// The mode of the predictor to be used in dynamic retrieval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicRetrievalConfig(
            float? dynamicThreshold,
            global::Google.Gemini.DynamicRetrievalConfigMode? mode)
        {
            this.DynamicThreshold = dynamicThreshold;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicRetrievalConfig" /> class.
        /// </summary>
        public DynamicRetrievalConfig()
        {
        }
    }
}