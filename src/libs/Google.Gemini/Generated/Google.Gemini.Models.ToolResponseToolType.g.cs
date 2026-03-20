
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The type of tool that was called, matching the `tool_type` in the corresponding `ToolCall`.
    /// </summary>
    public enum ToolResponseToolType
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
    public static class ToolResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResponseToolType value)
        {
            return value switch
            {
                ToolResponseToolType.ToolTypeUnspecified => "TOOL_TYPE_UNSPECIFIED",
                ToolResponseToolType.GoogleSearchWeb => "GOOGLE_SEARCH_WEB",
                ToolResponseToolType.GoogleSearchImage => "GOOGLE_SEARCH_IMAGE",
                ToolResponseToolType.UrlContext => "URL_CONTEXT",
                ToolResponseToolType.GoogleMaps => "GOOGLE_MAPS",
                ToolResponseToolType.FileSearch => "FILE_SEARCH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "TOOL_TYPE_UNSPECIFIED" => ToolResponseToolType.ToolTypeUnspecified,
                "GOOGLE_SEARCH_WEB" => ToolResponseToolType.GoogleSearchWeb,
                "GOOGLE_SEARCH_IMAGE" => ToolResponseToolType.GoogleSearchImage,
                "URL_CONTEXT" => ToolResponseToolType.UrlContext,
                "GOOGLE_MAPS" => ToolResponseToolType.GoogleMaps,
                "FILE_SEARCH" => ToolResponseToolType.FileSearch,
                _ => null,
            };
        }
    }
}