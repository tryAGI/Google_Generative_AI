
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response message for TriggerService.ListTriggers.
    /// </summary>
    public sealed partial class ListTriggersResponse
    {
        /// <summary>
        /// A page token, received from a previous `ListTriggers` call.<br/>
        /// Provide this to retrieve the subsequent page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The list of triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggersResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// A page token, received from a previous `ListTriggers` call.<br/>
        /// Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="triggers">
        /// The list of triggers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTriggersResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? triggers)
        {
            this.NextPageToken = nextPageToken;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTriggersResponse" /> class.
        /// </summary>
        public ListTriggersResponse()
        {
        }

    }
}