
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The Tool configuration containing parameters for specifying `Tool` use in the request.
    /// </summary>
    public sealed partial class ToolConfig
    {
        /// <summary>
        /// Optional. If true, the API response will include the server-side tool calls and responses within the `Content` message. This allows clients to observe the server's tool interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeServerSideToolInvocations")]
        public bool? IncludeServerSideToolInvocations { get; set; }

        /// <summary>
        /// Configuration for specifying function calling behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCallingConfig")]
        public global::Google.Gemini.FunctionCallingConfig? FunctionCallingConfig { get; set; }

        /// <summary>
        /// Retrieval config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalConfig")]
        public global::Google.Gemini.RetrievalConfig? RetrievalConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfig" /> class.
        /// </summary>
        /// <param name="includeServerSideToolInvocations">
        /// Optional. If true, the API response will include the server-side tool calls and responses within the `Content` message. This allows clients to observe the server's tool interactions.
        /// </param>
        /// <param name="functionCallingConfig">
        /// Configuration for specifying function calling behavior.
        /// </param>
        /// <param name="retrievalConfig">
        /// Retrieval config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfig(
            bool? includeServerSideToolInvocations,
            global::Google.Gemini.FunctionCallingConfig? functionCallingConfig,
            global::Google.Gemini.RetrievalConfig? retrievalConfig)
        {
            this.IncludeServerSideToolInvocations = includeServerSideToolInvocations;
            this.FunctionCallingConfig = functionCallingConfig;
            this.RetrievalConfig = retrievalConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfig" /> class.
        /// </summary>
        public ToolConfig()
        {
        }
    }
}