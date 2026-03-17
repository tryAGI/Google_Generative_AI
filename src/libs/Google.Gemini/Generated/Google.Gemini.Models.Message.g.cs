
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The base unit of structured text. A `Message` includes an `author` and the `content` of the `Message`. The `author` is used to tag messages when they are fed to the model as text.
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// Optional. The author of this Message. This serves as a key for tagging the content of this Message when it is fed to the model as text. The author can be any alphanumeric string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Required. The text content of the structured `Message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// A collection of source attributions for a piece of content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationMetadata")]
        public global::Google.Gemini.CitationMetadata? CitationMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="author">
        /// Optional. The author of this Message. This serves as a key for tagging the content of this Message when it is fed to the model as text. The author can be any alphanumeric string.
        /// </param>
        /// <param name="content">
        /// Required. The text content of the structured `Message`.
        /// </param>
        /// <param name="citationMetadata">
        /// A collection of source attributions for a piece of content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            string? author,
            string? content,
            global::Google.Gemini.CitationMetadata? citationMetadata)
        {
            this.Author = author;
            this.Content = content;
            this.CitationMetadata = citationMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }
    }
}