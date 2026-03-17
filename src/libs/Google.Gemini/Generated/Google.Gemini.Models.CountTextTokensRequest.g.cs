
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Counts the number of tokens in the `prompt` sent to a model. Models may tokenize text differently, so each model may return a different `token_count`.
    /// </summary>
    public sealed partial class CountTextTokensRequest
    {
        /// <summary>
        /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Google.Gemini.TextPrompt? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTextTokensRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text given to the model as a prompt. The Model will use this TextPrompt to Generate a text completion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountTextTokensRequest(
            global::Google.Gemini.TextPrompt? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTextTokensRequest" /> class.
        /// </summary>
        public CountTextTokensRequest()
        {
        }
    }
}