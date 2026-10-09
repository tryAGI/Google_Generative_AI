
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPServerToolResultDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> Result { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="MCPServerToolResultDelta" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="serverName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerToolResultDelta(
            global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string> result,
            object type,
            string? name,
            string? serverName)
        {
            this.Name = name;
            this.Result = result;
            this.ServerName = serverName;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerToolResultDelta" /> class.
        /// </summary>
        public MCPServerToolResultDelta()
        {
        }

    }
}