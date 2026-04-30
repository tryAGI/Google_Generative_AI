
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
    /// </summary>
    public sealed partial class Schema
    {
        /// <summary>
        /// Optional. Indicates if the value may be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nullable")]
        public bool? Nullable { get; set; }

        /// <summary>
        /// Optional. Maximum number of the properties for Type.OBJECT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxProperties")]
        public string? MaxProperties { get; set; }

        /// <summary>
        /// Optional. Minimum number of the properties for Type.OBJECT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minProperties")]
        public string? MinProperties { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Google.Gemini.Schema? Items { get; set; }

        /// <summary>
        /// Optional. Properties of Type.OBJECT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Properties { get; set; }

        /// <summary>
        /// Required. Data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SchemaTypeJsonConverter))]
        public global::Google.Gemini.SchemaType? Type { get; set; }

        /// <summary>
        /// Optional. Minimum number of the elements for Type.ARRAY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minItems")]
        public string? MinItems { get; set; }

        /// <summary>
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anyOf")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? AnyOf { get; set; }

        /// <summary>
        /// Optional. Maximum length of the Type.STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLength")]
        public string? MaxLength { get; set; }

        /// <summary>
        /// Optional. Required properties of Type.OBJECT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minLength")]
        public string? MinLength { get; set; }

        /// <summary>
        /// Optional. Example of the object. Will only populated when the object is the root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public object? Example { get; set; }

        /// <summary>
        /// Optional. The title of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. A brief description of the parameter. This could contain examples of use. Parameter description may be formatted as Markdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// Optional. Pattern of the Type.STRING to restrict a string to a regular expression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Optional. Maximum value of the Type.INTEGER and Type.NUMBER
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// Optional. Default value of the field. Per JSON Schema, this field is intended for documentation generators and doesn't affect validation. Thus it's included here and ignored so that developers who send schemas with a `default` field don't get unknown-field errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Optional. Maximum number of the elements for Type.ARRAY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxItems")]
        public string? MaxItems { get; set; }

        /// <summary>
        /// Optional. The format of the data. Any value is allowed, but most do not trigger any special functionality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Optional. The order of the properties. Not a standard field in open api spec. Used to determine the order of the properties in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propertyOrdering")]
        public global::System.Collections.Generic.IList<string>? PropertyOrdering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        /// <param name="nullable">
        /// Optional. Indicates if the value may be null.
        /// </param>
        /// <param name="maxProperties">
        /// Optional. Maximum number of the properties for Type.OBJECT.
        /// </param>
        /// <param name="minProperties">
        /// Optional. Minimum number of the properties for Type.OBJECT.
        /// </param>
        /// <param name="items">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="properties">
        /// Optional. Properties of Type.OBJECT.
        /// </param>
        /// <param name="type">
        /// Required. Data type.
        /// </param>
        /// <param name="minItems">
        /// Optional. Minimum number of the elements for Type.ARRAY.
        /// </param>
        /// <param name="anyOf">
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </param>
        /// <param name="maxLength">
        /// Optional. Maximum length of the Type.STRING
        /// </param>
        /// <param name="required">
        /// Optional. Required properties of Type.OBJECT.
        /// </param>
        /// <param name="minLength">
        /// Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING
        /// </param>
        /// <param name="example">
        /// Optional. Example of the object. Will only populated when the object is the root.
        /// </param>
        /// <param name="title">
        /// Optional. The title of the schema.
        /// </param>
        /// <param name="description">
        /// Optional. A brief description of the parameter. This could contain examples of use. Parameter description may be formatted as Markdown.
        /// </param>
        /// <param name="minimum">
        /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
        /// </param>
        /// <param name="pattern">
        /// Optional. Pattern of the Type.STRING to restrict a string to a regular expression.
        /// </param>
        /// <param name="enum">
        /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
        /// </param>
        /// <param name="maximum">
        /// Optional. Maximum value of the Type.INTEGER and Type.NUMBER
        /// </param>
        /// <param name="default">
        /// Optional. Default value of the field. Per JSON Schema, this field is intended for documentation generators and doesn't affect validation. Thus it's included here and ignored so that developers who send schemas with a `default` field don't get unknown-field errors.
        /// </param>
        /// <param name="maxItems">
        /// Optional. Maximum number of the elements for Type.ARRAY.
        /// </param>
        /// <param name="format">
        /// Optional. The format of the data. Any value is allowed, but most do not trigger any special functionality.
        /// </param>
        /// <param name="propertyOrdering">
        /// Optional. The order of the properties. Not a standard field in open api spec. Used to determine the order of the properties in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Schema(
            bool? nullable,
            string? maxProperties,
            string? minProperties,
            global::Google.Gemini.Schema? items,
            global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? properties,
            global::Google.Gemini.SchemaType? type,
            string? minItems,
            global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? anyOf,
            string? maxLength,
            global::System.Collections.Generic.IList<string>? required,
            string? minLength,
            object? example,
            string? title,
            string? description,
            double? minimum,
            string? pattern,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maximum,
            object? @default,
            string? maxItems,
            string? format,
            global::System.Collections.Generic.IList<string>? propertyOrdering)
        {
            this.Nullable = nullable;
            this.MaxProperties = maxProperties;
            this.MinProperties = minProperties;
            this.Items = items;
            this.Properties = properties;
            this.Type = type;
            this.MinItems = minItems;
            this.AnyOf = anyOf;
            this.MaxLength = maxLength;
            this.Required = required;
            this.MinLength = minLength;
            this.Example = example;
            this.Title = title;
            this.Description = description;
            this.Minimum = minimum;
            this.Pattern = pattern;
            this.Enum = @enum;
            this.Maximum = maximum;
            this.Default = @default;
            this.MaxItems = maxItems;
            this.Format = format;
            this.PropertyOrdering = propertyOrdering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        public Schema()
        {
        }
    }
}