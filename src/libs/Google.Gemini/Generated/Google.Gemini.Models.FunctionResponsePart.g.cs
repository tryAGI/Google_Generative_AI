
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A datatype containing media that is part of a `FunctionResponse` message. A `FunctionResponsePart` consists of data which has an associated datatype. A `FunctionResponsePart` can only contain one of the accepted types in `FunctionResponsePart.data`. A `FunctionResponsePart` must have a fixed IANA MIME type identifying the type and subtype of the media if the `inline_data` field is filled with raw bytes.
    /// </summary>
    public sealed partial class FunctionResponsePart
    {
        /// <summary>
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlineData")]
        public global::Google.Gemini.FunctionResponseBlob? InlineData { get; set; }

        /// <summary>
        /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaProcessing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FunctionResponsePartMediaProcessingJsonConverter))]
        public global::Google.Gemini.FunctionResponsePartMediaProcessing? MediaProcessing { get; set; }

        /// <summary>
        /// URI based data for function response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileData")]
        public global::Google.Gemini.FunctionResponseFileData? FileData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        /// <param name="inlineData">
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </param>
        /// <param name="mediaProcessing">
        /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
        /// </param>
        /// <param name="fileData">
        /// URI based data for function response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponsePart(
            global::Google.Gemini.FunctionResponseBlob? inlineData,
            global::Google.Gemini.FunctionResponsePartMediaProcessing? mediaProcessing,
            global::Google.Gemini.FunctionResponseFileData? fileData)
        {
            this.InlineData = inlineData;
            this.MediaProcessing = mediaProcessing;
            this.FileData = fileData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        public FunctionResponsePart()
        {
        }

    }
}