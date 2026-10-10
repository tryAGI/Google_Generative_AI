
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for the response output format. This is a flat object where each optional sub-field configures a specific output modality.
    /// </summary>
    public sealed partial class ResponseFormatConfig
    {
        /// <summary>
        /// Configuration for image output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Google.Gemini.ImageResponseFormat? Image { get; set; }

        /// <summary>
        /// Configuration for text output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Google.Gemini.TextResponseFormat? Text { get; set; }

        /// <summary>
        /// Configuration for audio output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::Google.Gemini.AudioResponseFormat? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatConfig" /> class.
        /// </summary>
        /// <param name="image">
        /// Configuration for image output format.
        /// </param>
        /// <param name="text">
        /// Configuration for text output format.
        /// </param>
        /// <param name="audio">
        /// Configuration for audio output format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatConfig(
            global::Google.Gemini.ImageResponseFormat? image,
            global::Google.Gemini.TextResponseFormat? text,
            global::Google.Gemini.AudioResponseFormat? audio)
        {
            this.Image = image;
            this.Text = text;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatConfig" /> class.
        /// </summary>
        public ResponseFormatConfig()
        {
        }

    }
}