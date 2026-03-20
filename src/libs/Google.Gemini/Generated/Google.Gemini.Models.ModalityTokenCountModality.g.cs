
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The modality associated with this token count.
    /// </summary>
    public enum ModalityTokenCountModality
    {
        /// <summary>
        /// Unspecified modality.
        /// </summary>
        ModalityUnspecified,
        /// <summary>
        /// Plain text.
        /// </summary>
        Text,
        /// <summary>
        /// Image.
        /// </summary>
        Image,
        /// <summary>
        /// Video.
        /// </summary>
        Video,
        /// <summary>
        /// Audio.
        /// </summary>
        Audio,
        /// <summary>
        /// Document, e.g. PDF.
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModalityTokenCountModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModalityTokenCountModality value)
        {
            return value switch
            {
                ModalityTokenCountModality.ModalityUnspecified => "MODALITY_UNSPECIFIED",
                ModalityTokenCountModality.Text => "TEXT",
                ModalityTokenCountModality.Image => "IMAGE",
                ModalityTokenCountModality.Video => "VIDEO",
                ModalityTokenCountModality.Audio => "AUDIO",
                ModalityTokenCountModality.Document => "DOCUMENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModalityTokenCountModality? ToEnum(string value)
        {
            return value switch
            {
                "MODALITY_UNSPECIFIED" => ModalityTokenCountModality.ModalityUnspecified,
                "TEXT" => ModalityTokenCountModality.Text,
                "IMAGE" => ModalityTokenCountModality.Image,
                "VIDEO" => ModalityTokenCountModality.Video,
                "AUDIO" => ModalityTokenCountModality.Audio,
                "DOCUMENT" => ModalityTokenCountModality.Document,
                _ => null,
            };
        }
    }
}