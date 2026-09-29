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
    /// <param name="voiceName">Prebuilt voice name, stored voice ID, or stateless voice key. Defaults to "Puck".</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-3.8-flash-lite-tts".</param>
    /// <param name="languageCode">Optional BCP-47 language code (e.g., "en-US", "de-DE").</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated audio result.</returns>
    public static async Task<AudioResult> SpeakAsync(
        this GeminiClient client,
        string text,
        string voiceName = "Puck",
        string modelId = "gemini-3.8-flash-lite-tts",
        string? languageCode = null,
        CancellationToken cancellationToken = default)
        => await client.SpeakAdvancedAsync(
            text, voiceName, modelId, languageCode, style: null, audioFormat: null, cancellationToken)
            .ConfigureAwait(false);

    /// <summary>Generates speech with explicit voice, style, and audio format options.</summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="text">The verbatim transcript.</param>
    /// <param name="voiceName">Prebuilt voice name, stored voice ID, or stateless voice key.</param>
    /// <param name="modelId">The TTS model.</param>
    /// <param name="languageCode">Optional BCP-47 language code.</param>
    /// <param name="style">Optional turn-level delivery instruction for Gemini 3.8 TTS.</param>
    /// <param name="audioFormat">Optional audio output format. Gemini 3.8 TTS defaults to WAV.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The generated audio result.</returns>
    public static async Task<AudioResult> SpeakAdvancedAsync(
        this GeminiClient client,
        string text,
        string voiceName = "Puck",
        string modelId = "gemini-3.8-flash-lite-tts",
        string? languageCode = null,
        string? style = null,
        AudioResponseFormatMimeType? audioFormat = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(text);
        ArgumentException.ThrowIfNullOrWhiteSpace(voiceName);
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        var speechConfig = new SpeechConfig
        {
            VoiceConfig = modelId.EndsWith("gemini-3.1-flash-tts-preview", StringComparison.Ordinal) ||
                          modelId.EndsWith("gemini-2.5-pro-preview-tts", StringComparison.Ordinal)
                ? new VoiceConfig { PrebuiltVoiceConfig = new PrebuiltVoiceConfig { VoiceName = voiceName } }
                : new VoiceConfig { Voice = voiceName },
            LanguageCode = languageCode,
        };

        var request = new GenerateContentRequest
        {
            Contents =
            [
                new Content
                {
                    Parts = [new Part
                    {
                        Text = text,
                        SpeechMetadata = style is null ? null : new SpeechMetadata { Style = style },
                    }],
                },
            ],
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities =
                [
                    GenerationConfigResponseModalitie.Audio,
                ],
                SpeechConfig = speechConfig,
                ResponseFormat = audioFormat is null ? null : new ResponseFormatConfig
                {
                    Audio = new AudioResponseFormat { MimeType = audioFormat },
                },
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

    /// <summary>
    /// Transcribes an uploaded audio file with Gemini 3.5 Transcribe. Returns the
    /// complete response so callers can inspect timestamps and speaker metadata.
    /// </summary>
    public static Task<GenerateContentResponse> Transcribe35FileAsync(
        this GeminiClient client,
        Uri fileUri,
        string mimeType,
        AudioTranscriptionConfig? transcriptionConfig = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(fileUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(mimeType);
        return Transcribe35PartAsync(client, new Part
        {
            FileData = new FileData { FileUri = fileUri.ToString(), MimeType = mimeType },
        }, transcriptionConfig, cancellationToken);
    }

    /// <summary>
    /// Transcribes short inline audio with Gemini 3.5 Transcribe. Use
    /// <see cref="Transcribe35FileAsync"/> for uploaded long recordings.
    /// </summary>
    public static Task<GenerateContentResponse> Transcribe35Async(
        this GeminiClient client,
        byte[] audioData,
        string mimeType,
        AudioTranscriptionConfig? transcriptionConfig = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(audioData);
        ArgumentException.ThrowIfNullOrWhiteSpace(mimeType);
        return Transcribe35PartAsync(client, new Part
        {
            InlineData = new Blob { Data = audioData, MimeType = mimeType },
        }, transcriptionConfig, cancellationToken);
    }

    private static Task<GenerateContentResponse> Transcribe35PartAsync(
        GeminiClient client,
        Part audioPart,
        AudioTranscriptionConfig? transcriptionConfig,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);
        return client.ModelsGenerateContentAsync(
            modelsId: "gemini-3.5-transcribe",
            request: new GenerateContentRequest
            {
                Contents = [new Content { Parts = [audioPart] }],
                GenerationConfig = transcriptionConfig is null ? null : new GenerationConfig
                {
                    AudioTranscriptionConfig = transcriptionConfig,
                },
            },
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Transcribes audio data to a structured text response constrained by a Gemini response schema.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="audioData">The audio bytes to transcribe.</param>
    /// <param name="mimeType">MIME type of the audio (e.g., "audio/wav", "audio/mp3", "audio/flac").</param>
    /// <param name="responseSchema">Gemini response schema used to constrain the text output.</param>
    /// <param name="modelId">The model to use. Defaults to "gemini-2.5-flash".</param>
    /// <param name="prompt">Optional prompt to guide transcription.</param>
    /// <param name="responseMimeType">MIME type of the generated text. Defaults to "application/json".</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The structured transcription text.</returns>
    public static async Task<string> TranscribeStructuredAsync(
        this GeminiClient client,
        byte[] audioData,
        string mimeType,
        Schema responseSchema,
        string modelId = "gemini-2.5-flash",
        string? prompt = null,
        string responseMimeType = "application/json",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(audioData);
        ArgumentException.ThrowIfNullOrWhiteSpace(mimeType);
        ArgumentNullException.ThrowIfNull(responseSchema);
        ArgumentException.ThrowIfNullOrWhiteSpace(responseMimeType);

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
            GenerationConfig = new GenerationConfig
            {
                ResponseMimeType = responseMimeType,
                ResponseSchema = responseSchema,
            },
        };

        var response = await client.ModelsGenerateContentAsync(
            modelsId: modelId,
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var candidate = response.Candidates is { Count: > 0 } ? response.Candidates[0] : null;
        return candidate?.Content?.Parts?.FirstOrDefault(p => p.Text is not null)?.Text ?? string.Empty;
    }

    /// <summary>
    /// Returns the TTS-capable models exposed by the Gemini API (filtered by
    /// the <c>-tts</c> suffix in <see cref="Model.Name"/>). Use this to discover
    /// new TTS preview models without hard-coding their IDs in client code.
    /// </summary>
    /// <param name="client">The Gemini client.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public static async Task<IReadOnlyList<Model>> ListTtsModelsAsync(
        this GeminiClient client,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        var response = await client.ModelsListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        var models = response.Models ?? [];

        return models
            .Where(m => m.Name is { } name && name.Contains("-tts", StringComparison.OrdinalIgnoreCase))
            .ToList();
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

    /// <summary>
    /// Sample rate parsed from <see cref="MimeType"/> when the server returns
    /// a parameterized PCM type such as <c>audio/L16;codec=pcm;rate=24000</c>.
    /// Returns <c>null</c> when no rate parameter is present (e.g., for
    /// container formats like <c>audio/wav</c> or <c>audio/mp3</c>).
    /// </summary>
    public int? SampleRateHz => ParseSampleRateHz(MimeType);

    /// <summary>
    /// Extracts the <c>rate=</c> parameter from a Gemini TTS MIME type.
    /// Returns <c>null</c> when the input is null/empty or contains no rate parameter.
    /// </summary>
    public static int? ParseSampleRateHz(string? mimeType)
    {
        if (string.IsNullOrEmpty(mimeType))
        {
            return null;
        }

        var rateIndex = mimeType.IndexOf("rate=", StringComparison.OrdinalIgnoreCase);
        if (rateIndex < 0)
        {
            return null;
        }

        var rateValue = mimeType.AsSpan(rateIndex + "rate=".Length);
        var end = rateValue.IndexOf(';');
        if (end >= 0)
        {
            rateValue = rateValue[..end];
        }

        return int.TryParse(rateValue, out var rate) ? rate : null;
    }

    /// <summary>
    /// Writes WAV output directly, or wraps raw 16-bit PCM in a WAV header.
    /// </summary>
    /// <param name="destination">Target stream. Must be writable. Not closed by this method.</param>
    /// <param name="sampleRate">Sample rate in Hz. Defaults to <see cref="SampleRateHz"/> or 24000.</param>
    /// <param name="channels">Channel count. Defaults to 1 (mono — Gemini TTS is single-channel).</param>
    /// <param name="bitsPerSample">Bit depth. Defaults to 16 (matches Gemini's L16 output).</param>
    public void WriteWavTo(
        Stream destination,
        int? sampleRate = null,
        int channels = 1,
        int bitsPerSample = 16)
    {
        ArgumentNullException.ThrowIfNull(destination);
        if (AudioData is not { Length: > 0 } audio)
        {
            throw new InvalidOperationException("AudioResult contains no audio data.");
        }

        if (MimeType?.StartsWith("audio/wav", StringComparison.OrdinalIgnoreCase) is true)
        {
            destination.Write(audio);
            return;
        }

        if (MimeType is not null &&
            !MimeType.StartsWith("audio/l16", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException($"Cannot write {MimeType} as a WAV file.");
        }

        var effectiveRate = sampleRate ?? SampleRateHz ?? 24000;
        WriteWavHeaderAndBody(destination, audio, effectiveRate, channels, bitsPerSample);
    }

    /// <summary>
    /// Writes <see cref="AudioData"/> as a WAV file at <paramref name="path"/>.
    /// Overwrites the file if it already exists.
    /// </summary>
    public void WriteWavFile(
        string path,
        int? sampleRate = null,
        int channels = 1,
        int bitsPerSample = 16)
    {
        ArgumentException.ThrowIfNullOrEmpty(path);

        using var fs = System.IO.File.Create(path);
        WriteWavTo(fs, sampleRate, channels, bitsPerSample);
    }

    private static void WriteWavHeaderAndBody(
        Stream destination,
        byte[] pcmData,
        int sampleRate,
        int channels,
        int bitsPerSample)
    {
        var byteRate = sampleRate * channels * bitsPerSample / 8;
        var blockAlign = channels * bitsPerSample / 8;

        using var writer = new BinaryWriter(destination, System.Text.Encoding.ASCII, leaveOpen: true);

        writer.Write("RIFF"u8);
        writer.Write(36 + pcmData.Length);
        writer.Write("WAVE"u8);

        writer.Write("fmt "u8);
        writer.Write(16);
        writer.Write((short)1);
        writer.Write((short)channels);
        writer.Write(sampleRate);
        writer.Write(byteRate);
        writer.Write((short)blockAlign);
        writer.Write((short)bitsPerSample);

        writer.Write("data"u8);
        writer.Write(pcmData.Length);
        writer.Write(pcmData);
        writer.Flush();
    }
}
