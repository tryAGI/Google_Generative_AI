
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration parameters for model interactions.
    /// </summary>
    public sealed partial class GenerationConfig
    {
        /// <summary>
        /// The configuration for image interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Google.Gemini.NextGen.ImageConfig? ImageConfig { get; set; }

        /// <summary>
        /// The maximum number of tokens to include in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Seed used in decoding for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional. Speech and multi-speaker configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>? SpeechConfig { get; set; }

        /// <summary>
        /// A list of character sequences that will stop output interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Controls the randomness of the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingLevelJsonConverter))]
        public global::Google.Gemini.NextGen.ThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_summaries")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingSummariesJsonConverter))]
        public global::Google.Gemini.NextGen.ThinkingSummaries? ThinkingSummaries { get; set; }

        /// <summary>
        /// The tool choice configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? ToolChoice { get; set; }

        /// <summary>
        /// The maximum cumulative probability of tokens to consider when sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? TopP { get; set; }

        /// <summary>
        /// Configuration for speech recognition (transcription).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_config")]
        public global::Google.Gemini.NextGen.TranscriptionConfig? TranscriptionConfig { get; set; }

        /// <summary>
        /// Configuration options for video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_config")]
        public global::Google.Gemini.NextGen.VideoConfig? VideoConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens to include in the response.
        /// </param>
        /// <param name="seed">
        /// Seed used in decoding for reproducibility.
        /// </param>
        /// <param name="speechConfig">
        /// Optional. Speech and multi-speaker configuration.
        /// </param>
        /// <param name="stopSequences">
        /// A list of character sequences that will stop output interaction.
        /// </param>
        /// <param name="thinkingLevel"></param>
        /// <param name="thinkingSummaries"></param>
        /// <param name="toolChoice">
        /// The tool choice configuration.
        /// </param>
        /// <param name="transcriptionConfig">
        /// Configuration for speech recognition (transcription).
        /// </param>
        /// <param name="videoConfig">
        /// Configuration options for video generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationConfig(
            int? maxOutputTokens,
            int? seed,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>? speechConfig,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::Google.Gemini.NextGen.ThinkingLevel? thinkingLevel,
            global::Google.Gemini.NextGen.ThinkingSummaries? thinkingSummaries,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? toolChoice,
            global::Google.Gemini.NextGen.TranscriptionConfig? transcriptionConfig,
            global::Google.Gemini.NextGen.VideoConfig? videoConfig)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.Seed = seed;
            this.SpeechConfig = speechConfig;
            this.StopSequences = stopSequences;
            this.ThinkingLevel = thinkingLevel;
            this.ThinkingSummaries = thinkingSummaries;
            this.ToolChoice = toolChoice;
            this.TranscriptionConfig = transcriptionConfig;
            this.VideoConfig = videoConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        public GenerationConfig()
        {
        }

    }
}