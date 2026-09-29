
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for video output format.
    /// </summary>
    public sealed partial class VideoResponseFormat
    {
        /// <summary>
        /// The aspect ratio for the video output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatAspectRatioJsonConverter))]
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The delivery mode for the video output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatDeliveryJsonConverter))]
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Delivery { get; set; }

        /// <summary>
        /// The duration for the video output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// The Cloud Storage URI to store the video output. Required for Vertex if<br/>
        /// delivery mode is URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcs_uri")]
        public string? GcsUri { get; set; }

        /// <summary>
        /// The video output resolution. Defaults to 720p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatResolutionJsonConverter))]
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="aspectRatio">
        /// The aspect ratio for the video output.
        /// </param>
        /// <param name="delivery">
        /// The delivery mode for the video output.
        /// </param>
        /// <param name="duration">
        /// The duration for the video output.
        /// </param>
        /// <param name="gcsUri">
        /// The Cloud Storage URI to store the video output. Required for Vertex if<br/>
        /// delivery mode is URI.
        /// </param>
        /// <param name="resolution">
        /// The video output resolution. Defaults to 720p.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResponseFormat(
            object type,
            global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? aspectRatio,
            global::Google.Gemini.NextGen.VideoResponseFormatDelivery? delivery,
            string? duration,
            string? gcsUri,
            global::Google.Gemini.NextGen.VideoResponseFormatResolution? resolution)
        {
            this.AspectRatio = aspectRatio;
            this.Delivery = delivery;
            this.Duration = duration;
            this.GcsUri = gcsUri;
            this.Resolution = resolution;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponseFormat" /> class.
        /// </summary>
        public VideoResponseFormat()
        {
        }

    }
}