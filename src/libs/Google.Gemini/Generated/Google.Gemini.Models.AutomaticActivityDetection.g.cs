
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configures automatic detection of activity.
    /// </summary>
    public sealed partial class AutomaticActivityDetection
    {
        /// <summary>
        /// Optional. The required duration of detected speech before start-of-speech is committed. The lower this value, the more sensitive the start-of-speech detection is and shorter speech can be recognized. However, this also increases the probability of false positives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixPaddingMs")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Optional. Determines how likely speech is to be detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startOfSpeechSensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.AutomaticActivityDetectionStartOfSpeechSensitivityJsonConverter))]
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? StartOfSpeechSensitivity { get; set; }

        /// <summary>
        /// Optional. Determines how likely detected speech is ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOfSpeechSensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.AutomaticActivityDetectionEndOfSpeechSensitivityJsonConverter))]
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? EndOfSpeechSensitivity { get; set; }

        /// <summary>
        /// Optional. The required duration of detected non-speech (e.g. silence) before end-of-speech is committed. The larger this value, the longer speech gaps can be without interrupting the user's activity but this will increase the model's latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silenceDurationMs")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Optional. If enabled (the default), detected voice and text input count as activity. If disabled, the client must send activity signals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticActivityDetection" /> class.
        /// </summary>
        /// <param name="prefixPaddingMs">
        /// Optional. The required duration of detected speech before start-of-speech is committed. The lower this value, the more sensitive the start-of-speech detection is and shorter speech can be recognized. However, this also increases the probability of false positives.
        /// </param>
        /// <param name="startOfSpeechSensitivity">
        /// Optional. Determines how likely speech is to be detected.
        /// </param>
        /// <param name="endOfSpeechSensitivity">
        /// Optional. Determines how likely detected speech is ended.
        /// </param>
        /// <param name="silenceDurationMs">
        /// Optional. The required duration of detected non-speech (e.g. silence) before end-of-speech is committed. The larger this value, the longer speech gaps can be without interrupting the user's activity but this will increase the model's latency.
        /// </param>
        /// <param name="disabled">
        /// Optional. If enabled (the default), detected voice and text input count as activity. If disabled, the client must send activity signals.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomaticActivityDetection(
            int? prefixPaddingMs,
            global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? startOfSpeechSensitivity,
            global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? endOfSpeechSensitivity,
            int? silenceDurationMs,
            bool? disabled)
        {
            this.PrefixPaddingMs = prefixPaddingMs;
            this.StartOfSpeechSensitivity = startOfSpeechSensitivity;
            this.EndOfSpeechSensitivity = endOfSpeechSensitivity;
            this.SilenceDurationMs = silenceDurationMs;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticActivityDetection" /> class.
        /// </summary>
        public AutomaticActivityDetection()
        {
        }

    }
}