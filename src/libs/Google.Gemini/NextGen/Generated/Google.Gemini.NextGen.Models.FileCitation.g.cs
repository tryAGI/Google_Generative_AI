
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A file citation annotation.
    /// </summary>
    public sealed partial class FileCitation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The URI of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_uri")]
        public string? DocumentUri { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Source attributed for a portion of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// User provided metadata about the retrieved context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Page number of the cited document, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Media ID in-case of image citations, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string? MediaId { get; set; }

        /// <summary>
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// End of the attributed segment, exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="documentUri">
        /// The URI of the file.
        /// </param>
        /// <param name="fileName">
        /// The name of the file.
        /// </param>
        /// <param name="source">
        /// Source attributed for a portion of the text.
        /// </param>
        /// <param name="customMetadata">
        /// User provided metadata about the retrieved context.
        /// </param>
        /// <param name="pageNumber">
        /// Page number of the cited document, if applicable.
        /// </param>
        /// <param name="mediaId">
        /// Media ID in-case of image citations, if applicable.
        /// </param>
        /// <param name="startIndex">
        /// Start of segment of the response that is attributed to this source.<br/>
        /// Index indicates the start of the segment, measured in bytes.
        /// </param>
        /// <param name="endIndex">
        /// End of the attributed segment, exclusive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCitation(
            object type,
            string? documentUri,
            string? fileName,
            string? source,
            object? customMetadata,
            int? pageNumber,
            string? mediaId,
            int? startIndex,
            int? endIndex)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DocumentUri = documentUri;
            this.FileName = fileName;
            this.Source = source;
            this.CustomMetadata = customMetadata;
            this.PageNumber = pageNumber;
            this.MediaId = mediaId;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        public FileCitation()
        {
        }

    }
}