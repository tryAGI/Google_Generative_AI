
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configures the input to the batch request.
    /// </summary>
    public sealed partial class InputEmbedContentConfig
    {
        /// <summary>
        /// The requests to be processed in the batch if provided as part of the batch creation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::Google.Gemini.InlinedEmbedContentRequests? Requests { get; set; }

        /// <summary>
        /// The name of the `File` containing the input requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputEmbedContentConfig" /> class.
        /// </summary>
        /// <param name="requests">
        /// The requests to be processed in the batch if provided as part of the batch creation request.
        /// </param>
        /// <param name="fileName">
        /// The name of the `File` containing the input requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputEmbedContentConfig(
            global::Google.Gemini.InlinedEmbedContentRequests? requests,
            string? fileName)
        {
            this.Requests = requests;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputEmbedContentConfig" /> class.
        /// </summary>
        public InputEmbedContentConfig()
        {
        }
    }
}