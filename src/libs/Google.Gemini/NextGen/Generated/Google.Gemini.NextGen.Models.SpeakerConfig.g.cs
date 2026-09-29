
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for multi-speaker and speech generation.
    /// </summary>
    public sealed partial class SpeakerConfig
    {
        /// <summary>
        /// Individual speaker configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>? Speakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerConfig" /> class.
        /// </summary>
        /// <param name="speakers">
        /// Individual speaker configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerConfig(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>? speakers)
        {
            this.Speakers = speakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerConfig" /> class.
        /// </summary>
        public SpeakerConfig()
        {
        }

    }
}