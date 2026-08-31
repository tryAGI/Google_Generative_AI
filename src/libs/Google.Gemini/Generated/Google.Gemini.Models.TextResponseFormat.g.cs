
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for text output format.
    /// </summary>
    public sealed partial class TextResponseFormat
    {
        /// <summary>
        /// Optional. The MIME type of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.TextResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.TextResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// Optional. The JSON schema that the output should conform to. Only applicable when mime_type is APPLICATION_JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// Optional. The MIME type of the text output.
        /// </param>
        /// <param name="schema">
        /// Optional. The JSON schema that the output should conform to. Only applicable when mime_type is APPLICATION_JSON.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResponseFormat(
            global::Google.Gemini.TextResponseFormatMimeType? mimeType,
            object? schema)
        {
            this.MimeType = mimeType;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        public TextResponseFormat()
        {
        }

    }
}