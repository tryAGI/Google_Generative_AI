
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// All of the structured input text passed to the model as a prompt. A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
    /// </summary>
    public sealed partial class MessagePrompt
    {
        /// <summary>
        /// Optional. Text that should be provided to the model first to ground the response. If not empty, this `context` will be given to the model first before the `examples` and `messages`. When using a `context` be sure to provide it with every request to maintain continuity. This field can be a description of your prompt to the model to help provide context and guide the responses. Examples: "Translate the phrase from English to French." or "Given a statement, classify the sentiment as happy, sad or neutral." Anything included in this field will take precedence over message history if the total input size exceeds the model's `input_token_limit` and the input request is truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Optional. Examples of what the model should generate. This includes both user input and the response that the model should emulate. These `examples` are treated identically to conversation messages except that they take precedence over the history in `messages`: If the total input size exceeds the model's `input_token_limit` the input will be truncated. Items will be dropped from `messages` before `examples`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Example>? Examples { get; set; }

        /// <summary>
        /// Required. A snapshot of the recent conversation history sorted chronologically. Turns alternate between two authors. If the total input size exceeds the model's `input_token_limit` the input will be truncated: The oldest items will be dropped from `messages`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Message>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePrompt" /> class.
        /// </summary>
        /// <param name="context">
        /// Optional. Text that should be provided to the model first to ground the response. If not empty, this `context` will be given to the model first before the `examples` and `messages`. When using a `context` be sure to provide it with every request to maintain continuity. This field can be a description of your prompt to the model to help provide context and guide the responses. Examples: "Translate the phrase from English to French." or "Given a statement, classify the sentiment as happy, sad or neutral." Anything included in this field will take precedence over message history if the total input size exceeds the model's `input_token_limit` and the input request is truncated.
        /// </param>
        /// <param name="examples">
        /// Optional. Examples of what the model should generate. This includes both user input and the response that the model should emulate. These `examples` are treated identically to conversation messages except that they take precedence over the history in `messages`: If the total input size exceeds the model's `input_token_limit` the input will be truncated. Items will be dropped from `messages` before `examples`.
        /// </param>
        /// <param name="messages">
        /// Required. A snapshot of the recent conversation history sorted chronologically. Turns alternate between two authors. If the total input size exceeds the model's `input_token_limit` the input will be truncated: The oldest items will be dropped from `messages`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagePrompt(
            string? context,
            global::System.Collections.Generic.IList<global::Google.Gemini.Example>? examples,
            global::System.Collections.Generic.IList<global::Google.Gemini.Message>? messages)
        {
            this.Context = context;
            this.Examples = examples;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePrompt" /> class.
        /// </summary>
        public MessagePrompt()
        {
        }
    }
}