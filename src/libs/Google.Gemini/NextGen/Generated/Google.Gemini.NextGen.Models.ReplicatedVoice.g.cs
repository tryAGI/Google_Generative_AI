
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Input only. Parameters for replicated voice generation.<br/>
    /// Required on input when `type` is `"replicated"`. Not returned in<br/>
    /// responses.<br/>
    /// Included only in requests
    /// </summary>
    public sealed partial class ReplicatedVoice
    {
        /// <summary>
        /// Audio payload used for voice creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.AudioData ConsentAudio { get; set; }

        /// <summary>
        /// Audio payload used for voice creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.AudioData SourceAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatedVoice" /> class.
        /// </summary>
        /// <param name="consentAudio">
        /// Audio payload used for voice creation.
        /// </param>
        /// <param name="sourceAudio">
        /// Audio payload used for voice creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicatedVoice(
            global::Google.Gemini.NextGen.AudioData consentAudio,
            global::Google.Gemini.NextGen.AudioData sourceAudio)
        {
            this.ConsentAudio = consentAudio ?? throw new global::System.ArgumentNullException(nameof(consentAudio));
            this.SourceAudio = sourceAudio ?? throw new global::System.ArgumentNullException(nameof(sourceAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatedVoice" /> class.
        /// </summary>
        public ReplicatedVoice()
        {
        }

    }
}