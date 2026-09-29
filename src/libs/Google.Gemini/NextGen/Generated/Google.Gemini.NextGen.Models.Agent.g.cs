
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An agent definition for the CreateAgent API.<br/>
    /// This message is the target for annotation-parser-based JSON parsing.<br/>
    /// New format:<br/>
    ///   {<br/>
    ///     "id": "customer-sentinel",<br/>
    ///     "base_agent": "",<br/>
    ///     "system_instruction": "...",<br/>
    ///     "base_environment": { "type": "remote", "sources": [...] },<br/>
    ///     "tools": [ {"type": "code_execution"} ]<br/>
    ///   }
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Configuration parameters for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_config")]
        public global::Google.Gemini.NextGen.AntigravityAgentConfig? AgentConfig { get; set; }

        /// <summary>
        /// The base agent to extend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_agent")]
        public string? BaseAgent { get; set; }

        /// <summary>
        /// The environment configuration for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? BaseEnvironment { get; set; }

        /// <summary>
        /// Agent description for developers to quickly read and understand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The unique identifier for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// System instruction for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instruction")]
        public string? SystemInstruction { get; set; }

        /// <summary>
        /// The tools available to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="agentConfig">
        /// Configuration parameters for the agent.
        /// </param>
        /// <param name="baseAgent">
        /// The base agent to extend.
        /// </param>
        /// <param name="baseEnvironment">
        /// The environment configuration for the agent.
        /// </param>
        /// <param name="description">
        /// Agent description for developers to quickly read and understand.
        /// </param>
        /// <param name="id">
        /// The unique identifier for the agent.
        /// </param>
        /// <param name="systemInstruction">
        /// System instruction for the agent.
        /// </param>
        /// <param name="tools">
        /// The tools available to the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            global::Google.Gemini.NextGen.AntigravityAgentConfig? agentConfig,
            string? baseAgent,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? baseEnvironment,
            string? description,
            string? id,
            string? systemInstruction,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>? tools)
        {
            this.AgentConfig = agentConfig;
            this.BaseAgent = baseAgent;
            this.BaseEnvironment = baseEnvironment;
            this.Description = description;
            this.Id = id;
            this.SystemInstruction = systemInstruction;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }

    }
}