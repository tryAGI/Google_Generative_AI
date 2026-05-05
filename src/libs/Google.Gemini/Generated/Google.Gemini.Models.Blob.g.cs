
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
        public byte[]? Data { get; set; }

        /// <summary>
        /// The IANA standard MIME type of the source data. Examples of supported types: - Images: image/png, image/jpeg, image/jpg, image/webp, image/heic, image/heif, image/gif, image/avif - Audio: audio/*, video/audio/s16le, video/audio/wav - Video: video/* - Text: text/plain, text/html, text/css, text/javascript, text/x-typescript, text/csv, text/markdown, text/x-python, text/xml, text/rtf, video/text/timestamp - Applications: application/x-javascript, application/x-typescript, application/x-python-code, application/json, application/x-ipynb+json, application/rtf, application/pdf For additional context, see [Supported file formats](https://ai.google.dev/gemini-api/docs/file-input-methods#supported-content-types). //
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
        /// The IANA standard MIME type of the source data. Examples of supported types: - Images: image/png, image/jpeg, image/jpg, image/webp, image/heic, image/heif, image/gif, image/avif - Audio: audio/*, video/audio/s16le, video/audio/wav - Video: video/* - Text: text/plain, text/html, text/css, text/javascript, text/x-typescript, text/csv, text/markdown, text/x-python, text/xml, text/rtf, video/text/timestamp - Applications: application/x-javascript, application/x-typescript, application/x-python-code, application/json, application/x-ipynb+json, application/rtf, application/pdf For additional context, see [Supported file formats](https://ai.google.dev/gemini-api/docs/file-input-methods#supported-content-types). //
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Blob(
            byte[]? data,
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