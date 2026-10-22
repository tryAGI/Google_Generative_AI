
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Parameters for prompted voice generation.<br/>
    /// Required in `CreateVoice` when `type` is `"prompted"`. Returned in<br/>
    /// `CreateVoice`, `GetVoice`, and `ListVoices` responses for prompted voices.
    /// </summary>
    public sealed partial class PromptedVoice
    {
        /// <summary>
        /// Required. The natural-language prompt describing the desired voice, e.g.<br/>
        /// "A deep, booming male voice of a massive evil ogre in his middle years."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Optional. The name or ID of an existing base voice to edit or remix.<br/>
        /// Use the voice name for prebuilt voices (e.g., `Puck`) or the voice ID for<br/>
        /// previously created voices (e.g., `voice_abc123`). This can be any<br/>
        /// prompted or replicated voice that the user has access to.<br/>
        /// When present, `input` describes relative alterations to make to the base<br/>
        /// voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_voice")]
        public string? BaseVoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptedVoice" /> class.
        /// </summary>
        /// <param name="input">
        /// Required. The natural-language prompt describing the desired voice, e.g.<br/>
        /// "A deep, booming male voice of a massive evil ogre in his middle years."
        /// </param>
        /// <param name="baseVoice">
        /// Optional. The name or ID of an existing base voice to edit or remix.<br/>
        /// Use the voice name for prebuilt voices (e.g., `Puck`) or the voice ID for<br/>
        /// previously created voices (e.g., `voice_abc123`). This can be any<br/>
        /// prompted or replicated voice that the user has access to.<br/>
        /// When present, `input` describes relative alterations to make to the base<br/>
        /// voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptedVoice(
            string input,
            string? baseVoice)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.BaseVoice = baseVoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptedVoice" /> class.
        /// </summary>
        public PromptedVoice()
        {
        }

    }
}