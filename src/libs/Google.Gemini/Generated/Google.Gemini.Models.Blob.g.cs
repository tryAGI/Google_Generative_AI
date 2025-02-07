
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Raw media bytes. Text should not be sent as raw bytes, use the 'text' field.
    /// </summary>
    public sealed partial class Blob
    {
        /// <summary>
        /// Raw bytes for media formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The IANA standard MIME type of the source data. Accepted types include: "image/png", "image/jpeg", "image/heic", "image/heif", "image/webp".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        /// <param name="data">
        /// Raw bytes for media formats.
        /// </param>
        /// <param name="mimeType">
        /// The IANA standard MIME type of the source data. Accepted types include: "image/png", "image/jpeg", "image/heic", "image/heif", "image/webp".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Blob(
            string? data,
            string? mimeType)
        {
            this.Data = data;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        public Blob()
        {
        }
    }
}