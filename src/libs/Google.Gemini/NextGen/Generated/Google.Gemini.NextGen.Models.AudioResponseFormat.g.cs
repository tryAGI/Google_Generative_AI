
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for audio output format.<br/>
    /// Example: {"type":"audio","sample_rate":24000}
    /// </summary>
    public sealed partial class AudioResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The MIME type of the audio output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// The delivery mode for the audio output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatDeliveryJsonConverter))]
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Delivery { get; set; }

        /// <summary>
        /// Sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Bit rate in bits per second (bps). Only applicable for compressed formats<br/>
        /// (MP3, Opus).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mimeType">
        /// The MIME type of the audio output.
        /// </param>
        /// <param name="delivery">
        /// The delivery mode for the audio output.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="bitRate">
        /// Bit rate in bits per second (bps). Only applicable for compressed formats<br/>
        /// (MP3, Opus).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioResponseFormat(
            object type,
            global::Google.Gemini.NextGen.AudioResponseFormatMimeType? mimeType,
            global::Google.Gemini.NextGen.AudioResponseFormatDelivery? delivery,
            int? sampleRate,
            int? bitRate)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.MimeType = mimeType;
            this.Delivery = delivery;
            this.SampleRate = sampleRate;
            this.BitRate = bitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponseFormat" /> class.
        /// </summary>
        public AudioResponseFormat()
        {
        }

    }
}