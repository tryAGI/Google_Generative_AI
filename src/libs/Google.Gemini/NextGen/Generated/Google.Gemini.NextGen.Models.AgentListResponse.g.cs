
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentListResponse
    {
        /// <summary>
        /// The list of agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Agents { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListResponse" /> class.
        /// </summary>
        /// <param name="agents">
        /// The list of agents.
        /// </param>
        /// <param name="nextPageToken">
        /// A token to retrieve the next page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentListResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? agents,
            string? nextPageToken)
        {
            this.Agents = agents;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListResponse" /> class.
        /// </summary>
        public AgentListResponse()
        {
        }

    }
}