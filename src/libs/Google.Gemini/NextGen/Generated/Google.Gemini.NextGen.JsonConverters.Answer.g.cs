#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class AnswerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.Answer>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.Answer Read(
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
            if (__jsonProps.Contains("choice")) __score0++;
            if (__jsonProps.Contains("confidence")) __score0++;
            if (__jsonProps.Contains("probabilities")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("confidence")) __score1++;
            if (__jsonProps.Contains("noul")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("confidence")) __score2++;
            if (__jsonProps.Contains("legend")) __score2++;
            if (__jsonProps.Contains("probabilities")) __score2++;
            if (__jsonProps.Contains("score")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Google.Gemini.NextGen.ChoiceAnswer? choice = default;
            global::Google.Gemini.NextGen.NoulAnswer? noul = default;
            global::Google.Gemini.NextGen.ScoreAnswer? score = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ChoiceAnswer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ChoiceAnswer).Name}");
                        choice = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.NoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.NoulAnswer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.NoulAnswer).Name}");
                        noul = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ScoreAnswer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ScoreAnswer).Name}");
                        score = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (choice == null && noul == null && score == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ChoiceAnswer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ChoiceAnswer).Name}");
                    choice = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (choice == null && noul == null && score == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.NoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.NoulAnswer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.NoulAnswer).Name}");
                    noul = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (choice == null && noul == null && score == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ScoreAnswer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ScoreAnswer).Name}");
                    score = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Google.Gemini.NextGen.Answer(
                choice,

                noul,

                score
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.Answer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ChoiceAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ChoiceAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.NoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.NoulAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.NoulAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ScoreAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ScoreAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}