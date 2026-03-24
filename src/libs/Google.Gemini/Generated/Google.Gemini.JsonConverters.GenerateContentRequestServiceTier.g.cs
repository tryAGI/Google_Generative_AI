#nullable enable

namespace Google.Gemini.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateContentRequestServiceTierJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.GenerateContentRequestServiceTier>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.GenerateContentRequestServiceTier Read(
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
                        return global::Google.Gemini.GenerateContentRequestServiceTierExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.GenerateContentRequestServiceTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.GenerateContentRequestServiceTier);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.GenerateContentRequestServiceTier value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Google.Gemini.GenerateContentRequestServiceTierExtensions.ToValueString(value));
        }
    }
}
