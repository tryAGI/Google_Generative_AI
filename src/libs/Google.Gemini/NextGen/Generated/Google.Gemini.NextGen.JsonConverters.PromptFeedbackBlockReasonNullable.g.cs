#nullable enable

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptFeedbackBlockReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.PromptFeedbackBlockReason?>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.PromptFeedbackBlockReason? Read(
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
                        return global::Google.Gemini.NextGen.PromptFeedbackBlockReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Google.Gemini.NextGen.PromptFeedbackBlockReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Google.Gemini.NextGen.PromptFeedbackBlockReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.PromptFeedbackBlockReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Google.Gemini.NextGen.PromptFeedbackBlockReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
