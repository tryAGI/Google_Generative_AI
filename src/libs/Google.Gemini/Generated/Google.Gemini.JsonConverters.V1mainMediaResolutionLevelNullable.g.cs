#nullable enable

namespace Google.Gemini.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1mainMediaResolutionLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.V1mainMediaResolutionLevel?>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.V1mainMediaResolutionLevel? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Google.Gemini.V1mainMediaResolutionLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.V1mainMediaResolutionLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.V1mainMediaResolutionLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.V1mainMediaResolutionLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Google.Gemini.V1mainMediaResolutionLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
