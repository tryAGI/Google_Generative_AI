
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for the CodeMender agent.
    /// </summary>
    public sealed partial class CodeMenderAgentConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Request parameters specific to FIND sessions, used for discovering<br/>
        /// vulnerabilities in a codebase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("find_request")]
        public global::Google.Gemini.NextGen.FindRequest? FindRequest { get; set; }

        /// <summary>
        /// Request parameters specific to FIX sessions, used for generating and<br/>
        /// validating security patches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_request")]
        public global::Google.Gemini.NextGen.FixRequest? FixRequest { get; set; }

        /// <summary>
        /// Parameter for grouping multiple interactions that belong to<br/>
        /// the same CodeMender session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The configuration of CodeMender sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_config")]
        public global::Google.Gemini.NextGen.SessionConfig? SessionConfig { get; set; }

        /// <summary>
        /// The name of the model to use for the CodeMender agent. One<br/>
        /// CodeMender session will only use one model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeMenderAgentConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="findRequest">
        /// Request parameters specific to FIND sessions, used for discovering<br/>
        /// vulnerabilities in a codebase.
        /// </param>
        /// <param name="fixRequest">
        /// Request parameters specific to FIX sessions, used for generating and<br/>
        /// validating security patches.
        /// </param>
        /// <param name="sessionId">
        /// Parameter for grouping multiple interactions that belong to<br/>
        /// the same CodeMender session.
        /// </param>
        /// <param name="sessionConfig">
        /// The configuration of CodeMender sessions.
        /// </param>
        /// <param name="model">
        /// The name of the model to use for the CodeMender agent. One<br/>
        /// CodeMender session will only use one model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeMenderAgentConfig(
            object type,
            global::Google.Gemini.NextGen.FindRequest? findRequest,
            global::Google.Gemini.NextGen.FixRequest? fixRequest,
            string? sessionId,
            global::Google.Gemini.NextGen.SessionConfig? sessionConfig,
            string? model)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FindRequest = findRequest;
            this.FixRequest = fixRequest;
            this.SessionId = sessionId;
            this.SessionConfig = sessionConfig;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeMenderAgentConfig" /> class.
        /// </summary>
        public CodeMenderAgentConfig()
        {
        }

    }
}