
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An audio content block.
    /// </summary>
    public sealed partial class AudioContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The audio content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// The URI of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// The number of audio channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// The sample rate of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// How the model processes this audio for understanding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>? Processing { get; set; }

        /// <summary>
        /// The mime type of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AudioContentMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.AudioContentMimeType? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data">
        /// The audio content.
        /// </param>
        /// <param name="uri">
        /// The URI of the audio.
        /// </param>
        /// <param name="channels">
        /// The number of audio channels.
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio.
        /// </param>
        /// <param name="processing">
        /// How the model processes this audio for understanding.
        /// </param>
        /// <param name="mimeType">
        /// The mime type of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioContent(
            object type,
            byte[]? data,
            string? uri,
            int? channels,
            int? sampleRate,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>? processing,
            global::Google.Gemini.NextGen.AudioContentMimeType? mimeType)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Data = data;
            this.Uri = uri;
            this.Channels = channels;
            this.SampleRate = sampleRate;
            this.Processing = processing;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContent" /> class.
        /// </summary>
        public AudioContent()
        {
        }

    }
}