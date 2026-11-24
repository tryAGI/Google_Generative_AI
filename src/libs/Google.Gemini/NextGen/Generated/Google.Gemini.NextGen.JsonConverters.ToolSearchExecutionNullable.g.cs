#nullable enable

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolSearchExecutionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.ToolSearchExecution?>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.ToolSearchExecution? Read(
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
                        return global::Google.Gemini.NextGen.ToolSearchExecutionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.NextGen.ToolSearchExecution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.NextGen.ToolSearchExecution?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.ToolSearchExecution? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Google.Gemini.NextGen.ToolSearchExecutionExtensions.ToValueString(value.Value));
            }
        }
    }
}
