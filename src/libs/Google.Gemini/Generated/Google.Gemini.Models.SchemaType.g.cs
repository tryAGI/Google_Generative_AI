
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Data type.
    /// </summary>
    public enum SchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        TypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
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