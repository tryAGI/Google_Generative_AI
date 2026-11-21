
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Config for proactivity features.
    /// </summary>
    public sealed partial class ProactivityConfig
    {
        /// <summary>
        /// Optional. If enabled, the system might trigger a generation on each received image. This requires that `proactive_audio` is enabled. The rate of generation depends on the rate of incoming images and can cause a significant increase in cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proactiveVideo")]
        public bool? ProactiveVideo { get; set; }

        /// <summary>
        /// Optional. If enabled, the model can reject responding to the last prompt. For example, this allows the model to ignore out of context speech or to stay silent if the user did not make a request, yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proactiveAudio")]
        public bool? ProactiveAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProactivityConfig" /> class.
        /// </summary>
        /// <param name="proactiveVideo">
        /// Optional. If enabled, the system might trigger a generation on each received image. This requires that `proactive_audio` is enabled. The rate of generation depends on the rate of incoming images and can cause a significant increase in cost.
        /// </param>
        /// <param name="proactiveAudio">
        /// Optional. If enabled, the model can reject responding to the last prompt. For example, this allows the model to ignore out of context speech or to stay silent if the user did not make a request, yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProactivityConfig(
            bool? proactiveVideo,
            bool? proactiveAudio)
        {
            this.ProactiveVideo = proactiveVideo;
            this.ProactiveAudio = proactiveAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProactivityConfig" /> class.
        /// </summary>
        public ProactivityConfig()
        {
        }

    }
}