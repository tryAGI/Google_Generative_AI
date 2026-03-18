namespace Google.Gemini;

/// <summary>
/// Extension methods for audio generation (TTS) and transcription using the Gemini API.
/// </summary>
public static class GeminiClientAudioExtensions
{
    /// <summary>
    /// Generates speech audio from text (Text-to-Speech).
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="text">The text to convert to speech.</param>
    /// <param name="voiceName">Voice name (e.g., "Puck", "Charon", "Kore", "Fenrir", "Aoede"). Defaults to "Puck".</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash-preview-tts".</param>
    /// <param name="languageCode">Optional BCP-47 language code (e.g., "en-US", "de-DE").</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated audio result.</returns>
    public static async Task<AudioResult> SpeakAsync(
        this GeminiClient client,
        string text,
        string voiceName = "Puck",
        string modelId = "gemini-2.5-flash-preview-tts",
        string? languageCode = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var speechConfig = new SpeechConfig
        {
            VoiceConfig = new VoiceConfig
            {
                PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                {
                    VoiceName = voiceName,
                },
            },
            LanguageCode = languageCode,
        };

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content
                {
                    Parts = [new Part { Text = text }],
                },
            ],
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities =
                [
                    GenerationConfigResponseModalitie.Audio,
                ],
                SpeechConfig = speechConfig,
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ParseAudioResult(response, modelId);
    }

    /// <summary>
    /// Transcribes audio data to text.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="audioData">The audio bytes to transcribe.</param>
    /// <param name="mimeType">MIME type of the audio (e.g., "audio/wav", "audio/mp3", "audio/flac").</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash".</param>
    /// <param name="prompt">Optional prompt to guide transcription (e.g., "Transcribe this audio in English").</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The transcription text.</returns>
    public static async Task<string> TranscribeAsync(
        this GeminiClient client,
        byte[] audioData,
        string mimeType,
        string modelId = "gemini-2.5-flash",
        string? prompt = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(audioData);
        ArgumentException.ThrowIfNullOrWhiteSpace(mimeType);

        var parts = new List<Part>
        {
            new()
            {
                InlineData = new Blob
                {
                    MimeType = mimeType,
                    Data = audioData,
                },
            },
            new()
            {
                Text = prompt ?? "Transcribe this audio accurately.",
            },
        };

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content { Parts = parts },
            ],
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        return candidate?.Content?.Parts?.FirstOrDefault(p => p.Text is not null)?.Text ?? string.Empty;
    }

    private static AudioResult ParseAudioResult(GenerateContentResponse response, string modelId)
    {
        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        var parts = candidate?.Content?.Parts;

        byte[]? audioData = null;
        string? mimeType = null;
        string? textResponse = null;

        if (parts is not null)
        {
            foreach (var part in parts)
            {
                if (part.InlineData is { Data: not null } blob)
                {
                    audioData = blob.Data;
                    mimeType = blob.MimeType;
                }
                else if (part.Text is { } text)
                {
                    textResponse = text;
                }
            }
        }

        return new AudioResult
        {
            AudioData = audioData,
            MimeType = mimeType,
            TextResponse = textResponse,
            ModelId = response.ModelVersion ?? modelId,
        };
    }
}

/// <summary>
/// Result of an audio generation (TTS) operation.
/// </summary>
public record AudioResult
{
    /// <summary>
    /// The generated audio bytes.
    /// </summary>
#pragma warning disable CA1819
    public byte[]? AudioData { get; init; }
#pragma warning restore CA1819

    /// <summary>
    /// MIME type of the generated audio.
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
    /// Whether the result contains audio data.
    /// </summary>
    public bool HasAudio => AudioData is { Length: > 0 };
}
