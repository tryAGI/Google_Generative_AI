
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for text output format.
    /// </summary>
    public sealed partial class TextResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The MIME type of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.TextResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// The JSON schema that the output should conform to. Only applicable when<br/>
        /// mime_type is application/json.<br/>
        /// Supports a subset of JSON Schema. `minLength`, `maxLength`,<br/>
        /// `minProperties`, `maxProperties`, `uniqueItems`, `contains`,<br/>
        /// `minContains`, and `maxContains` are ignored and not enforced; validate<br/>
        /// these in your application. `minItems` and `maxItems` are enforced. Schemas<br/>
        /// that are too complex to enforce (for example, large `maxItems` on nested<br/>
        /// arrays) return a 400 INVALID_ARGUMENT error.
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
        /// <param name="type"></param>
        /// <param name="mimeType">
        /// The MIME type of the text output.
        /// </param>
        /// <param name="schema">
        /// The JSON schema that the output should conform to. Only applicable when<br/>
        /// mime_type is application/json.<br/>
        /// Supports a subset of JSON Schema. `minLength`, `maxLength`,<br/>
        /// `minProperties`, `maxProperties`, `uniqueItems`, `contains`,<br/>
        /// `minContains`, and `maxContains` are ignored and not enforced; validate<br/>
        /// these in your application. `minItems` and `maxItems` are enforced. Schemas<br/>
        /// that are too complex to enforce (for example, large `maxItems` on nested<br/>
        /// arrays) return a 400 INVALID_ARGUMENT error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResponseFormat(
            object type,
            global::Google.Gemini.NextGen.TextResponseFormatMimeType? mimeType,
            object? schema)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
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