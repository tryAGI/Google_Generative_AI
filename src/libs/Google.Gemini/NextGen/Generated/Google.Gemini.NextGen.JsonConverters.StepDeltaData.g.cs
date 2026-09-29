#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class StepDeltaDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.StepDeltaData>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.StepDeltaData Read(
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
            if (__jsonProps.Contains("arguments")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("channels")) __score1++;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("mime_type")) __score1++;
            if (__jsonProps.Contains("rate")) __score1++;
            if (__jsonProps.Contains("sample_rate")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("uri")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("arguments.code")) __score2++;
            if (__jsonProps.Contains("arguments.language")) __score2++;
            if (__jsonProps.Contains("signature")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("is_error")) __score3++;
            if (__jsonProps.Contains("result")) __score3++;
            if (__jsonProps.Contains("signature")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("mime_type")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("uri")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("signature")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("result")) __score6++;
            if (__jsonProps.Contains("signature")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("is_error")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("result")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("arguments")) __score8++;
            if (__jsonProps.Contains("arguments.queries")) __score8++;
            if (__jsonProps.Contains("signature")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("result")) __score9++;
            if (__jsonProps.Contains("signature")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("arguments")) __score10++;
            if (__jsonProps.Contains("arguments.queries")) __score10++;
            if (__jsonProps.Contains("signature")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("is_error")) __score11++;
            if (__jsonProps.Contains("result")) __score11++;
            if (__jsonProps.Contains("signature")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("data")) __score12++;
            if (__jsonProps.Contains("mime_type")) __score12++;
            if (__jsonProps.Contains("resolution")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("uri")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("arguments")) __score13++;
            if (__jsonProps.Contains("name")) __score13++;
            if (__jsonProps.Contains("server_name")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("name")) __score14++;
            if (__jsonProps.Contains("result")) __score14++;
            if (__jsonProps.Contains("server_name")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("signature")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("signature")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("arguments")) __score17++;
            if (__jsonProps.Contains("arguments.queries")) __score17++;
            if (__jsonProps.Contains("retrieval_type")) __score17++;
            if (__jsonProps.Contains("signature")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("is_error")) __score18++;
            if (__jsonProps.Contains("signature")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("annotations")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("text")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("signature")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("content")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("arguments")) __score23++;
            if (__jsonProps.Contains("arguments.urls")) __score23++;
            if (__jsonProps.Contains("signature")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("is_error")) __score24++;
            if (__jsonProps.Contains("result")) __score24++;
            if (__jsonProps.Contains("signature")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("data")) __score25++;
            if (__jsonProps.Contains("mime_type")) __score25++;
            if (__jsonProps.Contains("resolution")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            if (__jsonProps.Contains("uri")) __score25++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }

            global::Google.Gemini.NextGen.ArgumentsDelta? arguments = default;
            global::Google.Gemini.NextGen.AudioDelta? audio = default;
            global::Google.Gemini.NextGen.CodeExecutionCallDelta? codeExecutionCall = default;
            global::Google.Gemini.NextGen.CodeExecutionResultDelta? codeExecutionResult = default;
            global::Google.Gemini.NextGen.DocumentDelta? document = default;
            global::Google.Gemini.NextGen.FileSearchCallDelta? fileSearchCall = default;
            global::Google.Gemini.NextGen.FileSearchResultDelta? fileSearchResult = default;
            global::Google.Gemini.NextGen.FunctionResultDelta? functionResult = default;
            global::Google.Gemini.NextGen.GoogleMapsCallDelta? googleMapsCall = default;
            global::Google.Gemini.NextGen.GoogleMapsResultDelta? googleMapsResult = default;
            global::Google.Gemini.NextGen.GoogleSearchCallDelta? googleSearchCall = default;
            global::Google.Gemini.NextGen.GoogleSearchResultDelta? googleSearchResult = default;
            global::Google.Gemini.NextGen.ImageDelta? image = default;
            global::Google.Gemini.NextGen.MCPServerToolCallDelta? mCPServerToolCall = default;
            global::Google.Gemini.NextGen.MCPServerToolResultDelta? mCPServerToolResult = default;
            global::Google.Gemini.NextGen.ProcessingCallDelta? processingCall = default;
            global::Google.Gemini.NextGen.ProcessingResultDelta? processingResult = default;
            global::Google.Gemini.NextGen.RetrievalCallDelta? retrievalCall = default;
            global::Google.Gemini.NextGen.RetrievalResultDelta? retrievalResult = default;
            global::Google.Gemini.NextGen.TextAnnotationDelta? textAnnotation = default;
            global::Google.Gemini.NextGen.TextDelta? text = default;
            global::Google.Gemini.NextGen.ThoughtSignatureDelta? thoughtSignature = default;
            global::Google.Gemini.NextGen.ThoughtSummaryDelta? thoughtSummary = default;
            global::Google.Gemini.NextGen.URLContextCallDelta? uRLContextCall = default;
            global::Google.Gemini.NextGen.URLContextResultDelta? uRLContextResult = default;
            global::Google.Gemini.NextGen.VideoDelta? video = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ArgumentsDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ArgumentsDelta).Name}");
                        arguments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioDelta).Name}");
                        audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta).Name}");
                        codeExecutionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta).Name}");
                        codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentDelta).Name}");
                        document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallDelta).Name}");
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultDelta).Name}");
                        fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultDelta).Name}");
                        functionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta).Name}");
                        googleMapsCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta).Name}");
                        googleMapsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta).Name}");
                        googleSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta).Name}");
                        googleSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageDelta).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta).Name}");
                        mCPServerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta).Name}");
                        mCPServerToolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallDelta).Name}");
                        processingCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultDelta).Name}");
                        processingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallDelta).Name}");
                        retrievalCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultDelta).Name}");
                        retrievalResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextAnnotationDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextAnnotationDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextAnnotationDelta).Name}");
                        textAnnotation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextDelta).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSignatureDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta).Name}");
                        thoughtSignature = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSummaryDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta).Name}");
                        thoughtSummary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallDelta).Name}");
                        uRLContextCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultDelta).Name}");
                        uRLContextResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoDelta).Name}");
                        video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ArgumentsDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ArgumentsDelta).Name}");
                    arguments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioDelta).Name}");
                    audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta).Name}");
                    codeExecutionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta).Name}");
                    codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentDelta).Name}");
                    document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallDelta).Name}");
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultDelta).Name}");
                    fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultDelta).Name}");
                    functionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta).Name}");
                    googleMapsCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta).Name}");
                    googleMapsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta).Name}");
                    googleSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta).Name}");
                    googleSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageDelta).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta).Name}");
                    mCPServerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta).Name}");
                    mCPServerToolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallDelta).Name}");
                    processingCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultDelta).Name}");
                    processingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallDelta).Name}");
                    retrievalCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultDelta).Name}");
                    retrievalResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextAnnotationDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextAnnotationDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextAnnotationDelta).Name}");
                    textAnnotation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextDelta).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSignatureDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta).Name}");
                    thoughtSignature = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSummaryDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta).Name}");
                    thoughtSummary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallDelta).Name}");
                    uRLContextCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultDelta).Name}");
                    uRLContextResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (arguments == null && audio == null && codeExecutionCall == null && codeExecutionResult == null && document == null && fileSearchCall == null && fileSearchResult == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && image == null && mCPServerToolCall == null && mCPServerToolResult == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && textAnnotation == null && text == null && thoughtSignature == null && thoughtSummary == null && uRLContextCall == null && uRLContextResult == null && video == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoDelta).Name}");
                    video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Google.Gemini.NextGen.StepDeltaData(
                arguments,

                audio,

                codeExecutionCall,

                codeExecutionResult,

                document,

                fileSearchCall,

                fileSearchResult,

                functionResult,

                googleMapsCall,

                googleMapsResult,

                googleSearchCall,

                googleSearchResult,

                image,

                mCPServerToolCall,

                mCPServerToolResult,

                processingCall,

                processingResult,

                retrievalCall,

                retrievalResult,

                textAnnotation,

                text,

                thoughtSignature,

                thoughtSummary,

                uRLContextCall,

                uRLContextResult,

                video
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.StepDeltaData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArguments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arguments!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.AudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.AudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.AudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsCodeExecutionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionCall!, typeInfo);
            }
            else if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult!, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.DocumentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.DocumentDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.DocumentDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsFileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchResult!, typeInfo);
            }
            else if (value.IsFunctionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionResult!, typeInfo);
            }
            else if (value.IsGoogleMapsCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleMapsCall!, typeInfo);
            }
            else if (value.IsGoogleMapsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleMapsResult!, typeInfo);
            }
            else if (value.IsGoogleSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSearchCall!, typeInfo);
            }
            else if (value.IsGoogleSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSearchResult!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ImageDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ImageDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ImageDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsMCPServerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MCPServerToolCall!, typeInfo);
            }
            else if (value.IsMCPServerToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MCPServerToolResult!, typeInfo);
            }
            else if (value.IsProcessingCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProcessingCall!, typeInfo);
            }
            else if (value.IsProcessingResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProcessingResult!, typeInfo);
            }
            else if (value.IsRetrievalCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RetrievalCall!, typeInfo);
            }
            else if (value.IsRetrievalResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RetrievalResult!, typeInfo);
            }
            else if (value.IsTextAnnotation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextAnnotationDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextAnnotationDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextAnnotationDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextAnnotation!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.TextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.TextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.TextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsThoughtSignature)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSignatureDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThoughtSignature!, typeInfo);
            }
            else if (value.IsThoughtSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtSummaryDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThoughtSummary!, typeInfo);
            }
            else if (value.IsURLContextCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.URLContextCall!, typeInfo);
            }
            else if (value.IsURLContextResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.URLContextResult!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.VideoDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.VideoDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.VideoDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
        }
    }
}