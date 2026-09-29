
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Audio payload used for voice creation.
    /// </summary>
    public sealed partial class AudioData
    {
        /// <summary>
        /// Required. The raw audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// Required. The IANA MIME type of the audio data (for example, `audio/wav` or<br/>
        /// `audio/mpeg`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioData" /> class.
        /// </summary>
        /// <param name="data">
        /// Required. The raw audio bytes.
        /// </param>
        /// <param name="mimeType">
        /// Required. The IANA MIME type of the audio data (for example, `audio/wav` or<br/>
        /// `audio/mpeg`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioData(
            byte[] data,
            string mimeType)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioData" /> class.
        /// </summary>
        public AudioData()
        {
        }

    }
}