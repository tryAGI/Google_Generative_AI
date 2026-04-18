
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Structured representation of a function declaration as defined by the [OpenAPI 3.03 specification](https://spec.openapis.org/oas/v3.0.3). Included in this declaration are the function name and parameters. This FunctionDeclaration is a representation of a block of code that can be used as a `Tool` by the model and executed by the client.
    /// </summary>
    public sealed partial class FunctionDeclaration
    {
        /// <summary>
        /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FunctionDeclarationBehaviorJsonConverter))]
        public global::Google.Gemini.FunctionDeclarationBehavior? Behavior { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Google.Gemini.Schema? Response { get; set; }

        /// <summary>
        /// Required. The name of the function. Must be a-z, A-Z, 0-9, or contain underscores, colons, dots, and dashes, with a maximum length of 128.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema is the response value of the function. This field is mutually exclusive with `response`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseJsonSchema")]
        public object? ResponseJsonSchema { get; set; }

        /// <summary>
        /// Required. A brief description of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::Google.Gemini.Schema? Parameters { get; set; }

        /// <summary>
        /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object where the properties are the parameters to the function. For example: ``` { "type": "object", "properties": { "name": { "type": "string" }, "age": { "type": "integer" } }, "additionalProperties": false, "required": ["name", "age"], "propertyOrdering": ["name", "age"] } ``` This field is mutually exclusive with `parameters`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parametersJsonSchema")]
        public object? ParametersJsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeclaration" /> class.
        /// </summary>
        /// <param name="behavior">
        /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
        /// </param>
        /// <param name="response">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="name">
        /// Required. The name of the function. Must be a-z, A-Z, 0-9, or contain underscores, colons, dots, and dashes, with a maximum length of 128.
        /// </param>
        /// <param name="responseJsonSchema">
        /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema is the response value of the function. This field is mutually exclusive with `response`.
        /// </param>
        /// <param name="description">
        /// Required. A brief description of the function.
        /// </param>
        /// <param name="parameters">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="parametersJsonSchema">
        /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object where the properties are the parameters to the function. For example: ``` { "type": "object", "properties": { "name": { "type": "string" }, "age": { "type": "integer" } }, "additionalProperties": false, "required": ["name", "age"], "propertyOrdering": ["name", "age"] } ``` This field is mutually exclusive with `parameters`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDeclaration(
            global::Google.Gemini.FunctionDeclarationBehavior? behavior,
            global::Google.Gemini.Schema? response,
            string? name,
            object? responseJsonSchema,
            string? description,
            global::Google.Gemini.Schema? parameters,
            object? parametersJsonSchema)
        {
            this.Behavior = behavior;
            this.Response = response;
            this.Name = name;
            this.ResponseJsonSchema = responseJsonSchema;
            this.Description = description;
            this.Parameters = parameters;
            this.ParametersJsonSchema = parametersJsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeclaration" /> class.
        /// </summary>
        public FunctionDeclaration()
        {
        }
    }
}