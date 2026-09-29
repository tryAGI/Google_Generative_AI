
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioDeltaMimeType
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
    public static class AudioDeltaMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioDeltaMimeType value)
        {
            return value switch
            {
                AudioDeltaMimeType.AudioAac => "audio/aac",
                AudioDeltaMimeType.AudioAiff => "audio/aiff",
                AudioDeltaMimeType.AudioAlaw => "audio/alaw",
                AudioDeltaMimeType.AudioFlac => "audio/flac",
                AudioDeltaMimeType.AudioL16 => "audio/l16",
                AudioDeltaMimeType.AudioM4a => "audio/m4a",
                AudioDeltaMimeType.AudioMp3 => "audio/mp3",
                AudioDeltaMimeType.AudioMpeg => "audio/mpeg",
                AudioDeltaMimeType.AudioMulaw => "audio/mulaw",
                AudioDeltaMimeType.AudioOgg => "audio/ogg",
                AudioDeltaMimeType.AudioOpus => "audio/opus",
                AudioDeltaMimeType.AudioWav => "audio/wav",
                AudioDeltaMimeType.AudioWebm => "audio/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioDeltaMimeType? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => AudioDeltaMimeType.AudioAac,
                "audio/aiff" => AudioDeltaMimeType.AudioAiff,
                "audio/alaw" => AudioDeltaMimeType.AudioAlaw,
                "audio/flac" => AudioDeltaMimeType.AudioFlac,
                "audio/l16" => AudioDeltaMimeType.AudioL16,
                "audio/m4a" => AudioDeltaMimeType.AudioM4a,
                "audio/mp3" => AudioDeltaMimeType.AudioMp3,
                "audio/mpeg" => AudioDeltaMimeType.AudioMpeg,
                "audio/mulaw" => AudioDeltaMimeType.AudioMulaw,
                "audio/ogg" => AudioDeltaMimeType.AudioOgg,
                "audio/opus" => AudioDeltaMimeType.AudioOpus,
                "audio/wav" => AudioDeltaMimeType.AudioWav,
                "audio/webm" => AudioDeltaMimeType.AudioWebm,
                _ => null,
            };
        }
    }
}