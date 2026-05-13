
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The MIME type of the audio output.
    /// </summary>
    public enum AudioResponseFormatMimeType
    {
        /// <summary>
        /// A-law audio format.
        /// </summary>
        AudioAlaw,
        /// <summary>
        /// Raw PCM (L16) audio format.
        /// </summary>
        AudioL16,
        /// <summary>
        /// MP3 audio format.
        /// </summary>
        AudioMp3,
        /// <summary>
        /// Mu-law audio format.
        /// </summary>
        AudioMulaw,
        /// <summary>
        /// OGG Opus audio format.
        /// </summary>
        AudioOggOpus,
        /// <summary>
        /// WAV audio format.
        /// </summary>
        AudioWav,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        MimeTypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioResponseFormatMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseFormatMimeType value)
        {
            return value switch
            {
                AudioResponseFormatMimeType.AudioAlaw => "AUDIO_ALAW",
                AudioResponseFormatMimeType.AudioL16 => "AUDIO_L16",
                AudioResponseFormatMimeType.AudioMp3 => "AUDIO_MP3",
                AudioResponseFormatMimeType.AudioMulaw => "AUDIO_MULAW",
                AudioResponseFormatMimeType.AudioOggOpus => "AUDIO_OGG_OPUS",
                AudioResponseFormatMimeType.AudioWav => "AUDIO_WAV",
                AudioResponseFormatMimeType.MimeTypeUnspecified => "MIME_TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponseFormatMimeType? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO_ALAW" => AudioResponseFormatMimeType.AudioAlaw,
                "AUDIO_L16" => AudioResponseFormatMimeType.AudioL16,
                "AUDIO_MP3" => AudioResponseFormatMimeType.AudioMp3,
                "AUDIO_MULAW" => AudioResponseFormatMimeType.AudioMulaw,
                "AUDIO_OGG_OPUS" => AudioResponseFormatMimeType.AudioOggOpus,
                "AUDIO_WAV" => AudioResponseFormatMimeType.AudioWav,
                "MIME_TYPE_UNSPECIFIED" => AudioResponseFormatMimeType.MimeTypeUnspecified,
                _ => null,
            };
        }
    }
}