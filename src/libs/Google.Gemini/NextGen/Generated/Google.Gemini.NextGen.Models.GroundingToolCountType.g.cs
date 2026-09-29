
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The grounding tool type associated with the count.
    /// </summary>
    public enum GroundingToolCountType
    {
        /// <summary>
        ///
        /// </summary>
        GoogleMaps,
        /// <summary>
        ///
        /// </summary>
        GoogleSearch,
        /// <summary>
        ///
        /// </summary>
        Retrieval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroundingToolCountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroundingToolCountType value)
        {
            return value switch
            {
                GroundingToolCountType.GoogleMaps => "google_maps",
                GroundingToolCountType.GoogleSearch => "google_search",
                GroundingToolCountType.Retrieval => "retrieval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroundingToolCountType? ToEnum(string value)
        {
            return value switch
            {
                "google_maps" => GroundingToolCountType.GoogleMaps,
                "google_search" => GroundingToolCountType.GoogleSearch,
                "retrieval" => GroundingToolCountType.Retrieval,
                _ => null,
            };
        }
    }
}