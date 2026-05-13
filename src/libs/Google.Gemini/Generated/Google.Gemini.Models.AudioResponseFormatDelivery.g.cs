
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The delivery mode for the audio output.
    /// </summary>
    public enum AudioResponseFormatDelivery
    {
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        DeliveryUnspecified,
        /// <summary>
        /// Audio data is returned inline in the response.
        /// </summary>
        Inline,
        /// <summary>
        /// Audio data is returned as a URI.
        /// </summary>
        Uri,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioResponseFormatDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseFormatDelivery value)
        {
            return value switch
            {
                AudioResponseFormatDelivery.DeliveryUnspecified => "DELIVERY_UNSPECIFIED",
                AudioResponseFormatDelivery.Inline => "INLINE",
                AudioResponseFormatDelivery.Uri => "URI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponseFormatDelivery? ToEnum(string value)
        {
            return value switch
            {
                "DELIVERY_UNSPECIFIED" => AudioResponseFormatDelivery.DeliveryUnspecified,
                "INLINE" => AudioResponseFormatDelivery.Inline,
                "URI" => AudioResponseFormatDelivery.Uri,
                _ => null,
            };
        }
    }
}