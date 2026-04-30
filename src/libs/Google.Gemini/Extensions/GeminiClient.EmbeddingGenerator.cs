using Meai = Microsoft.Extensions.AI;

namespace Google.Gemini;

public partial class GeminiClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    private Meai.EmbeddingGeneratorMetadata? _embeddingMetadata;

    object? Meai.IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(GeminiClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>> Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        Meai.EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var modelId = options?.ModelId ?? "gemini-embedding-001";

        EmbedContentConfigTaskType? taskType = null;
        string? title = null;
        if (options?.AdditionalProperties is { Count: > 0 } additionalProps)
        {
            if (additionalProps.TryGetValue("TaskType", out var taskTypeVal))
            {
                taskType = taskTypeVal switch
                {
                    EmbedContentConfigTaskType enumVal => enumVal,
                    EmbedContentRequestTaskType requestEnumVal => EmbedContentConfigTaskTypeExtensions.ToEnum(
                        requestEnumVal.ToValueString()),
                    string str => EmbedContentConfigTaskTypeExtensions.ToEnum(str),
                    _ => null,
                };
            }

            if (additionalProps.TryGetValue("Title", out var titleVal) && titleVal is string titleStr)
            {
                title = titleStr;
            }
        }

        var embedContentConfig =
            options?.Dimensions is not null || taskType is not null || title is not null
                ? new EmbedContentConfig
                {
                    OutputDimensionality = options?.Dimensions,
                    TaskType = taskType,
                    Title = title,
                }
                : null;

        var requests = values
            .Select(text => new EmbedContentRequest
            {
                EmbedContentConfig = embedContentConfig,
                Model = $"models/{modelId}",
                Content = new Content
                {
                    Parts = [new Part { Text = text }],
                },
            })
            .ToList();

        var response = await ModelsBatchEmbedContentsAsync(
            modelsId: modelId,
            requests: requests,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>();

        if (response.Embeddings is { } embeddingsList)
        {
            foreach (var embedding in embeddingsList)
            {
                var vector = embedding.Values?.ToArray() ?? [];
                embeddings.Add(new Meai.Embedding<float>(vector)
                {
                    ModelId = modelId,
                });
            }
        }

        return embeddings;
    }
}
