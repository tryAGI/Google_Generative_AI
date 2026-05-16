using System.Runtime.CompilerServices;
using Meai = Microsoft.Extensions.AI;

namespace Google.Gemini;

public partial class GeminiClient : Meai.ISpeechToTextClient
{
    private const string DefaultSpeechToTextModelId = "gemini-flash-latest";

    private Meai.SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? Meai.ISpeechToTextClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.SpeechToTextClientMetadata) ? (_speechMetadata ??= new(nameof(GeminiClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    /// <inheritdoc />
    async Task<Meai.SpeechToTextResponse> Meai.ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        var (audioData, sniffedMimeType) = await ReadAudioAsync(audioSpeechStream, cancellationToken).ConfigureAwait(false);
        var resolvedMimeType =
            options?.RawRepresentationFactory?.Invoke(this) is string explicitMimeType && explicitMimeType.Length > 0
                ? explicitMimeType
                : sniffedMimeType;
        var modelId = options?.ModelId is { Length: > 0 } optionsModelId ? optionsModelId : DefaultSpeechToTextModelId;

        var prompt = BuildTranscriptionPrompt(options);

        var transcription = await this.TranscribeAsync(
            audioData: audioData,
            mimeType: resolvedMimeType,
            modelId: modelId,
            prompt: prompt,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return new Meai.SpeechToTextResponse(transcription)
        {
            ModelId = modelId,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<Meai.SpeechToTextResponseUpdate> Meai.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((Meai.ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }

    private static async Task<(byte[] Data, string MimeType)> ReadAudioAsync(
        Stream audioSpeechStream,
        CancellationToken cancellationToken)
    {
        if (audioSpeechStream is MemoryStream existing && existing.Position == 0)
        {
            return (existing.ToArray(), GuessMimeType(existing));
        }

        using var buffer = new MemoryStream();
        await audioSpeechStream.CopyToAsync(buffer, 81920, cancellationToken).ConfigureAwait(false);
        return (buffer.ToArray(), GuessMimeType(buffer));
    }

    // Best-effort sniff for the common formats Gemini accepts. Callers should
    // set SpeechToTextOptions.MediaType for non-WAV/MP3 content.
    private static string GuessMimeType(MemoryStream stream)
    {
        if (stream.Length < 4)
        {
            return "audio/wav";
        }

        var header = stream.GetBuffer();
        // RIFF....WAVE
        if (header[0] == 'R' && header[1] == 'I' && header[2] == 'F' && header[3] == 'F')
        {
            return "audio/wav";
        }

        // OggS
        if (header[0] == 'O' && header[1] == 'g' && header[2] == 'g' && header[3] == 'S')
        {
            return "audio/ogg";
        }

        // fLaC
        if (header[0] == 'f' && header[1] == 'L' && header[2] == 'a' && header[3] == 'C')
        {
            return "audio/flac";
        }

        // ID3 (mp3 with tag) or MPEG sync (0xFF 0xFB / 0xFF 0xF3 / 0xFF 0xF2)
        if ((header[0] == 'I' && header[1] == 'D' && header[2] == '3') ||
            (header[0] == 0xFF && (header[1] & 0xE0) == 0xE0))
        {
            return "audio/mp3";
        }

        return "audio/wav";
    }

    private static string BuildTranscriptionPrompt(Meai.SpeechToTextOptions? options)
    {
        var baseInstruction = "Transcribe this audio accurately.";
        if (options?.SpeechLanguage is { Length: > 0 } language)
        {
            return $"{baseInstruction} Language: {language}.";
        }

        return baseInstruction;
    }
}
