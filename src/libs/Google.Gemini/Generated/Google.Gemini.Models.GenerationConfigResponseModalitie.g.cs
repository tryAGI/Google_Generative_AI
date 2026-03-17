
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationConfigResponseModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        ModalityUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationConfigResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationConfigResponseModalitie value)
        {
            return value switch
            {
                GenerationConfigResponseModalitie.ModalityUnspecified => "MODALITY_UNSPECIFIED",
                GenerationConfigResponseModalitie.Text => "TEXT",
                GenerationConfigResponseModalitie.Image => "IMAGE",
                GenerationConfigResponseModalitie.Audio => "AUDIO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationConfigResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "MODALITY_UNSPECIFIED" => GenerationConfigResponseModalitie.ModalityUnspecified,
                "TEXT" => GenerationConfigResponseModalitie.Text,
                "IMAGE" => GenerationConfigResponseModalitie.Image,
                "AUDIO" => GenerationConfigResponseModalitie.Audio,
                _ => null,
            };
        }
    }
}