
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A video content block.<br/>
    /// Example: {"type":"video","uri":"https://www.youtube.com/watch?v=9hE5-98ZeCg"}
    /// </summary>
    public sealed partial class VideoContent
    {
        /// <summary>
        /// The video content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// The mime type of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoContentMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.VideoContentMimeType? MimeType { get; set; }

        /// <summary>
        /// A user-defined name for this content block. Can be referenced by the model<br/>
        /// in the final response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the model processes this video for understanding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Processing { get; set; }

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
        /// The URI of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data">
        /// The video content.
        /// </param>
        /// <param name="mimeType">
        /// The mime type of the video.
        /// </param>
        /// <param name="name">
        /// A user-defined name for this content block. Can be referenced by the model<br/>
        /// in the final response.
        /// </param>
        /// <param name="processing">
        /// How the model processes this video for understanding.
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="uri">
        /// The URI of the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContent(
            object type,
            byte[]? data,
            global::Google.Gemini.NextGen.VideoContentMimeType? mimeType,
            string? name,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? processing,
            global::Google.Gemini.NextGen.MediaResolution? resolution,
            string? uri)
        {
            this.Data = data;
            this.MimeType = mimeType;
            this.Name = name;
            this.Processing = processing;
            this.Resolution = resolution;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContent" /> class.
        /// </summary>
        public VideoContent()
        {
        }

    }
}