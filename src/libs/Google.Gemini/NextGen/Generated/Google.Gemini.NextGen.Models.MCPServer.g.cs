
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A MCPServer is a server that can be called by the model to perform actions.
    /// </summary>
    public sealed partial class MCPServer
    {
        /// <summary>
        /// The allowed tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? AllowedTools { get; set; }

        /// <summary>
        /// Optional: Fields for authentication headers, timeouts, etc., if needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The name of the MCPServer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The full URL for the MCPServer endpoint.<br/>
        /// Example: "https://api.example.com/mcp"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServer" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="allowedTools">
        /// The allowed tools.
        /// </param>
        /// <param name="headers">
        /// Optional: Fields for authentication headers, timeouts, etc., if needed.
        /// </param>
        /// <param name="name">
        /// The name of the MCPServer.
        /// </param>
        /// <param name="url">
        /// The full URL for the MCPServer endpoint.<br/>
        /// Example: "https://api.example.com/mcp"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServer(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? allowedTools,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? name,
            string? url)
        {
            this.AllowedTools = allowedTools;
            this.Headers = headers;
            this.Name = name;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServer" /> class.
        /// </summary>
        public MCPServer()
        {
        }

    }
}