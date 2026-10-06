
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for text output format.<br/>
    /// Example: {"type":"text","mime_type":"application/json","schema":{"type":"object","properties":{"ingredients":{"type":"array","items":{"type":"string"}},"recipe_name":{"type":"string"}},"required":["ingredients","recipe_name"]}}
    /// </summary>
    public sealed partial class TextResponseFormat
    {
        /// <summary>
        /// The MIME type of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.TextResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// The JSON schema that the output should conform to. Only applicable when<br/>
        /// mime_type is application/json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

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
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mimeType">
        /// The MIME type of the text output.
        /// </param>
        /// <param name="schema">
        /// The JSON schema that the output should conform to. Only applicable when<br/>
        /// mime_type is application/json.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResponseFormat(
            object type,
            global::Google.Gemini.NextGen.TextResponseFormatMimeType? mimeType,
            object? schema)
        {
            this.MimeType = mimeType;
            this.Schema = schema;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        public TextResponseFormat()
        {
        }

    }
}