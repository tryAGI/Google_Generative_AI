#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.ResponseFormat>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.ResponseFormat Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("bit_rate")) __score0++;
            if (__jsonProps.Contains("delivery")) __score0++;
            if (__jsonProps.Contains("mime_type")) __score0++;
            if (__jsonProps.Contains("sample_rate")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("aspect_ratio")) __score1++;
            if (__jsonProps.Contains("delivery")) __score1++;
            if (__jsonProps.Contains("image_size")) __score1++;
            if (__jsonProps.Contains("mime_type")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("mime_type")) __score2++;
            if (__jsonProps.Contains("schema")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("aspect_ratio")) __score3++;
            if (__jsonProps.Contains("delivery")) __score3++;
            if (__jsonProps.Contains("duration")) __score3++;
            if (__jsonProps.Contains("resolution")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Google.Gemini.NextGen.AudioResponseFormat? audio = default;
            global::Google.Gemini.NextGen.ImageResponseFormat? image = default;
            global::Google.Gemini.NextGen.TextResponseFormat? text = default;
            global::Google.Gemini.NextGen.VideoResponseFormat? video = default;
            object? responseFormatVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioResponseFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioResponseFormat).Name}");
                        audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageResponseFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageResponseFormat).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextResponseFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextResponseFormat).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoResponseFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoResponseFormat).Name}");
                        video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        responseFormatVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (audio == null && image == null && text == null && video == null && responseFormatVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioResponseFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioResponseFormat).Name}");
                    audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (audio == null && image == null && text == null && video == null && responseFormatVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageResponseFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageResponseFormat).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (audio == null && image == null && text == null && video == null && responseFormatVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextResponseFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextResponseFormat).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (audio == null && image == null && text == null && video == null && responseFormatVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoResponseFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoResponseFormat).Name}");
                    video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (audio == null && image == null && text == null && video == null && responseFormatVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    responseFormatVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Google.Gemini.NextGen.ResponseFormat(
                audio,

                image,

                text,

                video,

                responseFormatVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.ResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAudio(), typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImage(), typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideo(), typeInfo);
            }
            else if (value.IsResponseFormatVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFormatVariant5(), typeInfo);
            }
        }
    }
}