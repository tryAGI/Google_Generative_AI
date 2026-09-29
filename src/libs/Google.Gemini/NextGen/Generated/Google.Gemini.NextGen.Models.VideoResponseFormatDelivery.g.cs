
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The delivery mode for the video output.
    /// </summary>
    public enum VideoResponseFormatDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
        /// <summary>
        ///
        /// </summary>
        Uri,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseFormatDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseFormatDelivery value)
        {
            return value switch
            {
                VideoResponseFormatDelivery.Inline => "inline",
                VideoResponseFormatDelivery.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseFormatDelivery? ToEnum(string value)
        {
            return value switch
            {
                "inline" => VideoResponseFormatDelivery.Inline,
                "uri" => VideoResponseFormatDelivery.Uri,
                _ => null,
            };
        }
    }
}