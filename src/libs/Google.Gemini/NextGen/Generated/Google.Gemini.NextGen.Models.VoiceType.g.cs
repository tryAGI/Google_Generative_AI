
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Prebuilt,
        /// <summary>
        ///
        /// </summary>
        Prompted,
        /// <summary>
        ///
        /// </summary>
        Replicated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceType value)
        {
            return value switch
            {
                VoiceType.Prebuilt => "prebuilt",
                VoiceType.Prompted => "prompted",
                VoiceType.Replicated => "replicated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceType? ToEnum(string value)
        {
            return value switch
            {
                "prebuilt" => VoiceType.Prebuilt,
                "prompted" => VoiceType.Prompted,
                "replicated" => VoiceType.Replicated,
                _ => null,
            };
        }
    }
}