
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The type of retrieval tools.
    /// </summary>
    public enum RetrievalCallStepRetrievalType
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
    public static class RetrievalCallStepRetrievalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalCallStepRetrievalType value)
        {
            return value switch
            {
                RetrievalCallStepRetrievalType.ExaAiSearch => "exa_ai_search",
                RetrievalCallStepRetrievalType.ParallelAiSearch => "parallel_ai_search",
                RetrievalCallStepRetrievalType.RagStore => "rag_store",
                RetrievalCallStepRetrievalType.VertexAiSearch => "vertex_ai_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalCallStepRetrievalType? ToEnum(string value)
        {
            return value switch
            {
                "exa_ai_search" => RetrievalCallStepRetrievalType.ExaAiSearch,
                "parallel_ai_search" => RetrievalCallStepRetrievalType.ParallelAiSearch,
                "rag_store" => RetrievalCallStepRetrievalType.RagStore,
                "vertex_ai_search" => RetrievalCallStepRetrievalType.VertexAiSearch,
                _ => null,
            };
        }
    }
}