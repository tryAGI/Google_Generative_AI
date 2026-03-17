
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Passage included inline with a grounding configuration.
    /// </summary>
    public sealed partial class GroundingPassage
    {
        /// <summary>
        /// Identifier for the passage for attributing this passage in grounded answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Google.Gemini.Content? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassage" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the passage for attributing this passage in grounded answers.
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingPassage(
            string? id,
            global::Google.Gemini.Content? content)
        {
            this.Id = id;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassage" /> class.
        /// </summary>
        public GroundingPassage()
        {
        }
    }
}