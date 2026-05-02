
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The FileSearch tool that retrieves knowledge from Semantic Retrieval corpora. Files are imported to Semantic Retrieval corpora using the ImportFile API.
    /// </summary>
    public sealed partial class FileSearch
    {
        /// <summary>
        /// Optional. Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataFilter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// Optional. The number of semantic retrieval chunks to retrieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Required. The names of the file_search_stores to retrieve from. Example: `fileSearchStores/my-file-search-store-123`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSearchStoreNames")]
        public global::System.Collections.Generic.IList<string>? FileSearchStoreNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        /// <param name="metadataFilter">
        /// Optional. Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </param>
        /// <param name="topK">
        /// Optional. The number of semantic retrieval chunks to retrieve.
        /// </param>
        /// <param name="fileSearchStoreNames">
        /// Required. The names of the file_search_stores to retrieve from. Example: `fileSearchStores/my-file-search-store-123`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearch(
            string? metadataFilter,
            int? topK,
            global::System.Collections.Generic.IList<string>? fileSearchStoreNames)
        {
            this.MetadataFilter = metadataFilter;
            this.TopK = topK;
            this.FileSearchStoreNames = fileSearchStoreNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        public FileSearch()
        {
        }
    }
}