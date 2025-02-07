
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
    /// </summary>
    public sealed partial class Content
    {
        /// <summary>
        /// Ordered `Parts` that constitute a single message. Parts may have different MIME types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Parts { get; set; }

        /// <summary>
        /// Optional. The producer of the content. Must be either 'user' or 'model'. Useful to set for multi-turn conversations, otherwise can be left blank or unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="parts">
        /// Ordered `Parts` that constitute a single message. Parts may have different MIME types.
        /// </param>
        /// <param name="role">
        /// Optional. The producer of the content. Must be either 'user' or 'model'. Useful to set for multi-turn conversations, otherwise can be left blank or unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Content(
            global::System.Collections.Generic.IList<global::Google.Gemini.Part>? parts,
            string? role)
        {
            this.Parts = parts;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        public Content()
        {
        }
    }
}