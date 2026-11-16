
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoMetadataContentLayer
    {
        /// <summary>
        /// Extract audio track.
        /// </summary>
        Audio,
        /// <summary>
        /// Default value.
        /// </summary>
        ContentLayerUnspecified,
        /// <summary>
        /// Extract video frames.
        /// </summary>
        Frames,
        /// <summary>
        /// Extract audio transcript.
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoMetadataContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoMetadataContentLayer value)
        {
            return value switch
            {
                VideoMetadataContentLayer.Audio => "AUDIO",
                VideoMetadataContentLayer.ContentLayerUnspecified => "CONTENT_LAYER_UNSPECIFIED",
                VideoMetadataContentLayer.Frames => "FRAMES",
                VideoMetadataContentLayer.Transcript => "TRANSCRIPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoMetadataContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => VideoMetadataContentLayer.Audio,
                "CONTENT_LAYER_UNSPECIFIED" => VideoMetadataContentLayer.ContentLayerUnspecified,
                "FRAMES" => VideoMetadataContentLayer.Frames,
                "TRANSCRIPT" => VideoMetadataContentLayer.Transcript,
                _ => null,
            };
        }
    }
}