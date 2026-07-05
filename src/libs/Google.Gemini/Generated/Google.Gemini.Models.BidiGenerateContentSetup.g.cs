
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Message to be sent in the first (and only in the first) `BidiGenerateContentClientMessage`. Contains configuration that will apply for the duration of the streaming RPC. Clients should wait for a `BidiGenerateContentSetupComplete` message before sending any additional messages.
    /// </summary>
    public sealed partial class BidiGenerateContentSetup
    {
        /// <summary>
        /// Optional. A list of `Tools` the model may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Tools { get; set; }

        /// <summary>
        /// Enables context window compression — a mechanism for managing the model's context window so that it does not exceed a given length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextWindowCompression")]
        public global::Google.Gemini.ContextWindowCompressionConfig? ContextWindowCompression { get; set; }

        /// <summary>
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationConfig")]
        public global::Google.Gemini.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// The audio transcription configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputAudioTranscription")]
        public global::Google.Gemini.AudioTranscriptionConfig? InputAudioTranscription { get; set; }

        /// <summary>
        /// History configuration. This message is included in the session configuration as `BidiGenerateContentSetup.history_config`. Configures the exchange of history messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("historyConfig")]
        public global::Google.Gemini.HistoryConfig? HistoryConfig { get; set; }

        /// <summary>
        /// The audio transcription configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputAudioTranscription")]
        public global::Google.Gemini.AudioTranscriptionConfig? OutputAudioTranscription { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemInstruction")]
        public global::Google.Gemini.Content? SystemInstruction { get; set; }

        /// <summary>
        /// Configures the realtime input behavior in `BidiGenerateContent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtimeInputConfig")]
        public global::Google.Gemini.RealtimeInputConfig? RealtimeInputConfig { get; set; }

        /// <summary>
        /// Session resumption configuration. This message is included in the session configuration as `BidiGenerateContentSetup.session_resumption`. If configured, the server will send `SessionResumptionUpdate` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionResumption")]
        public global::Google.Gemini.SessionResumptionConfig? SessionResumption { get; set; }

        /// <summary>
        /// Required. The model's resource name. This serves as an ID for the Model to use. Format: `models/{model}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BidiGenerateContentSetup" /> class.
        /// </summary>
        /// <param name="tools">
        /// Optional. A list of `Tools` the model may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the model.
        /// </param>
        /// <param name="contextWindowCompression">
        /// Enables context window compression — a mechanism for managing the model's context window so that it does not exceed a given length.
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// The audio transcription configuration.
        /// </param>
        /// <param name="historyConfig">
        /// History configuration. This message is included in the session configuration as `BidiGenerateContentSetup.history_config`. Configures the exchange of history messages.
        /// </param>
        /// <param name="outputAudioTranscription">
        /// The audio transcription configuration.
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="realtimeInputConfig">
        /// Configures the realtime input behavior in `BidiGenerateContent`.
        /// </param>
        /// <param name="sessionResumption">
        /// Session resumption configuration. This message is included in the session configuration as `BidiGenerateContentSetup.session_resumption`. If configured, the server will send `SessionResumptionUpdate` messages.
        /// </param>
        /// <param name="model">
        /// Required. The model's resource name. This serves as an ID for the Model to use. Format: `models/{model}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BidiGenerateContentSetup(
            global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? tools,
            global::Google.Gemini.ContextWindowCompressionConfig? contextWindowCompression,
            global::Google.Gemini.GenerationConfig? generationConfig,
            global::Google.Gemini.AudioTranscriptionConfig? inputAudioTranscription,
            global::Google.Gemini.HistoryConfig? historyConfig,
            global::Google.Gemini.AudioTranscriptionConfig? outputAudioTranscription,
            global::Google.Gemini.Content? systemInstruction,
            global::Google.Gemini.RealtimeInputConfig? realtimeInputConfig,
            global::Google.Gemini.SessionResumptionConfig? sessionResumption,
            string? model)
        {
            this.Tools = tools;
            this.ContextWindowCompression = contextWindowCompression;
            this.GenerationConfig = generationConfig;
            this.InputAudioTranscription = inputAudioTranscription;
            this.HistoryConfig = historyConfig;
            this.OutputAudioTranscription = outputAudioTranscription;
            this.SystemInstruction = systemInstruction;
            this.RealtimeInputConfig = realtimeInputConfig;
            this.SessionResumption = sessionResumption;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BidiGenerateContentSetup" /> class.
        /// </summary>
        public BidiGenerateContentSetup()
        {
        }

    }
}