
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioDelta
    {
        /// <summary>
        /// The number of audio channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public int? Channels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AudioDeltaMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.AudioDeltaMimeType? MimeType { get; set; }

        /// <summary>
        /// Deprecated. Use sample_rate instead. The value is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Rate { get; set; }

        /// <summary>
        /// The sample rate of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

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
        /// Initializes a new instance of the <see cref="AudioDelta" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="channels">
        /// The number of audio channels.
        /// </param>
        /// <param name="data"></param>
        /// <param name="mimeType"></param>
        /// <param name="sampleRate">
        /// The sample rate of the audio.
        /// </param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioDelta(
            object type,
            int? channels,
            byte[]? data,
            global::Google.Gemini.NextGen.AudioDeltaMimeType? mimeType,
            int? sampleRate,
            string? uri)
        {
            this.Channels = channels;
            this.Data = data;
            this.MimeType = mimeType;
            this.SampleRate = sampleRate;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDelta" /> class.
        /// </summary>
        public AudioDelta()
        {
        }

    }
}