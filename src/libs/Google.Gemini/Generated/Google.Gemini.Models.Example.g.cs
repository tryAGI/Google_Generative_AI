
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// An input/output example used to instruct the Model. It demonstrates how the model should respond or format its response.
    /// </summary>
    public sealed partial class Example
    {
        /// <summary>
        /// The base unit of structured text. A `Message` includes an `author` and the `content` of the `Message`. The `author` is used to tag messages when they are fed to the model as text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Google.Gemini.Message? Input { get; set; }

        /// <summary>
        /// The base unit of structured text. A `Message` includes an `author` and the `content` of the `Message`. The `author` is used to tag messages when they are fed to the model as text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Google.Gemini.Message? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Example" /> class.
        /// </summary>
        /// <param name="input">
        /// The base unit of structured text. A `Message` includes an `author` and the `content` of the `Message`. The `author` is used to tag messages when they are fed to the model as text.
        /// </param>
        /// <param name="output">
        /// The base unit of structured text. A `Message` includes an `author` and the `content` of the `Message`. The `author` is used to tag messages when they are fed to the model as text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Example(
            global::Google.Gemini.Message? input,
            global::Google.Gemini.Message? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Example" /> class.
        /// </summary>
        public Example()
        {
        }
    }
}