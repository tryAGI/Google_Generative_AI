
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The JSON schema that the output should conform to. Only applicable when<br/>
    /// mime_type is application/json.
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