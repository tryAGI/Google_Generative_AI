
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The JSON Schema for the function's parameters.<br/>
    /// Supports a subset of JSON Schema. `minLength`, `maxLength`,<br/>
    /// `minProperties`, `maxProperties`, `uniqueItems`, `contains`,<br/>
    /// `minContains`, and `maxContains` are ignored and not enforced.
    /// </summary>
    public sealed partial class FunctionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}