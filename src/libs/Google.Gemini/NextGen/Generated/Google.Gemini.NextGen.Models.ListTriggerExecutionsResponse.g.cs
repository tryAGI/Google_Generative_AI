
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response for listing trigger executions.
    /// </summary>
    public sealed partial class ListTriggerExecutionsResponse
    {
        /// <summary>
        /// The list of trigger executions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_executions")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? TriggerExecutions { get; set; }

        /// <summary>
        /// A token to retrieve the next page of trigger executions. Pass it as<br/>
        /// `page_token` in the next request. If empty, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggerExecutionsResponse" /> class.
        /// </summary>
        /// <param name="triggerExecutions">
        /// The list of trigger executions.
        /// </param>
        /// <param name="nextPageToken">
        /// A token to retrieve the next page of trigger executions. Pass it as<br/>
        /// `page_token` in the next request. If empty, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTriggerExecutionsResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? triggerExecutions,
            string? nextPageToken)
        {
            this.TriggerExecutions = triggerExecutions;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggerExecutionsResponse" /> class.
        /// </summary>
        public ListTriggerExecutionsResponse()
        {
        }

    }
}