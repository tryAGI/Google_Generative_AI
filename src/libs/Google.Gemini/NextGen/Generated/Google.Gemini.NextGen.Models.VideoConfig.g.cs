
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration options for video generation.
    /// </summary>
    public sealed partial class VideoConfig
    {
        /// <summary>
        /// Optional task mode for video generation. If not specified, the model<br/>
        /// automatically determines the appropriate mode based on the provided text<br/>
        /// prompt and input media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VideoConfigTaskJsonConverter))]
        public global::Google.Gemini.NextGen.VideoConfigTask? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConfig" /> class.
        /// </summary>
        /// <param name="task">
        /// Optional task mode for video generation. If not specified, the model<br/>
        /// automatically determines the appropriate mode based on the provided text<br/>
        /// prompt and input media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConfig(
            global::Google.Gemini.NextGen.VideoConfigTask? task)
        {
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConfig" /> class.
        /// </summary>
        public VideoConfig()
        {
        }

    }
}