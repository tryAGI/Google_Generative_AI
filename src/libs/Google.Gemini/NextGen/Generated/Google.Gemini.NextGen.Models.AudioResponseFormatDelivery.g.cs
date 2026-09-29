
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The delivery mode for the audio output.
    /// </summary>
    public enum AudioResponseFormatDelivery
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
    public static class AudioResponseFormatDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseFormatDelivery value)
        {
            return value switch
            {
                AudioResponseFormatDelivery.Inline => "inline",
                AudioResponseFormatDelivery.Uri => "uri",
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
                "inline" => AudioResponseFormatDelivery.Inline,
                "uri" => AudioResponseFormatDelivery.Uri,
                _ => null,
            };
        }
    }
}