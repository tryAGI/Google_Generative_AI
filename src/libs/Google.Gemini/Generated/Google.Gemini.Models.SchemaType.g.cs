
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Data type.
    /// </summary>
    public enum SchemaType
    {
        /// <summary>
        /// Not specified, should not be used.
        /// </summary>
        TypeUnspecified,
        /// <summary>
        /// String type.
        /// </summary>
        String,
        /// <summary>
        /// Number type.
        /// </summary>
        Number,
        /// <summary>
        /// Integer type.
        /// </summary>
        Integer,
        /// <summary>
        /// Boolean type.
        /// </summary>
        Boolean,
        /// <summary>
        /// Array type.
        /// </summary>
        Array,
        /// <summary>
        /// Object type.
        /// </summary>
        Object,
        /// <summary>
        /// Null type.
        /// </summary>
        Null,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaType value)
        {
            return value switch
            {
                SchemaType.TypeUnspecified => "TYPE_UNSPECIFIED",
                SchemaType.String => "STRING",
                SchemaType.Number => "NUMBER",
                SchemaType.Integer => "INTEGER",
                SchemaType.Boolean => "BOOLEAN",
                SchemaType.Array => "ARRAY",
                SchemaType.Object => "OBJECT",
                SchemaType.Null => "NULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaType? ToEnum(string value)
        {
            return value switch
            {
                "TYPE_UNSPECIFIED" => SchemaType.TypeUnspecified,
                "STRING" => SchemaType.String,
                "NUMBER" => SchemaType.Number,
                "INTEGER" => SchemaType.Integer,
                "BOOLEAN" => SchemaType.Boolean,
                "ARRAY" => SchemaType.Array,
                "OBJECT" => SchemaType.Object,
                "NULL" => SchemaType.Null,
                _ => null,
            };
        }
    }
}