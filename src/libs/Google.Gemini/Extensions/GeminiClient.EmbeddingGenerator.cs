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

        EmbedContentRequestTaskType? taskType = null;
        string? title = null;
        if (options?.AdditionalProperties is { Count: > 0 } additionalProps)
        {
            if (additionalProps.TryGetValue("TaskType", out var taskTypeVal))
            {
                taskType = taskTypeVal switch
                {
                    EmbedContentRequestTaskType enumVal => enumVal,
                    string str => EmbedContentRequestTaskTypeExtensions.ToEnum(str),
                    _ => null,
                };
            }

            if (additionalProps.TryGetValue("Title", out var titleVal) && titleVal is string titleStr)
            {
                title = titleStr;
            }
        }

        var requests = values
            .Select(text => new EmbedContentRequest
            {
                Model = $"models/{modelId}",
                Content = new Content
                {
                    Parts = [new Part { Text = text }],
                },
                OutputDimensionality = options?.Dimensions,
                TaskType = taskType,
                Title = title,
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
