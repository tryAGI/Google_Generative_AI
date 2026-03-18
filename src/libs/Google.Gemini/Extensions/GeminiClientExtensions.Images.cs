namespace Google.Gemini;

/// <summary>
/// Extension methods for image generation and editing using the Gemini API.
/// </summary>
public static class GeminiClientImageExtensions
{
    /// <summary>
    /// Generates an image from a text prompt.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired image.</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash-image".</param>
    /// <param name="imageSize">Image size: "512", "1K", "2K", "4K". Defaults to "1K".</param>
    /// <param name="aspectRatio">Optional aspect ratio (e.g., "16:9", "1:1", "9:16").</param>
    /// <param name="includeTextResponse">If true, requests both TEXT and IMAGE modalities.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated image result.</returns>
    public static async Task<ImageResult> GenerateImageAsync(
        this GeminiClient client,
        string prompt,
        string modelId = "gemini-2.5-flash-image",
        string imageSize = "1K",
        string? aspectRatio = null,
        bool includeTextResponse = false,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);

        var modalities = includeTextResponse
            ? new List<GenerationConfigResponseModalitie>
            {
                GenerationConfigResponseModalitie.Text,
                GenerationConfigResponseModalitie.Image,
            }
            : new List<GenerationConfigResponseModalitie>
            {
                GenerationConfigResponseModalitie.Image,
            };

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
                ResponseModalities = modalities,
                ImageConfig = new ImageConfig
                {
                    ImageSize = imageSize,
                    AspectRatio = aspectRatio,
                },
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseImageResult(response, modelId);
    }

    /// <summary>
    /// Edits an existing image based on a text prompt.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired edit.</param>
    /// <param name="imageData">The source image bytes.</param>
    /// <param name="mimeType">MIME type of the source image. Defaults to "image/png".</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash-image".</param>
    /// <param name="imageSize">Image size: "512", "1K", "2K", "4K". Defaults to "1K".</param>
    /// <param name="aspectRatio">Optional aspect ratio.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The edited image result.</returns>
    public static async Task<ImageResult> EditImageAsync(
        this GeminiClient client,
        string prompt,
        byte[] imageData,
        string mimeType = "image/png",
        string modelId = "gemini-2.5-flash-image",
        string imageSize = "1K",
        string? aspectRatio = null,
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
                    GenerationConfigResponseModalitie.Image,
                ],
                ImageConfig = new ImageConfig
                {
                    ImageSize = imageSize,
                    AspectRatio = aspectRatio,
                },
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseImageResult(response, modelId);
    }

    /// <summary>
    /// Generates an image using multiple reference images.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired image.</param>
    /// <param name="referenceImages">Reference images as (bytes, mimeType) tuples.</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash-image".</param>
    /// <param name="imageSize">Image size: "512", "1K", "2K", "4K". Defaults to "1K".</param>
    /// <param name="aspectRatio">Optional aspect ratio.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated image result.</returns>
    public static async Task<ImageResult> GenerateImageWithReferencesAsync(
        this GeminiClient client,
        string prompt,
        IEnumerable<(byte[] Data, string MimeType)> referenceImages,
        string modelId = "gemini-2.5-flash-image",
        string imageSize = "1K",
        string? aspectRatio = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);
        ArgumentNullException.ThrowIfNull(referenceImages);

        var parts = new List<Part> { new() { Text = prompt } };

        foreach (var (data, mime) in referenceImages)
        {
            parts.Add(new Part
            {
                InlineData = new Blob
                {
                    MimeType = mime,
                    Data = data,
                },
            });
        }

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
                    GenerationConfigResponseModalitie.Image,
                ],
                ImageConfig = new ImageConfig
                {
                    ImageSize = imageSize,
                    AspectRatio = aspectRatio,
                },
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseImageResult(response, modelId);
    }

    private static ImageResult ParseImageResult(GenerateContentResponse response, string modelId)
    {
        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        var parts = candidate?.Content?.Parts;

        byte[]? imageData = null;
        string? mimeType = null;
        string? textResponse = null;

        if (parts is not null)
        {
            foreach (var part in parts)
            {
                if (part.InlineData is { Data: not null } blob)
                {
                    imageData = blob.Data;
                    mimeType = blob.MimeType;
                }
                else if (part.Text is { } text)
                {
                    textResponse = text;
                }
            }
        }

        return new ImageResult
        {
            ImageData = imageData,
            MimeType = mimeType,
            TextResponse = textResponse,
            ModelId = response.ModelVersion ?? modelId,
        };
    }
}

/// <summary>
/// Result of an image generation or editing operation.
/// </summary>
public record ImageResult
{
    /// <summary>
    /// The generated image bytes.
    /// </summary>
#pragma warning disable CA1819
    public byte[]? ImageData { get; init; }
#pragma warning restore CA1819

    /// <summary>
    /// MIME type of the generated image (e.g., "image/png").
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
    /// Whether the result contains image data.
    /// </summary>
    public bool HasImage => ImageData is { Length: > 0 };
}
