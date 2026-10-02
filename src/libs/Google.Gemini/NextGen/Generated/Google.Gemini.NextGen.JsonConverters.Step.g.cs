#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class StepJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.Step>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.Step Read(
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
            if (__jsonProps.Contains("arguments.code")) __score0++;
            if (__jsonProps.Contains("arguments.language")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("signature")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("call_id")) __score1++;
            if (__jsonProps.Contains("is_error")) __score1++;
            if (__jsonProps.Contains("result")) __score1++;
            if (__jsonProps.Contains("signature")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("signature")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("signature")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("arguments")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("call_id")) __score5++;
            if (__jsonProps.Contains("is_error")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("result")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("arguments")) __score6++;
            if (__jsonProps.Contains("arguments.queries")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("signature")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("result")) __score7++;
            if (__jsonProps.Contains("signature")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("arguments")) __score8++;
            if (__jsonProps.Contains("arguments.queries")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("search_type")) __score8++;
            if (__jsonProps.Contains("signature")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("call_id")) __score9++;
            if (__jsonProps.Contains("is_error")) __score9++;
            if (__jsonProps.Contains("result")) __score9++;
            if (__jsonProps.Contains("signature")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("arguments")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("server_name")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("call_id")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("result")) __score11++;
            if (__jsonProps.Contains("server_name")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("content")) __score12++;
            if (__jsonProps.Contains("error")) __score12++;
            if (__jsonProps.Contains("error.code")) __score12++;
            if (__jsonProps.Contains("error.details")) __score12++;
            if (__jsonProps.Contains("error.message")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("signature")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("call_id")) __score14++;
            if (__jsonProps.Contains("signature")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("arguments")) __score15++;
            if (__jsonProps.Contains("arguments.queries")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("retrieval_type")) __score15++;
            if (__jsonProps.Contains("signature")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("call_id")) __score16++;
            if (__jsonProps.Contains("is_error")) __score16++;
            if (__jsonProps.Contains("signature")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("signature")) __score17++;
            if (__jsonProps.Contains("summary")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("arguments")) __score18++;
            if (__jsonProps.Contains("arguments.urls")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("signature")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("call_id")) __score19++;
            if (__jsonProps.Contains("is_error")) __score19++;
            if (__jsonProps.Contains("result")) __score19++;
            if (__jsonProps.Contains("signature")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("content")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
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

            global::Google.Gemini.NextGen.CodeExecutionCallStep? codeExecutionCall = default;
            global::Google.Gemini.NextGen.CodeExecutionResultStep? codeExecutionResult = default;
            global::Google.Gemini.NextGen.FileSearchCallStep? fileSearchCall = default;
            global::Google.Gemini.NextGen.FileSearchResultStep? fileSearchResult = default;
            global::Google.Gemini.NextGen.FunctionCallStep? functionCall = default;
            global::Google.Gemini.NextGen.FunctionResultStep? functionResult = default;
            global::Google.Gemini.NextGen.GoogleMapsCallStep? googleMapsCall = default;
            global::Google.Gemini.NextGen.GoogleMapsResultStep? googleMapsResult = default;
            global::Google.Gemini.NextGen.GoogleSearchCallStep? googleSearchCall = default;
            global::Google.Gemini.NextGen.GoogleSearchResultStep? googleSearchResult = default;
            global::Google.Gemini.NextGen.MCPServerToolCallStep? mCPServerToolCall = default;
            global::Google.Gemini.NextGen.MCPServerToolResultStep? mCPServerToolResult = default;
            global::Google.Gemini.NextGen.ModelOutputStep? modelOutput = default;
            global::Google.Gemini.NextGen.ProcessingCallStep? processingCall = default;
            global::Google.Gemini.NextGen.ProcessingResultStep? processingResult = default;
            global::Google.Gemini.NextGen.RetrievalCallStep? retrievalCall = default;
            global::Google.Gemini.NextGen.RetrievalResultStep? retrievalResult = default;
            global::Google.Gemini.NextGen.ThoughtStep? thought = default;
            global::Google.Gemini.NextGen.URLContextCallStep? uRLContextCall = default;
            global::Google.Gemini.NextGen.URLContextResultStep? uRLContextResult = default;
            global::Google.Gemini.NextGen.UserInputStep? userInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep).Name}");
                        codeExecutionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep).Name}");
                        codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallStep).Name}");
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultStep).Name}");
                        fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionCallStep).Name}");
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultStep).Name}");
                        functionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep).Name}");
                        googleMapsCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep).Name}");
                        googleMapsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep).Name}");
                        googleSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep).Name}");
                        googleSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep).Name}");
                        mCPServerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep).Name}");
                        mCPServerToolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ModelOutputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ModelOutputStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ModelOutputStep).Name}");
                        modelOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallStep).Name}");
                        processingCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultStep).Name}");
                        processingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallStep).Name}");
                        retrievalCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultStep).Name}");
                        retrievalResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtStep).Name}");
                        thought = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallStep).Name}");
                        uRLContextCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultStep).Name}");
                        uRLContextResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.UserInputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.UserInputStep> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.UserInputStep).Name}");
                        userInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep).Name}");
                    codeExecutionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep).Name}");
                    codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallStep).Name}");
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultStep).Name}");
                    fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionCallStep).Name}");
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultStep).Name}");
                    functionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep).Name}");
                    googleMapsCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep).Name}");
                    googleMapsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep).Name}");
                    googleSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep).Name}");
                    googleSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep).Name}");
                    mCPServerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep).Name}");
                    mCPServerToolResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ModelOutputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ModelOutputStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ModelOutputStep).Name}");
                    modelOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallStep).Name}");
                    processingCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultStep).Name}");
                    processingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallStep).Name}");
                    retrievalCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultStep).Name}");
                    retrievalResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtStep).Name}");
                    thought = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallStep).Name}");
                    uRLContextCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultStep).Name}");
                    uRLContextResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (codeExecutionCall == null && codeExecutionResult == null && fileSearchCall == null && fileSearchResult == null && functionCall == null && functionResult == null && googleMapsCall == null && googleMapsResult == null && googleSearchCall == null && googleSearchResult == null && mCPServerToolCall == null && mCPServerToolResult == null && modelOutput == null && processingCall == null && processingResult == null && retrievalCall == null && retrievalResult == null && thought == null && uRLContextCall == null && uRLContextResult == null && userInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.UserInputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.UserInputStep> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.UserInputStep).Name}");
                    userInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Google.Gemini.NextGen.Step(
                codeExecutionCall,

                codeExecutionResult,

                fileSearchCall,

                fileSearchResult,

                functionCall,

                functionResult,

                googleMapsCall,

                googleMapsResult,

                googleSearchCall,

                googleSearchResult,

                mCPServerToolCall,

                mCPServerToolResult,

                modelOutput,

                processingCall,

                processingResult,

                retrievalCall,

                retrievalResult,

                thought,

                uRLContextCall,

                uRLContextResult,

                userInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.Step value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeExecutionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecutionCall(), typeInfo);
            }
            else if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.CodeExecutionResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecutionResult(), typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileSearchCall(), typeInfo);
            }
            else if (value.IsFileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FileSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FileSearchResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FileSearchResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileSearchResult(), typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCall(), typeInfo);
            }
            else if (value.IsFunctionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.FunctionResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.FunctionResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.FunctionResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionResult(), typeInfo);
            }
            else if (value.IsGoogleMapsCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGoogleMapsCall(), typeInfo);
            }
            else if (value.IsGoogleMapsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleMapsResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGoogleMapsResult(), typeInfo);
            }
            else if (value.IsGoogleSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGoogleSearchCall(), typeInfo);
            }
            else if (value.IsGoogleSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.GoogleSearchResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGoogleSearchResult(), typeInfo);
            }
            else if (value.IsMCPServerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMCPServerToolCall(), typeInfo);
            }
            else if (value.IsMCPServerToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.MCPServerToolResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMCPServerToolResult(), typeInfo);
            }
            else if (value.IsModelOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ModelOutputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ModelOutputStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ModelOutputStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutput(), typeInfo);
            }
            else if (value.IsProcessingCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickProcessingCall(), typeInfo);
            }
            else if (value.IsProcessingResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ProcessingResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ProcessingResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ProcessingResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickProcessingResult(), typeInfo);
            }
            else if (value.IsRetrievalCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetrievalCall(), typeInfo);
            }
            else if (value.IsRetrievalResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.RetrievalResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.RetrievalResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.RetrievalResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetrievalResult(), typeInfo);
            }
            else if (value.IsThought)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ThoughtStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ThoughtStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ThoughtStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickThought(), typeInfo);
            }
            else if (value.IsURLContextCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextCallStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextCallStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextCallStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickURLContextCall(), typeInfo);
            }
            else if (value.IsURLContextResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.URLContextResultStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.URLContextResultStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.URLContextResultStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickURLContextResult(), typeInfo);
            }
            else if (value.IsUserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.UserInputStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.UserInputStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.UserInputStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserInput(), typeInfo);
            }
        }
    }
}