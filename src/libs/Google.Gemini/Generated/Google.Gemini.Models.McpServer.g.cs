
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A MCPServer is a server that can be called by the model to perform actions. It is a server that implements the MCP protocol. Next ID: 6
    /// </summary>
    public sealed partial class McpServer
    {
        /// <summary>
        /// The name of the MCPServer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A transport that can stream HTTP requests and responses. Next ID: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamableHttpTransport")]
        public global::Google.Gemini.StreamableHttpTransport? StreamableHttpTransport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the MCPServer.
        /// </param>
        /// <param name="streamableHttpTransport">
        /// A transport that can stream HTTP requests and responses. Next ID: 6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServer(
            string? name,
            global::Google.Gemini.StreamableHttpTransport? streamableHttpTransport)
        {
            this.Name = name;
            this.StreamableHttpTransport = streamableHttpTransport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        public McpServer()
        {
        }
    }
}