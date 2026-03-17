
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The mode of the predictor to be used in dynamic retrieval.
    /// </summary>
    public enum DynamicRetrievalConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        ModeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        ModeDynamic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DynamicRetrievalConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DynamicRetrievalConfigMode value)
        {
            return value switch
            {
                DynamicRetrievalConfigMode.ModeUnspecified => "MODE_UNSPECIFIED",
                DynamicRetrievalConfigMode.ModeDynamic => "MODE_DYNAMIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DynamicRetrievalConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "MODE_UNSPECIFIED" => DynamicRetrievalConfigMode.ModeUnspecified,
                "MODE_DYNAMIC" => DynamicRetrievalConfigMode.ModeDynamic,
                _ => null,
            };
        }
    }
}