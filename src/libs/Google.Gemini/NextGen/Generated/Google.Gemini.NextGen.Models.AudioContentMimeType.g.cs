
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mime type of the audio.
    /// </summary>
    public enum AudioContentMimeType
    {
        /// <summary>
        ///
        /// </summary>
        AudioAac,
        /// <summary>
        ///
        /// </summary>
        AudioAiff,
        /// <summary>
        ///
        /// </summary>
        AudioAlaw,
        /// <summary>
        ///
        /// </summary>
        AudioFlac,
        /// <summary>
        ///
        /// </summary>
        AudioL16,
        /// <summary>
        ///
        /// </summary>
        AudioM4a,
        /// <summary>
        ///
        /// </summary>
        AudioMp3,
        /// <summary>
        ///
        /// </summary>
        AudioMpeg,
        /// <summary>
        ///
        /// </summary>
        AudioMulaw,
        /// <summary>
        ///
        /// </summary>
        AudioOgg,
        /// <summary>
        ///
        /// </summary>
        AudioOpus,
        /// <summary>
        ///
        /// </summary>
        AudioWav,
        /// <summary>
        ///
        /// </summary>
        AudioWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioContentMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioContentMimeType value)
        {
            return value switch
            {
                AudioContentMimeType.AudioAac => "audio/aac",
                AudioContentMimeType.AudioAiff => "audio/aiff",
                AudioContentMimeType.AudioAlaw => "audio/alaw",
                AudioContentMimeType.AudioFlac => "audio/flac",
                AudioContentMimeType.AudioL16 => "audio/l16",
                AudioContentMimeType.AudioM4a => "audio/m4a",
                AudioContentMimeType.AudioMp3 => "audio/mp3",
                AudioContentMimeType.AudioMpeg => "audio/mpeg",
                AudioContentMimeType.AudioMulaw => "audio/mulaw",
                AudioContentMimeType.AudioOgg => "audio/ogg",
                AudioContentMimeType.AudioOpus => "audio/opus",
                AudioContentMimeType.AudioWav => "audio/wav",
                AudioContentMimeType.AudioWebm => "audio/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioContentMimeType? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => AudioContentMimeType.AudioAac,
                "audio/aiff" => AudioContentMimeType.AudioAiff,
                "audio/alaw" => AudioContentMimeType.AudioAlaw,
                "audio/flac" => AudioContentMimeType.AudioFlac,
                "audio/l16" => AudioContentMimeType.AudioL16,
                "audio/m4a" => AudioContentMimeType.AudioM4a,
                "audio/mp3" => AudioContentMimeType.AudioMp3,
                "audio/mpeg" => AudioContentMimeType.AudioMpeg,
                "audio/mulaw" => AudioContentMimeType.AudioMulaw,
                "audio/ogg" => AudioContentMimeType.AudioOgg,
                "audio/opus" => AudioContentMimeType.AudioOpus,
                "audio/wav" => AudioContentMimeType.AudioWav,
                "audio/webm" => AudioContentMimeType.AudioWebm,
                _ => null,
            };
        }
    }
}