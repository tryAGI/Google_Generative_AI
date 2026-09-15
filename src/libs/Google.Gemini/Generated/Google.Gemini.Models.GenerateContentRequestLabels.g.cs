
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Labels with user-defined metadata for the request. Optional. Labels must follow standard unified Cloud label requirements: - Label keys must start with a letter. - Label keys and values can be no longer than 63 characters (Unicode codepoints) and can only contain lowercase letters, numeric characters, underscores, and dashes. - International characters are allowed. Usage: - Safety identifiers from aggregators: Use the key `safety_identifier` (e.g. `{"safety_identifier": "user_session_123"}`)
    /// </summary>
    public sealed partial class GenerateContentRequestLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}