
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseModality
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Document,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseModality value)
        {
            return value switch
            {
                ResponseModality.Audio => "audio",
                ResponseModality.Document => "document",
                ResponseModality.Image => "image",
                ResponseModality.Text => "text",
                ResponseModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ResponseModality.Audio,
                "document" => ResponseModality.Document,
                "image" => ResponseModality.Image,
                "text" => ResponseModality.Text,
                "video" => ResponseModality.Video,
                _ => null,
            };
        }
    }
}