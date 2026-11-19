#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class DocumentMediaProcessingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.DocumentMediaProcessing>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.DocumentMediaProcessing Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("page_options")) __score0++;
            if (__jsonProps.Contains("page_options.content_layers")) __score0++;
            if (__jsonProps.Contains("page_options.end_page")) __score0++;
            if (__jsonProps.Contains("page_options.start_page")) __score0++;
            if (__jsonProps.Contains("spreadsheet_options")) __score0++;
            if (__jsonProps.Contains("spreadsheet_options.content_layers")) __score0++;
            if (__jsonProps.Contains("spreadsheet_options.sheet_index")) __score0++;
            if (__jsonProps.Contains("spreadsheet_options.visible_cells")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Google.Gemini.NextGen.DocumentStaticMediaProcessing? @static = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentStaticMediaProcessing> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing).Name}");
                        @static = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (@static == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentStaticMediaProcessing> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing).Name}");
                    @static = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Google.Gemini.NextGen.DocumentMediaProcessing(
                @static
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.DocumentMediaProcessing value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentStaticMediaProcessing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStatic(), typeInfo);
            }
        }
    }
}