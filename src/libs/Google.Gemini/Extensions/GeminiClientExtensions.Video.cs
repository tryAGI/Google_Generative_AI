namespace Google.Gemini;

/// <summary>
/// Extension methods for video generation using the Gemini API.
/// </summary>
public static class GeminiClientVideoExtensions
{
    /// <summary>
    /// Generates a video from a text prompt.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired video.</param>
    /// <param name="modelId">The model to use. Defaults to "veo-2.0-generate-001".</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated video result.</returns>
    public static async Task<VideoResult> GenerateVideoAsync(
        this GeminiClient client,
        string prompt,
        string modelId = "veo-2.0-generate-001",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content
                {
                    Parts = [new Part { Text = prompt }],
                },
            ],
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities =
                [
                    GenerationConfigResponseModalitie.Video,
                ],
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseVideoResult(response, modelId);
    }

    /// <summary>
    /// Generates a video from a text prompt and a source image.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired animation.</param>
    /// <param name="imageData">The source image bytes.</param>
    /// <param name="mimeType">MIME type of the source image. Defaults to "image/png".</param>
    /// <param name="modelId">The model to use. Defaults to "veo-2.0-generate-001".</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated video result.</returns>
    public static async Task<VideoResult> GenerateVideoFromImageAsync(
        this GeminiClient client,
        string prompt,
        byte[] imageData,
        string mimeType = "image/png",
        string modelId = "veo-2.0-generate-001",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);
        ArgumentNullException.ThrowIfNull(imageData);

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content
                {
                    Parts =
                    [
                        new Part { Text = prompt },
                        new Part
                        {
                            InlineData = new Blob
                            {
                                MimeType = mimeType,
                                Data = imageData,
                            },
                        },
                    ],
                },
            ],
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities =
                [
                    GenerationConfigResponseModalitie.Video,
                ],
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseVideoResult(response, modelId);
    }

    /// <summary>
    /// Interpolates between two frames to generate a video transition.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="startFrame">The start frame image bytes.</param>
    /// <param name="endFrame">The end frame image bytes.</param>
    /// <param name="prompt">Optional text prompt to guide interpolation.</param>
    /// <param name="mimeType">MIME type of the frame images. Defaults to "image/png".</param>
    /// <param name="modelId">The model to use. Defaults to "veo-2.0-generate-001".</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated video result.</returns>
    public static async Task<VideoResult> InterpolateFramesAsync(
        this GeminiClient client,
        byte[] startFrame,
        byte[] endFrame,
        string? prompt = null,
        string mimeType = "image/png",
        string modelId = "veo-2.0-generate-001",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(startFrame);
        ArgumentNullException.ThrowIfNull(endFrame);

        var parts = new List<Part>();

        if (prompt is not null)
        {
            parts.Add(new Part { Text = prompt });
        }

        parts.Add(new Part
        {
            InlineData = new Blob
            {
                MimeType = mimeType,
                Data = startFrame,
            },
        });

        parts.Add(new Part
        {
            InlineData = new Blob
            {
                MimeType = mimeType,
                Data = endFrame,
            },
        });

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content { Parts = parts },
            ],
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities =
                [
                    GenerationConfigResponseModalitie.Video,
                ],
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseVideoResult(response, modelId);
    }

    private static VideoResult ParseVideoResult(GenerateContentResponse response, string modelId)
    {
        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        var parts = candidate?.Content?.Parts;

        byte[]? videoData = null;
        string? mimeType = null;
        string? textResponse = null;

        if (parts is not null)
        {
            foreach (var part in parts)
            {
                if (part.InlineData is { Data: not null } blob)
                {
                    videoData = blob.Data;
                    mimeType = blob.MimeType;
                }
                else if (part.Text is { } text)
                {
                    textResponse = text;
                }
            }
        }

        return new VideoResult
        {
            VideoData = videoData,
            MimeType = mimeType,
            TextResponse = textResponse,
            ModelId = response.ModelVersion ?? modelId,
        };
    }
}

/// <summary>
/// Result of a video generation operation.
/// </summary>
public record VideoResult
{
    /// <summary>
    /// The generated video bytes.
    /// </summary>
#pragma warning disable CA1819
    public byte[]? VideoData { get; init; }
#pragma warning restore CA1819

    /// <summary>
    /// MIME type of the generated video (typically "video/mp4").
    /// </summary>
    public string? MimeType { get; init; }

    /// <summary>
    /// Optional text response from the model.
    /// </summary>
    public string? TextResponse { get; init; }

    /// <summary>
    /// The model version used.
    /// </summary>
    public string? ModelId { get; init; }

    /// <summary>
    /// Whether the result contains video data.
    /// </summary>
    public bool HasVideo => VideoData is { Length: > 0 };
}
