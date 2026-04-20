
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The task type of the embedding.
    /// </summary>
    public enum EmbedContentConfigTaskType
    {
        /// <summary>
        /// Specifies that the given text will be classified.
        /// </summary>
        Classification,
        /// <summary>
        /// Specifies that the embeddings will be used for clustering.
        /// </summary>
        Clustering,
        /// <summary>
        /// Specifies that the given text will be used for code retrieval.
        /// </summary>
        CodeRetrievalQuery,
        /// <summary>
        /// Specifies that the given text will be used for fact verification.
        /// </summary>
        FactVerification,
        /// <summary>
        /// Specifies that the given text will be used for question answering.
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// Specifies the given text is a document from the corpus being searched.
        /// </summary>
        RetrievalDocument,
        /// <summary>
        /// Specifies the given text is a query in a search/retrieval setting.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// Specifies the given text will be used for STS.
        /// </summary>
        SemanticSimilarity,
        /// <summary>
        /// Unset value, which will default to one of the other enum values.
        /// </summary>
        TaskTypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedContentConfigTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentConfigTaskType value)
        {
            return value switch
            {
                EmbedContentConfigTaskType.Classification => "CLASSIFICATION",
                EmbedContentConfigTaskType.Clustering => "CLUSTERING",
                EmbedContentConfigTaskType.CodeRetrievalQuery => "CODE_RETRIEVAL_QUERY",
                EmbedContentConfigTaskType.FactVerification => "FACT_VERIFICATION",
                EmbedContentConfigTaskType.QuestionAnswering => "QUESTION_ANSWERING",
                EmbedContentConfigTaskType.RetrievalDocument => "RETRIEVAL_DOCUMENT",
                EmbedContentConfigTaskType.RetrievalQuery => "RETRIEVAL_QUERY",
                EmbedContentConfigTaskType.SemanticSimilarity => "SEMANTIC_SIMILARITY",
                EmbedContentConfigTaskType.TaskTypeUnspecified => "TASK_TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentConfigTaskType? ToEnum(string value)
        {
            return value switch
            {
                "CLASSIFICATION" => EmbedContentConfigTaskType.Classification,
                "CLUSTERING" => EmbedContentConfigTaskType.Clustering,
                "CODE_RETRIEVAL_QUERY" => EmbedContentConfigTaskType.CodeRetrievalQuery,
                "FACT_VERIFICATION" => EmbedContentConfigTaskType.FactVerification,
                "QUESTION_ANSWERING" => EmbedContentConfigTaskType.QuestionAnswering,
                "RETRIEVAL_DOCUMENT" => EmbedContentConfigTaskType.RetrievalDocument,
                "RETRIEVAL_QUERY" => EmbedContentConfigTaskType.RetrievalQuery,
                "SEMANTIC_SIMILARITY" => EmbedContentConfigTaskType.SemanticSimilarity,
                "TASK_TYPE_UNSPECIFIED" => EmbedContentConfigTaskType.TaskTypeUnspecified,
                _ => null,
            };
        }
    }
}