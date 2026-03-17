
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Counts the number of tokens in the `prompt` sent to a model. Models may tokenize text differently, so each model may return a different `token_count`.
    /// </summary>
    public sealed partial class CountMessageTokensRequest
    {
        /// <summary>
        /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Google.Gemini.MessagePrompt? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountMessageTokensRequest(
            global::Google.Gemini.MessagePrompt? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountMessageTokensRequest" /> class.
        /// </summary>
        public CountMessageTokensRequest()
        {
        }
    }
}