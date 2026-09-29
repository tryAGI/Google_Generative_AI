
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model to search files.
    /// </summary>
    public sealed partial class FileSearch
    {
        /// <summary>
        /// The file search store names to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search_store_names")]
        public global::System.Collections.Generic.IList<string>? FileSearchStoreNames { get; set; }

        /// <summary>
        /// Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// The number of semantic retrieval chunks to retrieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fileSearchStoreNames">
        /// The file search store names to search.
        /// </param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </param>
        /// <param name="topK">
        /// The number of semantic retrieval chunks to retrieve.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearch(
            object type,
            global::System.Collections.Generic.IList<string>? fileSearchStoreNames,
            string? metadataFilter,
            int? topK)
        {
            this.FileSearchStoreNames = fileSearchStoreNames;
            this.MetadataFilter = metadataFilter;
            this.TopK = topK;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        public FileSearch()
        {
        }

    }
}