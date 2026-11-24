
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that allows the model to dynamically search for and load tools into<br/>
    /// the model’s context on demand. This allows clients to avoid loading all tool<br/>
    /// definitions up front and may help reduce overall token usage and cost.
    /// </summary>
    public sealed partial class ToolSearch
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The name of the function. To be set only for client-side execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the function. To be set only for client-side execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The JSON Schema for the function's parameters. To be set only for<br/>
        /// client-side execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// The execution mode of the tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ToolSearchExecutionJsonConverter))]
        public global::Google.Gemini.NextGen.ToolSearchExecution? Execution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearch" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the function. To be set only for client-side execution.
        /// </param>
        /// <param name="description">
        /// A description of the function. To be set only for client-side execution.
        /// </param>
        /// <param name="parameters">
        /// The JSON Schema for the function's parameters. To be set only for<br/>
        /// client-side execution.
        /// </param>
        /// <param name="execution">
        /// The execution mode of the tool search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearch(
            object type,
            string? name,
            string? description,
            object? parameters,
            global::Google.Gemini.NextGen.ToolSearchExecution? execution)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.Execution = execution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearch" /> class.
        /// </summary>
        public ToolSearch()
        {
        }

    }
}