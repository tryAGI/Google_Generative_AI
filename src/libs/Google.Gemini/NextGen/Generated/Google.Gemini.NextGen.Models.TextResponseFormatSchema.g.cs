
#nullable enable

namespace Google.Gemini.NextGen
{
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
    public sealed partial class TextResponseFormatSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}