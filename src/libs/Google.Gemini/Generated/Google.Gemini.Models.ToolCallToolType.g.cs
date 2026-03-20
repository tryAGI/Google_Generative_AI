
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The type of tool that was called.
    /// </summary>
    public enum ToolCallToolType
    {
        /// <summary>
        /// Unspecified tool type.
        /// </summary>
        ToolTypeUnspecified,
        /// <summary>
        /// Google search tool, maps to Tool.google_search.search_types.web_search.
        /// </summary>
        GoogleSearchWeb,
        /// <summary>
        /// Image search tool, maps to Tool.google_search.search_types.image_search.
        /// </summary>
        GoogleSearchImage,
        /// <summary>
        /// URL context tool, maps to Tool.url_context.
        /// </summary>
        UrlContext,
        /// <summary>
        /// Google maps tool, maps to Tool.google_maps.
        /// </summary>
        GoogleMaps,
        /// <summary>
        /// File search tool, maps to Tool.file_search.
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallToolType value)
        {
            return value switch
            {
                ToolCallToolType.ToolTypeUnspecified => "TOOL_TYPE_UNSPECIFIED",
                ToolCallToolType.GoogleSearchWeb => "GOOGLE_SEARCH_WEB",
                ToolCallToolType.GoogleSearchImage => "GOOGLE_SEARCH_IMAGE",
                ToolCallToolType.UrlContext => "URL_CONTEXT",
                ToolCallToolType.GoogleMaps => "GOOGLE_MAPS",
                ToolCallToolType.FileSearch => "FILE_SEARCH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallToolType? ToEnum(string value)
        {
            return value switch
            {
                "TOOL_TYPE_UNSPECIFIED" => ToolCallToolType.ToolTypeUnspecified,
                "GOOGLE_SEARCH_WEB" => ToolCallToolType.GoogleSearchWeb,
                "GOOGLE_SEARCH_IMAGE" => ToolCallToolType.GoogleSearchImage,
                "URL_CONTEXT" => ToolCallToolType.UrlContext,
                "GOOGLE_MAPS" => ToolCallToolType.GoogleMaps,
                "FILE_SEARCH" => ToolCallToolType.FileSearch,
                _ => null,
            };
        }
    }
}