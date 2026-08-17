
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Configures transcription mode. Supported values: `VERBATIM`, `SMART`. If unspecified, defaults to `VERBATIM` transcription. In `SMART` mode, the model performs disfluency removal (eliminating filler words, repetitions, and false starts), light grammatical cleanup, automatic formatting (paragraphs, bullet points, numbered lists), and minor user edits (inline self-corrections). Timestamps and diarization are incompatible with mode `SMART`.
    /// </summary>
    public enum AudioTranscriptionConfigMode
    {
        /// <summary>
        /// Unspecified transcription mode.
        /// </summary>
        ModeUnspecified,
        /// <summary>
        /// Smart transcription mode.
        /// </summary>
        Smart,
        /// <summary>
        /// Verbatim transcription mode.
        /// </summary>
        Verbatim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionConfigMode value)
        {
            return value switch
            {
                AudioTranscriptionConfigMode.ModeUnspecified => "MODE_UNSPECIFIED",
                AudioTranscriptionConfigMode.Smart => "SMART",
                AudioTranscriptionConfigMode.Verbatim => "VERBATIM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "MODE_UNSPECIFIED" => AudioTranscriptionConfigMode.ModeUnspecified,
                "SMART" => AudioTranscriptionConfigMode.Smart,
                "VERBATIM" => AudioTranscriptionConfigMode.Verbatim,
                _ => null,
            };
        }
    }
}