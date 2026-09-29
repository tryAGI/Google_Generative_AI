
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The labels with user-defined metadata for the request.<br/>
    /// Label keys and values can be no longer than 63 characters<br/>
    /// (Unicode codepoints) and can only contain lowercase letters, numeric<br/>
    /// characters, underscores, and dashes. International characters are allowed.<br/>
    /// Label values are optional. Label keys must start with a letter.
    /// </summary>
    public sealed partial class CreateModelInteractionLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}