
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response message for TriggerService.ListTriggerExecutions.
    /// </summary>
    public sealed partial class ListTriggerExecutionsResponse
    {
        /// <summary>
        /// A page token, received from a previous `ListTriggerExecutions` call.<br/>
        /// Provide this to retrieve the subsequent page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The list of trigger executions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_executions")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? TriggerExecutions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggerExecutionsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// A page token, received from a previous `ListTriggerExecutions` call.<br/>
        /// Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="triggerExecutions">
        /// The list of trigger executions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTriggerExecutionsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? triggerExecutions)
        {
            this.NextPageToken = nextPageToken;
            this.TriggerExecutions = triggerExecutions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggerExecutionsResponse" /> class.
        /// </summary>
        public ListTriggerExecutionsResponse()
        {
        }

    }
}