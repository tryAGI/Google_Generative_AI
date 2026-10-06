
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A text content block.<br/>
    /// Example: {"type":"text","text":"Hello, how are you?"}
    /// </summary>
    public sealed partial class TextContent
    {
        /// <summary>
        /// Citation information for model-generated content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Annotations { get; set; }

        /// <summary>
        /// Required. The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// Required. The text content.
        /// </param>
        /// <param name="type"></param>
        /// <param name="annotations">
        /// Citation information for model-generated content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContent(
            string text,
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? annotations)
        {
            this.Annotations = annotations;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        public TextContent()
        {
        }

    }
}