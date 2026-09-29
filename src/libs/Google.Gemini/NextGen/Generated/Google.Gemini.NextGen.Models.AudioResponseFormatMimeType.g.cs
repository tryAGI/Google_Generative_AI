
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The MIME type of the audio output.
    /// </summary>
    public enum AudioResponseFormatMimeType
    {
        /// <summary>
        ///
        /// </summary>
        AudioAlaw,
        /// <summary>
        ///
        /// </summary>
        AudioL16,
        /// <summary>
        ///
        /// </summary>
        AudioMp3,
        /// <summary>
        ///
        /// </summary>
        AudioMulaw,
        /// <summary>
        ///
        /// </summary>
        AudioOggOpus,
        /// <summary>
        ///
        /// </summary>
        AudioWav,
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
                AudioResponseFormatMimeType.AudioAlaw => "audio/alaw",
                AudioResponseFormatMimeType.AudioL16 => "audio/l16",
                AudioResponseFormatMimeType.AudioMp3 => "audio/mp3",
                AudioResponseFormatMimeType.AudioMulaw => "audio/mulaw",
                AudioResponseFormatMimeType.AudioOggOpus => "audio/ogg_opus",
                AudioResponseFormatMimeType.AudioWav => "audio/wav",
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
                "audio/alaw" => AudioResponseFormatMimeType.AudioAlaw,
                "audio/l16" => AudioResponseFormatMimeType.AudioL16,
                "audio/mp3" => AudioResponseFormatMimeType.AudioMp3,
                "audio/mulaw" => AudioResponseFormatMimeType.AudioMulaw,
                "audio/ogg_opus" => AudioResponseFormatMimeType.AudioOggOpus,
                "audio/wav" => AudioResponseFormatMimeType.AudioWav,
                _ => null,
            };
        }
    }
}