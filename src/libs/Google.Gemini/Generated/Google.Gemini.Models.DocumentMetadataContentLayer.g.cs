
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    ///
    /// </summary>
    public enum DocumentMetadataContentLayer
    {
        /// <summary>
        /// Default value.
        /// </summary>
        ContentLayerUnspecified,
        /// <summary>
        /// Rendered page images.
        /// </summary>
        PageImage,
        /// <summary>
        /// Extracted page text.
        /// </summary>
        PageText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentMetadataContentLayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentMetadataContentLayer value)
        {
            return value switch
            {
                DocumentMetadataContentLayer.ContentLayerUnspecified => "CONTENT_LAYER_UNSPECIFIED",
                DocumentMetadataContentLayer.PageImage => "PAGE_IMAGE",
                DocumentMetadataContentLayer.PageText => "PAGE_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentMetadataContentLayer? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_LAYER_UNSPECIFIED" => DocumentMetadataContentLayer.ContentLayerUnspecified,
                "PAGE_IMAGE" => DocumentMetadataContentLayer.PageImage,
                "PAGE_TEXT" => DocumentMetadataContentLayer.PageText,
                _ => null,
            };
        }
    }
}