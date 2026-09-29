#nullable enable

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public sealed class TriggerUpdateStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.TriggerUpdateStatus?>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.TriggerUpdateStatus? Read(
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
                        return global::Google.Gemini.NextGen.TriggerUpdateStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.NextGen.TriggerUpdateStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.NextGen.TriggerUpdateStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.TriggerUpdateStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Google.Gemini.NextGen.TriggerUpdateStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
