
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The delivery mode for the image output.
    /// </summary>
    public enum ImageResponseFormatDelivery
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
    public static class ImageResponseFormatDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseFormatDelivery value)
        {
            return value switch
            {
                ImageResponseFormatDelivery.Inline => "inline",
                ImageResponseFormatDelivery.Uri => "uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseFormatDelivery? ToEnum(string value)
        {
            return value switch
            {
                "inline" => ImageResponseFormatDelivery.Inline,
                "uri" => ImageResponseFormatDelivery.Uri,
                _ => null,
            };
        }
    }
}