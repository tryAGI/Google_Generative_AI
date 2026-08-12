
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
    /// </summary>
    public enum PartMediaProcessing
    {
        /// <summary>
        /// Model-driven dynamic navigation. Recommended for most use cases.
        /// </summary>
        Agentic,
        /// <summary>
        /// Default. Uses model-specific processing (3.5 Pro+ -&gt; `AGENTIC`, older models -&gt; `STATIC`).
        /// </summary>
        MediaProcessingUnspecified,
        /// <summary>
        /// Fixed-rate frame extraction. All frames placed in context.
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartMediaProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartMediaProcessing value)
        {
            return value switch
            {
                PartMediaProcessing.Agentic => "AGENTIC",
                PartMediaProcessing.MediaProcessingUnspecified => "MEDIA_PROCESSING_UNSPECIFIED",
                PartMediaProcessing.Static => "STATIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartMediaProcessing? ToEnum(string value)
        {
            return value switch
            {
                "AGENTIC" => PartMediaProcessing.Agentic,
                "MEDIA_PROCESSING_UNSPECIFIED" => PartMediaProcessing.MediaProcessingUnspecified,
                "STATIC" => PartMediaProcessing.Static,
                _ => null,
            };
        }
    }
}