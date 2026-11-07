
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for smart transcription mode.
    /// </summary>
    public sealed partial class SmartTranscriptionMode
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The source text to be edited or rewritten via voice instructions.<br/>
        /// When provided, the model performs voice-driven editing and outputs the<br/>
        /// finalized replacement text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_text")]
        public string? SourceText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartTranscriptionMode" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sourceText">
        /// The source text to be edited or rewritten via voice instructions.<br/>
        /// When provided, the model performs voice-driven editing and outputs the<br/>
        /// finalized replacement text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartTranscriptionMode(
            object type,
            string? sourceText)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SourceText = sourceText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartTranscriptionMode" /> class.
        /// </summary>
        public SmartTranscriptionMode()
        {
        }

    }
}