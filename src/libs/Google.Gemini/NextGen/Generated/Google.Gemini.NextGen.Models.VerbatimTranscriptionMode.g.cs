
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for verbatim transcription mode.
    /// </summary>
    public sealed partial class VerbatimTranscriptionMode
    {
        /// <summary>
        /// Optional. Configures speaker diarization. Supported values: "speaker".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_mode")]
        public string? DiarizationMode { get; set; }

        /// <summary>
        /// Optional. The granularity of timestamps to include in the transcription output.<br/>
        /// Supported values: "word". If empty, no timestamps are generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        public global::System.Collections.Generic.IList<string>? TimestampGranularities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerbatimTranscriptionMode" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="diarizationMode">
        /// Optional. Configures speaker diarization. Supported values: "speaker".
        /// </param>
        /// <param name="timestampGranularities">
        /// Optional. The granularity of timestamps to include in the transcription output.<br/>
        /// Supported values: "word". If empty, no timestamps are generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerbatimTranscriptionMode(
            object type,
            string? diarizationMode,
            global::System.Collections.Generic.IList<string>? timestampGranularities)
        {
            this.DiarizationMode = diarizationMode;
            this.TimestampGranularities = timestampGranularities;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerbatimTranscriptionMode" /> class.
        /// </summary>
        public VerbatimTranscriptionMode()
        {
        }

    }
}