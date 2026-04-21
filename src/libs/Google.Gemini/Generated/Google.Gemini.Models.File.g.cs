
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A file uploaded to the API. Next ID: 15
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// Output only. The timestamp of when the `File` was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Output only. The timestamp of when the `File` was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. The download uri of the `File`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUri")]
        public string? DownloadUri { get; set; }

        /// <summary>
        /// Optional. The human-readable display name for the `File`. The display name must be no more than 512 characters in length, including spaces. Example: "Welcome Image"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Source of the File.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FileSourceJsonConverter))]
        public global::Google.Gemini.FileSource? Source { get; set; }

        /// <summary>
        /// Output only. The timestamp of when the `File` will be deleted. Only set if the `File` is scheduled to expire.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationTime")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// Immutable. Identifier. The `File` resource name. The ID (name excluding the "files/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be generated. Example: `files/123-456`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Output only. Size of the file in bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Output only. SHA-256 hash of the uploaded bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256Hash")]
        public byte[]? Sha256Hash { get; set; }

        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Google.Gemini.Status? Error { get; set; }

        /// <summary>
        /// Output only. The uri of the `File`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Output only. MIME type of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Output only. Processing state of the File.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FileStateJsonConverter))]
        public global::Google.Gemini.FileState? State { get; set; }

        /// <summary>
        /// Metadata for a video `File`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoMetadata")]
        public global::Google.Gemini.VideoFileMetadata? VideoMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="updateTime">
        /// Output only. The timestamp of when the `File` was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Output only. The timestamp of when the `File` was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="downloadUri">
        /// Output only. The download uri of the `File`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `File`. The display name must be no more than 512 characters in length, including spaces. Example: "Welcome Image"
        /// </param>
        /// <param name="source">
        /// Source of the File.
        /// </param>
        /// <param name="expirationTime">
        /// Output only. The timestamp of when the `File` will be deleted. Only set if the `File` is scheduled to expire.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Immutable. Identifier. The `File` resource name. The ID (name excluding the "files/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be generated. Example: `files/123-456`
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. Size of the file in bytes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sha256Hash">
        /// Output only. SHA-256 hash of the uploaded bytes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
        /// <param name="uri">
        /// Output only. The uri of the `File`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="mimeType">
        /// Output only. MIME type of the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Output only. Processing state of the File.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="videoMetadata">
        /// Metadata for a video `File`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string? updateTime,
            string? createTime,
            string? downloadUri,
            string? displayName,
            global::Google.Gemini.FileSource? source,
            string? expirationTime,
            string? name,
            string? sizeBytes,
            byte[]? sha256Hash,
            global::Google.Gemini.Status? error,
            string? uri,
            string? mimeType,
            global::Google.Gemini.FileState? state,
            global::Google.Gemini.VideoFileMetadata? videoMetadata)
        {
            this.UpdateTime = updateTime;
            this.CreateTime = createTime;
            this.DownloadUri = downloadUri;
            this.DisplayName = displayName;
            this.Source = source;
            this.ExpirationTime = expirationTime;
            this.Name = name;
            this.SizeBytes = sizeBytes;
            this.Sha256Hash = sha256Hash;
            this.Error = error;
            this.Uri = uri;
            this.MimeType = mimeType;
            this.State = state;
            this.VideoMetadata = videoMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}