
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configuration for audio output format.
    /// </summary>
    public sealed partial class AudioResponseFormat
    {
        /// <summary>
        /// Optional. The MIME type of the audio output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.AudioResponseFormatMimeTypeJsonConverter))]
        public global::Google.Gemini.AudioResponseFormatMimeType? MimeType { get; set; }

        /// <summary>
        /// Optional. The delivery mode for the audio output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.AudioResponseFormatDeliveryJsonConverter))]
        public global::Google.Gemini.AudioResponseFormatDelivery? Delivery { get; set; }

        /// <summary>
        /// Optional. Bit rate in bits per second (bps). Only applicable for compressed formats (MP3, Opus).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitRate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// Optional. Sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponseFormat" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// Optional. The MIME type of the audio output.
        /// </param>
        /// <param name="delivery">
        /// Optional. The delivery mode for the audio output.
        /// </param>
        /// <param name="bitRate">
        /// Optional. Bit rate in bits per second (bps). Only applicable for compressed formats (MP3, Opus).
        /// </param>
        /// <param name="sampleRate">
        /// Optional. Sample rate in Hz.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioResponseFormat(
            global::Google.Gemini.AudioResponseFormatMimeType? mimeType,
            global::Google.Gemini.AudioResponseFormatDelivery? delivery,
            int? bitRate,
            int? sampleRate)
        {
            this.MimeType = mimeType;
            this.Delivery = delivery;
            this.BitRate = bitRate;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponseFormat" /> class.
        /// </summary>
        public AudioResponseFormat()
        {
        }

    }
}