
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The configuration for the voice to use.
    /// </summary>
    public sealed partial class VoiceConfig
    {
        /// <summary>
        /// The configuration for the prebuilt speaker to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuiltVoiceConfig")]
        public global::Google.Gemini.PrebuiltVoiceConfig? PrebuiltVoiceConfig { get; set; }

        /// <summary>
        /// Optional. The speaker identifier for synthesis. Supported formats: * Speaker name for prebuilt voices (for example, `Orus` or `Kore`). * Voice ID for stored voices (for example, `voice_xxx`). * Voice replication key (for example, `voicekey_xxx`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        /// <param name="prebuiltVoiceConfig">
        /// The configuration for the prebuilt speaker to use.
        /// </param>
        /// <param name="voice">
        /// Optional. The speaker identifier for synthesis. Supported formats: * Speaker name for prebuilt voices (for example, `Orus` or `Kore`). * Voice ID for stored voices (for example, `voice_xxx`). * Voice replication key (for example, `voicekey_xxx`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceConfig(
            global::Google.Gemini.PrebuiltVoiceConfig? prebuiltVoiceConfig,
            string? voice)
        {
            this.PrebuiltVoiceConfig = prebuiltVoiceConfig;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceConfig" /> class.
        /// </summary>
        public VoiceConfig()
        {
        }

    }
}