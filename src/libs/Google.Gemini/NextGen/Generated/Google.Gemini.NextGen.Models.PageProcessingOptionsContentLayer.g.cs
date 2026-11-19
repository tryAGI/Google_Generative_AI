
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum PageProcessingOptionsContentLayer
    {
        /// <summary>
        ///
        /// </summary>
        PageImage,
        /// <summary>
        ///
        /// </summary>
        PageText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PageProcessingOptionsContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageProcessingOptionsContentLayer value)
        {
            return value switch
            {
                PageProcessingOptionsContentLayer.PageImage => "page_image",
                PageProcessingOptionsContentLayer.PageText => "page_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageProcessingOptionsContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "page_image" => PageProcessingOptionsContentLayer.PageImage,
                "page_text" => PageProcessingOptionsContentLayer.PageText,
                _ => null,
            };
        }
    }
}