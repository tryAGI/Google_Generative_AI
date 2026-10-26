
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Headers to inject into requests matching this rule.<br/>
    /// Key: header name (e.g., "Authorization").<br/>
    /// Value: header value (e.g., "Bearer your-token").
    /// </summary>
    public sealed partial class EgressRuleTransform
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}