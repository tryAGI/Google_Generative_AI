
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Identifier for the source contributing to this attribution.
    /// </summary>
    public sealed partial class AttributionSourceId
    {
        /// <summary>
        /// Identifier for a `Chunk` retrieved via Semantic Retriever specified in the `GenerateAnswerRequest` using `SemanticRetrieverConfig`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semanticRetrieverChunk")]
        public global::Google.Gemini.SemanticRetrieverChunk? SemanticRetrieverChunk { get; set; }

        /// <summary>
        /// Identifier for a part within a `GroundingPassage`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundingPassage")]
        public global::Google.Gemini.GroundingPassageId? GroundingPassage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionSourceId" /> class.
        /// </summary>
        /// <param name="semanticRetrieverChunk">
        /// Identifier for a `Chunk` retrieved via Semantic Retriever specified in the `GenerateAnswerRequest` using `SemanticRetrieverConfig`.
        /// </param>
        /// <param name="groundingPassage">
        /// Identifier for a part within a `GroundingPassage`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributionSourceId(
            global::Google.Gemini.SemanticRetrieverChunk? semanticRetrieverChunk,
            global::Google.Gemini.GroundingPassageId? groundingPassage)
        {
            this.SemanticRetrieverChunk = semanticRetrieverChunk;
            this.GroundingPassage = groundingPassage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionSourceId" /> class.
        /// </summary>
        public AttributionSourceId()
        {
        }
    }
}