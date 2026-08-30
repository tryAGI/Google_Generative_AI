
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata for a file or directory within an environment.
    /// </summary>
    public sealed partial class EnvironmentFile
    {
        /// <summary>
        /// Output only. The full relative path within the environment (e.g., "workspace/src/main.py").<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Output only. The modification time of the file/directory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public string? Modified { get; set; }

        /// <summary>
        /// Output only. The MIME type of the file (e.g., "text/python", "image/png"). Empty for directories. NOLINT<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Output only. The name of the file or directory (e.g., "main.py" or "src").<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Output only. The size of the file/directory in bytes. NOLINT<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Output only. The creation time of the file/directory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Output only. The type of the entry.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentFileTypeJsonConverter))]
        public global::Google.Gemini.EnvironmentFileType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFile" /> class.
        /// </summary>
        /// <param name="path">
        /// Output only. The full relative path within the environment (e.g., "workspace/src/main.py").<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modified">
        /// Output only. The modification time of the file/directory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="mimeType">
        /// Output only. The MIME type of the file (e.g., "text/python", "image/png"). Empty for directories. NOLINT<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Output only. The name of the file or directory (e.g., "main.py" or "src").<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The size of the file/directory in bytes. NOLINT<br/>
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Output only. The creation time of the file/directory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Output only. The type of the entry.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentFile(
            string? path,
            string? modified,
            string? mimeType,
            string? name,
            string? sizeBytes,
            string? created,
            global::Google.Gemini.EnvironmentFileType? type)
        {
            this.Path = path;
            this.Modified = modified;
            this.MimeType = mimeType;
            this.Name = name;
            this.SizeBytes = sizeBytes;
            this.Created = created;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFile" /> class.
        /// </summary>
        public EnvironmentFile()
        {
        }

    }
}