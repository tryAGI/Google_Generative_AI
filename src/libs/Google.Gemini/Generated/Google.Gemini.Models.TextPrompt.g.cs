
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
    /// </summary>
    public sealed partial class TextPrompt
    {
        /// <summary>
        /// Required. The prompt text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// Required. The prompt text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextPrompt(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextPrompt" /> class.
        /// </summary>
        public TextPrompt()
        {
        }
    }
}