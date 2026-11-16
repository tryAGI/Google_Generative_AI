
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Mutually exclusive options to choose from (between 2 and 255 options),<br/>
    /// mapping option ID to optional description or rubric criteria. Option IDs<br/>
    /// must be non-empty with no control characters or leading/trailing<br/>
    /// whitespace.
    /// </summary>
    public sealed partial class ChoiceQuestionCriteria
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}