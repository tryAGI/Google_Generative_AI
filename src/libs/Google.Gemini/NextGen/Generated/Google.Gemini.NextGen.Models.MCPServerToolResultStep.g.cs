
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// MCPServer tool result step.<br/>
    /// Example: {"name":"calculate_tax","type":"mcp_server_tool_result","call_id":"mcp_call_29012","result":{"tax_due":32400},"server_name":"financial_mcp_server"}
    /// </summary>
    public sealed partial class MCPServerToolResultStep
    {
        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Name of the tool which is called for this specific tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Required. The output from the MCP server call. Can be simple text or rich content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> Result { get; set; }

        /// <summary>
        /// The name of the used MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerToolResultStep" /> class.
        /// </summary>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="result">
        /// Required. The output from the MCP server call. Can be simple text or rich content.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Name of the tool which is called for this specific tool call.
        /// </param>
        /// <param name="serverName">
        /// The name of the used MCP server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerToolResultStep(
            string callId,
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> result,
            object type,
            string? name,
            string? serverName)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name;
            this.Result = result;
            this.ServerName = serverName;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerToolResultStep" /> class.
        /// </summary>
        public MCPServerToolResultStep()
        {
        }

    }
}