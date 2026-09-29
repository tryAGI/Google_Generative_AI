
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Whether to include visualizations in the response.
    /// </summary>
    public enum DeepResearchAgentConfigVisualization
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepResearchAgentConfigVisualizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepResearchAgentConfigVisualization value)
        {
            return value switch
            {
                DeepResearchAgentConfigVisualization.Auto => "auto",
                DeepResearchAgentConfigVisualization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepResearchAgentConfigVisualization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => DeepResearchAgentConfigVisualization.Auto,
                "off" => DeepResearchAgentConfigVisualization.Off,
                _ => null,
            };
        }
    }
}