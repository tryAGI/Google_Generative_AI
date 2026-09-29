
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The type of retrieval tools.
    /// </summary>
    public enum RetrievalCallDeltaRetrievalType
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
    public static class RetrievalCallDeltaRetrievalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalCallDeltaRetrievalType value)
        {
            return value switch
            {
                RetrievalCallDeltaRetrievalType.ExaAiSearch => "exa_ai_search",
                RetrievalCallDeltaRetrievalType.ParallelAiSearch => "parallel_ai_search",
                RetrievalCallDeltaRetrievalType.RagStore => "rag_store",
                RetrievalCallDeltaRetrievalType.VertexAiSearch => "vertex_ai_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalCallDeltaRetrievalType? ToEnum(string value)
        {
            return value switch
            {
                "exa_ai_search" => RetrievalCallDeltaRetrievalType.ExaAiSearch,
                "parallel_ai_search" => RetrievalCallDeltaRetrievalType.ParallelAiSearch,
                "rag_store" => RetrievalCallDeltaRetrievalType.RagStore,
                "vertex_ai_search" => RetrievalCallDeltaRetrievalType.VertexAiSearch,
                _ => null,
            };
        }
    }
}