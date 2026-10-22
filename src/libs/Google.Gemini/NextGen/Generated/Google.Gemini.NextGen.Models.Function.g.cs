
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model.
    /// </summary>
    public sealed partial class Function
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The JSON Schema for the function's parameters.<br/>
        /// Supports a subset of JSON Schema. `minLength`, `maxLength`,<br/>
        /// `minProperties`, `maxProperties`, `uniqueItems`, `contains`,<br/>
        /// `minContains`, and `maxContains` are ignored and not enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="description">
        /// A description of the function.
        /// </param>
        /// <param name="parameters">
        /// The JSON Schema for the function's parameters.<br/>
        /// Supports a subset of JSON Schema. `minLength`, `maxLength`,<br/>
        /// `minProperties`, `maxProperties`, `uniqueItems`, `contains`,<br/>
        /// `minContains`, and `maxContains` are ignored and not enforced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Function(
            object type,
            string? name,
            string? description,
            object? parameters)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        public Function()
        {
        }

    }
}