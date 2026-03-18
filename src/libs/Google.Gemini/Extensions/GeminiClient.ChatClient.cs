using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Google.Gemini;

public partial class GeminiClient : Meai.IChatClient
{
    /// <summary>
    /// Key used in <see cref="Meai.FunctionCallContent.AdditionalProperties"/> to store the
    /// Gemini thought signature (<c>Part.thoughtSignature</c>). The Gemini API requires this
    /// opaque byte[] to be echoed back on function-call parts in subsequent turns so the model
    /// can correlate its reasoning with tool results. See
    /// https://ai.google.dev/gemini-api/docs/thought-signatures for details.
    /// </summary>
    private const string ThoughtSignatureKey = "gemini.thoughtSignature";
    private Meai.ChatClientMetadata? _chatMetadata;

    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.ChatClientMetadata) ? (_chatMetadata ??= new(nameof(GeminiClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var (modelId, request) = CreateRequest(messages, options);
        var response = await ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return CreateChatResponse(response, modelId);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var (modelId, request) = CreateRequest(messages, options);

        await foreach (var chunk in ModelsStreamGenerateContentAsStreamAsync(
                           modelsId: modelId,
                           request: request,
                           cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            var update = new Meai.ChatResponseUpdate
            {
                Role = Meai.ChatRole.Assistant,
                ResponseId = chunk.ResponseId,
                ModelId = chunk.ModelVersion ?? modelId,
                RawRepresentation = chunk,
            };

            var candidate = chunk.Candidates is { Count: > 0 } ? chunk.Candidates[0] : null;
            if (candidate is not null)
            {
                AddContents(update.Contents, candidate);
                update.FinishReason = ToFinishReason(candidate.FinishReason);
            }

            if (chunk.UsageMetadata is { } usage)
            {
                update.Contents.Add(new Meai.UsageContent(CreateUsageDetails(usage))
                {
                    RawRepresentation = usage,
                });
            }

            yield return update;
        }
    }

    private (string ModelId, GenerateContentRequest Request) CreateRequest(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options)
    {
        var modelId = options?.ModelId ?? "gemini-flash-latest";
        Content? systemInstruction = null;
        var contents = new List<Content>();

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            systemInstruction = new Content
            {
                Parts = [new Part { Text = options!.Instructions }],
            };
        }

        // Build a callId→name lookup from FunctionCallContent items so we can
        // populate the required FunctionResponse.Name for FunctionResultContent items.
        var functionNamesByCallId = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var message in messages)
        {
            foreach (var content in message.Contents)
            {
                if (content is Meai.FunctionCallContent fc && fc.CallId is not null && fc.Name is not null)
                {
                    functionNamesByCallId[fc.CallId] = fc.Name;
                }
            }
        }

        foreach (var message in messages)
        {
            if (message.Role == Meai.ChatRole.System)
            {
                systemInstruction = ToGeminiContent(message, functionNamesByCallId);
                continue;
            }

            contents.Add(ToGeminiContent(message, functionNamesByCallId));
        }

        var request = options?.RawRepresentationFactory?.Invoke(this) as GenerateContentRequest;
        if (request is null)
        {
            request = new GenerateContentRequest
            {
                Model = $"models/{modelId}",
                SystemInstruction = systemInstruction,
                Contents = contents,
            };
        }
        else
        {
            request.Model ??= $"models/{modelId}";
            request.SystemInstruction ??= systemInstruction;
            request.Contents ??= [];
            foreach (var content in contents)
            {
                request.Contents.Add(content);
            }
        }

        ApplyOptions(request, options);
        return (modelId, request);
    }

    private static Content ToGeminiContent(Meai.ChatMessage message, Dictionary<string, string>? functionNamesByCallId = null)
    {
        var role = message.Role == Meai.ChatRole.Assistant ? "model" : "user";
        var parts = new List<Part>();

        foreach (var item in message.Contents)
        {
            switch (item)
            {
                case Meai.TextContent textContent:
                    parts.Add(new Part { Text = textContent.Text });
                    break;

                case Meai.FunctionCallContent functionCall:
                    var fcPart = new Part
                    {
                        FunctionCall = new FunctionCall
                        {
                            Id = functionCall.CallId,
                            Name = functionCall.Name,
                            Args = functionCall.Arguments is { } args
                                ? JsonSerializer.SerializeToElement(args)
                                : null,
                        },
                    };
                    if (functionCall.AdditionalProperties?.TryGetValue(ThoughtSignatureKey, out var sigObj) == true &&
                        sigObj is byte[] thoughtSig)
                    {
                        fcPart.ThoughtSignature = thoughtSig;
                    }
                    parts.Add(fcPart);
                    break;

                case Meai.FunctionResultContent functionResult:
                    var functionName = functionResult.CallId is not null &&
                                      functionNamesByCallId?.TryGetValue(functionResult.CallId, out var name) == true
                        ? name
                        : string.Empty;
                    parts.Add(new Part
                    {
                        FunctionResponse = new FunctionResponse
                        {
                            Id = functionResult.CallId,
                            Name = functionName,
                            Response = ToResponseObject(functionResult),
                        },
                    });
                    break;

                case Meai.DataContent dataContent when dataContent.HasTopLevelMediaType("image"):
                    if (dataContent.Data is { } data)
                    {
                        parts.Add(new Part
                        {
                            InlineData = new Blob
                            {
                                MimeType = dataContent.MediaType ?? "image/png",
                                Data = data.ToArray(),
                            },
                        });
                    }
                    break;

                case Meai.TextReasoningContent:
                case Meai.UsageContent:
                    break;

                default:
                    throw new NotSupportedException(
                        $"Content type '{item.GetType().Name}' is not supported by the Gemini chat adapter.");
            }
        }

        return new Content
        {
            Role = role,
            Parts = parts,
        };
    }

    private static void ApplyOptions(GenerateContentRequest request, Meai.ChatOptions? options)
    {
        if (options is null)
        {
            return;
        }

        if (options.Temperature is not null || options.TopP is not null || options.TopK is not null ||
            options.Seed is not null || options.MaxOutputTokens is not null || options.StopSequences is { Count: > 0 } ||
            options.ResponseFormat is not null)
        {
            request.GenerationConfig ??= new GenerationConfig();
            request.GenerationConfig.Temperature ??= options.Temperature;
            request.GenerationConfig.TopP ??= options.TopP;
            request.GenerationConfig.TopK ??= options.TopK;
            request.GenerationConfig.Seed ??= ToInt32(options.Seed);
            request.GenerationConfig.MaxOutputTokens ??= options.MaxOutputTokens;

            if (request.GenerationConfig.StopSequences is null && options.StopSequences is { Count: > 0 })
            {
                request.GenerationConfig.StopSequences = options.StopSequences.ToList();
            }

            if (request.GenerationConfig.ResponseJsonSchema is null && options.ResponseFormat is Meai.ChatResponseFormatJson jsonFormat)
            {
                request.GenerationConfig.ResponseMimeType ??= "application/json";
                if (jsonFormat.Schema is JsonElement schema &&
                    schema.ValueKind is not JsonValueKind.Null and not JsonValueKind.Undefined)
                {
                    request.GenerationConfig.ResponseJsonSchema = schema;
                }
            }
        }

        ApplyTools(request, options);
    }

    private static void ApplyTools(GenerateContentRequest request, Meai.ChatOptions options)
    {
        if (options.ToolMode is Meai.NoneChatToolMode)
        {
            request.ToolConfig = new ToolConfig
            {
                FunctionCallingConfig = new FunctionCallingConfig
                {
                    Mode = FunctionCallingConfigMode.None,
                },
            };
            return;
        }

        if (options.Tools is { Count: > 0 } aiTools)
        {
            var declarations = new List<FunctionDeclaration>();
            foreach (var tool in aiTools)
            {
                if (tool is not Meai.AIFunction function)
                {
                    throw new NotSupportedException(
                        $"Tool type '{tool.GetType().Name}' is not supported by Gemini. Only function tools are supported.");
                }

                declarations.Add(new FunctionDeclaration
                {
                    Name = function.Name,
                    Description = function.Description,
                    ParametersJsonSchema = function.JsonSchema.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined
                        ? null
                        : function.JsonSchema,
                });
            }

            request.Tools ??= [];
            request.Tools.Add(new Tool { FunctionDeclarations = declarations });
        }

        if (options.ToolMode is Meai.RequiredChatToolMode requiredToolMode)
        {
            request.ToolConfig = new ToolConfig
            {
                FunctionCallingConfig = new FunctionCallingConfig
                {
                    Mode = FunctionCallingConfigMode.Any,
                    AllowedFunctionNames = !string.IsNullOrWhiteSpace(requiredToolMode.RequiredFunctionName)
                        ? [requiredToolMode.RequiredFunctionName!]
                        : null,
                },
            };
        }
    }

    private static Meai.ChatResponse CreateChatResponse(GenerateContentResponse response, string modelId)
    {
        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;

        var responseMessage = new Meai.ChatMessage
        {
            Role = Meai.ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (candidate is not null)
        {
            AddContents(responseMessage.Contents, candidate);
        }

        var chatResponse = new Meai.ChatResponse(responseMessage)
        {
            ModelId = response.ModelVersion ?? modelId,
            ResponseId = response.ResponseId,
            FinishReason = candidate is not null ? ToFinishReason(candidate.FinishReason) : null,
            Usage = response.UsageMetadata is { } usage ? CreateUsageDetails(usage) : null,
            RawRepresentation = response,
        };

        return chatResponse;
    }

    private static void AddContents(IList<Meai.AIContent> contents, Candidate candidate)
    {
        if (candidate.Content?.Parts is not { Count: > 0 } parts)
        {
            return;
        }

        foreach (var part in parts)
        {
            if (part.Thought == true && part.Text is { } thoughtText)
            {
                contents.Add(new Meai.TextReasoningContent(thoughtText)
                {
                    RawRepresentation = part,
                });
            }
            else if (part.Text is { } text)
            {
                contents.Add(new Meai.TextContent(text)
                {
                    RawRepresentation = part,
                });
            }

            if (part.FunctionCall is { } functionCall)
            {
                var fcc = new Meai.FunctionCallContent(
                    callId: functionCall.Id ?? functionCall.Name ?? string.Empty,
                    name: functionCall.Name ?? string.Empty,
                    arguments: ToArgumentsDictionary(functionCall.Args))
                {
                    RawRepresentation = functionCall,
                };

                if (part.ThoughtSignature is { Length: > 0 } sig)
                {
                    (fcc.AdditionalProperties ??= [])[ThoughtSignatureKey] = sig;
                }

                contents.Add(fcc);
            }
        }
    }

    private static Meai.ChatFinishReason? ToFinishReason(CandidateFinishReason? finishReason) =>
        finishReason switch
        {
            null => null,
            CandidateFinishReason.Stop => Meai.ChatFinishReason.Stop,
            CandidateFinishReason.MaxTokens => Meai.ChatFinishReason.Length,
            CandidateFinishReason.Safety => Meai.ChatFinishReason.ContentFilter,
            CandidateFinishReason.ProhibitedContent => Meai.ChatFinishReason.ContentFilter,
            CandidateFinishReason.Recitation => Meai.ChatFinishReason.ContentFilter,
            _ => new Meai.ChatFinishReason(finishReason.Value.ToValueString()),
        };

    private static Meai.UsageDetails CreateUsageDetails(UsageMetadata usage) =>
        new()
        {
            InputTokenCount = usage.PromptTokenCount,
            OutputTokenCount = usage.CandidatesTokenCount,
            TotalTokenCount = usage.TotalTokenCount,
        };

    private static Dictionary<string, object?>? ToArgumentsDictionary(object? args)
    {
        if (args is null)
        {
            return null;
        }

        if (args is JsonElement jsonElement)
        {
            if (jsonElement.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
            {
                return null;
            }

            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                foreach (var property in jsonElement.EnumerateObject())
                {
                    dict[property.Name] = property.Value;
                }

                return dict;
            }
        }

        return null;
    }

    private static Dictionary<string, string>? ToResponseObject(Meai.FunctionResultContent functionResult)
    {
        // The Response property is typed as object? and serialized via source-generated STJ.
        // Only types registered in the SourceGenerationContext can be serialized polymorphically.
        // Dictionary<string, string> and Dictionary<string, object> are both registered.
        if (functionResult.Result is JsonElement jsonElement)
        {
            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, string>(StringComparer.Ordinal);
                foreach (var property in jsonElement.EnumerateObject())
                {
                    dict[property.Name] = property.Value.ToString();
                }
                return dict;
            }

            return new Dictionary<string, string> { ["result"] = jsonElement.ToString() };
        }

        if (functionResult.Result is string text)
        {
            return new Dictionary<string, string> { ["result"] = text };
        }

        if (functionResult.Result is not null)
        {
            return new Dictionary<string, string> { ["result"] = functionResult.Result.ToString() ?? string.Empty };
        }

        if (functionResult.Exception is not null)
        {
            return new Dictionary<string, string> { ["error"] = functionResult.Exception.Message };
        }

        return new Dictionary<string, string> { ["result"] = string.Empty };
    }

    private static int? ToInt32(long? value)
    {
        if (value is null)
        {
            return null;
        }

        if (value < int.MinValue || value > int.MaxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "The value must fit into a 32-bit integer.");
        }

        return (int)value.Value;
    }
}
