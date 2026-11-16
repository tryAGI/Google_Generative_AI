#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class DecisionInstructionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.DecisionInstructionContent>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.DecisionInstructionContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Google.Gemini.NextGen.TextContent? text = default;
            if (discriminator?.Type == global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Google.Gemini.NextGen.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Google.Gemini.NextGen.DecisionInstructionContent(
                discriminator?.Type,
                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.DecisionInstructionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
        }
    }
}