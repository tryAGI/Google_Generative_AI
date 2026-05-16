#nullable enable

namespace Google.Gemini.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioResponseFormatMimeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.AudioResponseFormatMimeType>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.AudioResponseFormatMimeType Read(
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
                        return global::Google.Gemini.AudioResponseFormatMimeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.AudioResponseFormatMimeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.AudioResponseFormatMimeType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.AudioResponseFormatMimeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Google.Gemini.AudioResponseFormatMimeTypeExtensions.ToValueString(value));
        }
    }
}
