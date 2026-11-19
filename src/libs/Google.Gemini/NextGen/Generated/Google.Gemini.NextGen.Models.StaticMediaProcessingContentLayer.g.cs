
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum StaticMediaProcessingContentLayer
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Frames,
        /// <summary>
        ///
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StaticMediaProcessingContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StaticMediaProcessingContentLayer value)
        {
            return value switch
            {
                StaticMediaProcessingContentLayer.Audio => "audio",
                StaticMediaProcessingContentLayer.Frames => "frames",
                StaticMediaProcessingContentLayer.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StaticMediaProcessingContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "audio" => StaticMediaProcessingContentLayer.Audio,
                "frames" => StaticMediaProcessingContentLayer.Frames,
                "transcript" => StaticMediaProcessingContentLayer.Transcript,
                _ => null,
            };
        }
    }
}