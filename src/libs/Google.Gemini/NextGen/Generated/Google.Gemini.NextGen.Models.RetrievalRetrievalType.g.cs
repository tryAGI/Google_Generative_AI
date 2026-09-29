
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum RetrievalRetrievalType
    {
        /// <summary>
        ///
        /// </summary>
        ExaAiSearch,
        /// <summary>
        ///
        /// </summary>
        ParallelAiSearch,
        /// <summary>
        ///
        /// </summary>
        RagStore,
        /// <summary>
        ///
        /// </summary>
        VertexAiSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrievalRetrievalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalRetrievalType value)
        {
            return value switch
            {
                RetrievalRetrievalType.ExaAiSearch => "exa_ai_search",
                RetrievalRetrievalType.ParallelAiSearch => "parallel_ai_search",
                RetrievalRetrievalType.RagStore => "rag_store",
                RetrievalRetrievalType.VertexAiSearch => "vertex_ai_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalRetrievalType? ToEnum(string value)
        {
            return value switch
            {
                "exa_ai_search" => RetrievalRetrievalType.ExaAiSearch,
                "parallel_ai_search" => RetrievalRetrievalType.ParallelAiSearch,
                "rag_store" => RetrievalRetrievalType.RagStore,
                "vertex_ai_search" => RetrievalRetrievalType.VertexAiSearch,
                _ => null,
            };
        }
    }
}