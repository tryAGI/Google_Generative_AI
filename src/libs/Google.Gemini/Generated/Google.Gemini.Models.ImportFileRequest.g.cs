
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request for `ImportFile` to import a File API file with a `FileSearchStore`.
    /// </summary>
    public sealed partial class ImportFileRequest
    {
        /// <summary>
        /// Custom metadata to be associated with the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customMetadata")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkingConfig")]
        public global::Google.Gemini.ChunkingConfig? ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileRequest" /> class.
        /// </summary>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the file.
        /// </param>
        /// <param name="fileName">
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportFileRequest(
            global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? customMetadata,
            string? fileName,
            global::Google.Gemini.ChunkingConfig? chunkingConfig)
        {
            this.CustomMetadata = customMetadata;
            this.FileName = fileName;
            this.ChunkingConfig = chunkingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileRequest" /> class.
        /// </summary>
        public ImportFileRequest()
        {
        }
    }
}