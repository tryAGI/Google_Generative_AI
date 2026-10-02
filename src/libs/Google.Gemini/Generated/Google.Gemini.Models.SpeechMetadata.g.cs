
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Speech metadata for `text` parts.
    /// </summary>
    public sealed partial class SpeechMetadata
    {
        /// <summary>
        /// Optional. Optional style instruction for the speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Optional. Optional speaker name for multi-speaker synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMetadata" /> class.
        /// </summary>
        /// <param name="style">
        /// Optional. Optional style instruction for the speech synthesis.
        /// </param>
        /// <param name="speaker">
        /// Optional. Optional speaker name for multi-speaker synthesis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechMetadata(
            string? style,
            string? speaker)
        {
            this.Style = style;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMetadata" /> class.
        /// </summary>
        public SpeechMetadata()
        {
        }

    }
}