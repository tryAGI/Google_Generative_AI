
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for the Deep Research agent.
    /// </summary>
    public sealed partial class DeepResearchAgentConfig
    {
        /// <summary>
        /// Enables human-in-the-loop planning for the Deep Research agent. If set to<br/>
        /// true, the Deep Research agent will provide a research plan in its response.<br/>
        /// The agent will then proceed only if the user confirms the plan in the next<br/>
        /// turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborative_planning")]
        public bool? CollaborativePlanning { get; set; }

        /// <summary>
        /// Enables bigquery tool for the Deep Research agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_bigquery_tool")]
        public bool? EnableBigqueryTool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_summaries")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingSummariesJsonConverter))]
        public global::Google.Gemini.NextGen.ThinkingSummaries? ThinkingSummaries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Whether to include visualizations in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.DeepResearchAgentConfigVisualizationJsonConverter))]
        public global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? Visualization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepResearchAgentConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="collaborativePlanning">
        /// Enables human-in-the-loop planning for the Deep Research agent. If set to<br/>
        /// true, the Deep Research agent will provide a research plan in its response.<br/>
        /// The agent will then proceed only if the user confirms the plan in the next<br/>
        /// turn.
        /// </param>
        /// <param name="enableBigqueryTool">
        /// Enables bigquery tool for the Deep Research agent.
        /// </param>
        /// <param name="thinkingSummaries"></param>
        /// <param name="visualization">
        /// Whether to include visualizations in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepResearchAgentConfig(
            object type,
            bool? collaborativePlanning,
            bool? enableBigqueryTool,
            global::Google.Gemini.NextGen.ThinkingSummaries? thinkingSummaries,
            global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? visualization)
        {
            this.CollaborativePlanning = collaborativePlanning;
            this.EnableBigqueryTool = enableBigqueryTool;
            this.ThinkingSummaries = thinkingSummaries;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Visualization = visualization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepResearchAgentConfig" /> class.
        /// </summary>
        public DeepResearchAgentConfig()
        {
        }

    }
}