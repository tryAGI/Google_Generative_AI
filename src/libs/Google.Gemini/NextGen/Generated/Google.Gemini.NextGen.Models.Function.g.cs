
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model.
    /// </summary>
    public sealed partial class Function
    {
        /// <summary>
        /// A description of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The JSON Schema for the function's parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

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
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// A description of the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="parameters">
        /// The JSON Schema for the function's parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Function(
            object type,
            string? description,
            string? name,
            object? parameters)
        {
            this.Description = description;
            this.Name = name;
            this.Parameters = parameters;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        public Function()
        {
        }

    }
}