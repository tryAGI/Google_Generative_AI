
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The definition of the Rag resource.
    /// </summary>
    public sealed partial class RagResource
    {
        /// <summary>
        /// Optional. RagCorpora resource name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_corpus")]
        public string? RagCorpus { get; set; }

        /// <summary>
        /// Optional. rag_file_id. The files should be in the same rag_corpus set in<br/>
        /// rag_corpus field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_file_ids")]
        public global::System.Collections.Generic.IList<string>? RagFileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagResource" /> class.
        /// </summary>
        /// <param name="ragCorpus">
        /// Optional. RagCorpora resource name.
        /// </param>
        /// <param name="ragFileIds">
        /// Optional. rag_file_id. The files should be in the same rag_corpus set in<br/>
        /// rag_corpus field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagResource(
            string? ragCorpus,
            global::System.Collections.Generic.IList<string>? ragFileIds)
        {
            this.RagCorpus = ragCorpus;
            this.RagFileIds = ragFileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagResource" /> class.
        /// </summary>
        public RagResource()
        {
        }

    }
}