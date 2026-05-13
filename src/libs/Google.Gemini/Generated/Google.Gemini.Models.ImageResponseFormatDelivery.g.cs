
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The delivery mode for the image output.
    /// </summary>
    public enum ImageResponseFormatDelivery
    {
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        DeliveryUnspecified,
        /// <summary>
        /// Image data is returned inline in the response.
        /// </summary>
        Inline,
        /// <summary>
        /// Image data is returned as a URI.
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
                ImageResponseFormatDelivery.DeliveryUnspecified => "DELIVERY_UNSPECIFIED",
                ImageResponseFormatDelivery.Inline => "INLINE",
                ImageResponseFormatDelivery.Uri => "URI",
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
                "DELIVERY_UNSPECIFIED" => ImageResponseFormatDelivery.DeliveryUnspecified,
                "INLINE" => ImageResponseFormatDelivery.Inline,
                "URI" => ImageResponseFormatDelivery.Uri,
                _ => null,
            };
        }
    }
}