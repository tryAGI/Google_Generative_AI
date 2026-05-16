#nullable enable

namespace Google.Gemini.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageResponseFormatDeliveryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.ImageResponseFormatDelivery>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.ImageResponseFormatDelivery Read(
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
                        return global::Google.Gemini.ImageResponseFormatDeliveryExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.ImageResponseFormatDelivery)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.ImageResponseFormatDelivery);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.ImageResponseFormatDelivery value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Google.Gemini.ImageResponseFormatDeliveryExtensions.ToValueString(value));
        }
    }
}
