namespace Google.Gemini;

/// <summary>
/// Extension methods for music generation using the Gemini API (Lyria models).
/// </summary>
public static class GeminiClientMusicExtensions
{
    /// <summary>
    /// Generates music from a text prompt using a Lyria model.
    /// Supports genre, mood, instrument, tempo, key/scale control, and structure tags
    /// like [Verse], [Chorus], [Bridge], [Intro], [Outro]. Can include lyrics for vocal generation.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired music (genre, mood, instruments, tempo, lyrics, etc.).</param>
    /// <param name="modelId">The model to use. Defaults to "lyria-3-clip-preview" (~30s clips). Use "lyria-3-pro-preview" for longer output.</param>
    /// <param name="responseMimeType">Optional MIME type for the audio output (e.g., "audio/mp3", "audio/wav"). If null, the model chooses the default format.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated music result.</returns>
    public static async Task<MusicResult> GenerateMusicAsync(
        this GeminiClient client,
        string prompt,
        string modelId = "lyria-3-clip-preview",
        string? responseMimeType = null,
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
                    GenerationConfigResponseModalitie.Audio,
                    GenerationConfigResponseModalitie.Text,
                ],
                ResponseMimeType = responseMimeType,
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseMusicResult(response, modelId);
    }

    /// <summary>
    /// Generates music from a text prompt and reference images that influence mood/style.
    /// Up to 10 images can be provided to condition the generated music.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="prompt">The text prompt describing the desired music.</param>
    /// <param name="images">Reference images as (bytes, mimeType) tuples that influence the music's mood/style.</param>
    /// <param name="modelId">The model to use. Defaults to "lyria-3-clip-preview".</param>
    /// <param name="responseMimeType">Optional MIME type for the audio output (e.g., "audio/mp3", "audio/wav"). If null, the model chooses the default format.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated music result.</returns>
    public static async Task<MusicResult> GenerateMusicFromImagesAsync(
        this GeminiClient client,
        string prompt,
        IEnumerable<(byte[] Data, string MimeType)> images,
        string modelId = "lyria-3-clip-preview",
        string? responseMimeType = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);
        ArgumentNullException.ThrowIfNull(images);

        var parts = new List<Part> { new() { Text = prompt } };

        foreach (var (data, mime) in images)
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
                    GenerationConfigResponseModalitie.Audio,
                    GenerationConfigResponseModalitie.Text,
                ],
                ResponseMimeType = responseMimeType,
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseMusicResult(response, modelId);
    }

    private static MusicResult ParseMusicResult(GenerateContentResponse response, string modelId)
    {
        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        var parts = candidate?.Content?.Parts;

        byte[]? musicData = null;
        string? mimeType = null;
        string? textResponse = null;

        if (parts is not null)
        {
            foreach (var part in parts)
            {
                if (part.InlineData is { Data: not null } blob)
                {
                    musicData = blob.Data;
                    mimeType = blob.MimeType;
                }
                else if (part.Text is { } text)
                {
                    textResponse = text;
                }
            }
        }

        return new MusicResult
        {
            MusicData = musicData,
            MimeType = mimeType,
            TextResponse = textResponse,
            ModelId = response.ModelVersion ?? modelId,
        };
    }
}

/// <summary>
/// Result of a music generation operation.
/// </summary>
public record MusicResult
{
    /// <summary>
    /// The generated music audio bytes.
    /// </summary>
#pragma warning disable CA1819
    public byte[]? MusicData { get; init; }
#pragma warning restore CA1819

    /// <summary>
    /// MIME type of the generated audio (e.g., "audio/mp3", "audio/wav").
    /// </summary>
    public string? MimeType { get; init; }

    /// <summary>
    /// Optional text response from the model (e.g., generated lyrics or structure).
    /// </summary>
    public string? TextResponse { get; init; }

    /// <summary>
    /// The model version used.
    /// </summary>
    public string? ModelId { get; init; }

    /// <summary>
    /// Whether the result contains music audio data.
    /// </summary>
    public bool HasMusic => MusicData is { Length: > 0 };
}
