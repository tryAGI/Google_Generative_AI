
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoDeltaMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.MediaResolutionJsonConverter))]
        public global::Google.Gemini.NextGen.MediaResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDelta" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="mimeType"></param>
        /// <param name="resolution"></param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoDelta(
            object type,
            byte[]? data,
            global::Google.Gemini.NextGen.VideoDeltaMimeType? mimeType,
            global::Google.Gemini.NextGen.MediaResolution? resolution,
            string? uri)
        {
            this.Data = data;
            this.MimeType = mimeType;
            this.Resolution = resolution;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDelta" /> class.
        /// </summary>
        public VideoDelta()
        {
        }

    }
}