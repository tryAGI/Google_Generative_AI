
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
    /// </summary>
    public enum FunctionResponsePartMediaProcessing
    {
        /// <summary>
        /// Model-driven dynamic navigation. Recommended for most use cases.
        /// </summary>
        Agentic,
        /// <summary>
        /// Defaults to model-specific processing.
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
    public static class FunctionResponsePartMediaProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResponsePartMediaProcessing value)
        {
            return value switch
            {
                FunctionResponsePartMediaProcessing.Agentic => "AGENTIC",
                FunctionResponsePartMediaProcessing.MediaProcessingUnspecified => "MEDIA_PROCESSING_UNSPECIFIED",
                FunctionResponsePartMediaProcessing.Static => "STATIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResponsePartMediaProcessing? ToEnum(string value)
        {
            return value switch
            {
                "AGENTIC" => FunctionResponsePartMediaProcessing.Agentic,
                "MEDIA_PROCESSING_UNSPECIFIED" => FunctionResponsePartMediaProcessing.MediaProcessingUnspecified,
                "STATIC" => FunctionResponsePartMediaProcessing.Static,
                _ => null,
            };
        }
    }
}