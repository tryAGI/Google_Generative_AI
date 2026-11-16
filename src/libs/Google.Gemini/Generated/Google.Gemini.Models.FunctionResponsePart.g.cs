
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A datatype containing media that is part of a `FunctionResponse` message. A `FunctionResponsePart` consists of data which has an associated datatype. A `FunctionResponsePart` can only contain one of the accepted types in `FunctionResponsePart.data`. Media can be passed as raw bytes (`inline_data`) or by URI (`file_data`) with an IANA MIME type identifying the type and subtype of the media.
    /// </summary>
    public sealed partial class FunctionResponsePart
    {
        /// <summary>
        /// Media resolution for tokenization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaResolution")]
        public global::Google.Gemini.V1mainMediaResolution? MediaResolution { get; set; }

        /// <summary>
        /// Metadata describes the input audio content. Set this in `Part.audio_metadata` or `FunctionResponsePart.audio_metadata` when `inline_data` or `file_data` contains audio to configure static audio preprocessing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioMetadata")]
        public global::Google.Gemini.AudioMetadata? AudioMetadata { get; set; }

        /// <summary>
        /// Metadata describes the input spreadsheet content. Set this in `Part.spreadsheet_metadata` or `FunctionResponsePart.spreadsheet_metadata` when `inline_data` or `file_data` contains a spreadsheet to configure static spreadsheet preprocessing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheetMetadata")]
        public global::Google.Gemini.SpreadsheetMetadata? SpreadsheetMetadata { get; set; }

        /// <summary>
        /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaProcessing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.FunctionResponsePartMediaProcessingJsonConverter))]
        public global::Google.Gemini.FunctionResponsePartMediaProcessing? MediaProcessing { get; set; }

        /// <summary>
        /// Metadata describes the input document content. Set this in `Part.document_metadata` or `FunctionResponsePart.document_metadata` when `inline_data` or `file_data` contains a document to configure static document preprocessing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentMetadata")]
        public global::Google.Gemini.DocumentMetadata? DocumentMetadata { get; set; }

        /// <summary>
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlineData")]
        public global::Google.Gemini.FunctionResponseBlob? InlineData { get; set; }

        /// <summary>
        /// URI based data for function response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileData")]
        public global::Google.Gemini.FunctionResponseFileData? FileData { get; set; }

        /// <summary>
        /// Metadata describes the input video content. Set this in `Part.video_metadata` or `FunctionResponsePart.video_metadata` when `inline_data` or `file_data` contains video to configure static video preprocessing (such as time clipping, frame rate, maximum frame count, or extracted content layers).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoMetadata")]
        public global::Google.Gemini.VideoMetadata? VideoMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        /// <param name="mediaResolution">
        /// Media resolution for tokenization.
        /// </param>
        /// <param name="audioMetadata">
        /// Metadata describes the input audio content. Set this in `Part.audio_metadata` or `FunctionResponsePart.audio_metadata` when `inline_data` or `file_data` contains audio to configure static audio preprocessing.
        /// </param>
        /// <param name="spreadsheetMetadata">
        /// Metadata describes the input spreadsheet content. Set this in `Part.spreadsheet_metadata` or `FunctionResponsePart.spreadsheet_metadata` when `inline_data` or `file_data` contains a spreadsheet to configure static spreadsheet preprocessing.
        /// </param>
        /// <param name="mediaProcessing">
        /// Optional. How the model processes this part's media for understanding. Only meaningful for video parts (`inline_data` or `file_data` with video mime). Non-video parts ignore this field.
        /// </param>
        /// <param name="documentMetadata">
        /// Metadata describes the input document content. Set this in `Part.document_metadata` or `FunctionResponsePart.document_metadata` when `inline_data` or `file_data` contains a document to configure static document preprocessing.
        /// </param>
        /// <param name="inlineData">
        /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
        /// </param>
        /// <param name="fileData">
        /// URI based data for function response.
        /// </param>
        /// <param name="videoMetadata">
        /// Metadata describes the input video content. Set this in `Part.video_metadata` or `FunctionResponsePart.video_metadata` when `inline_data` or `file_data` contains video to configure static video preprocessing (such as time clipping, frame rate, maximum frame count, or extracted content layers).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponsePart(
            global::Google.Gemini.V1mainMediaResolution? mediaResolution,
            global::Google.Gemini.AudioMetadata? audioMetadata,
            global::Google.Gemini.SpreadsheetMetadata? spreadsheetMetadata,
            global::Google.Gemini.FunctionResponsePartMediaProcessing? mediaProcessing,
            global::Google.Gemini.DocumentMetadata? documentMetadata,
            global::Google.Gemini.FunctionResponseBlob? inlineData,
            global::Google.Gemini.FunctionResponseFileData? fileData,
            global::Google.Gemini.VideoMetadata? videoMetadata)
        {
            this.MediaResolution = mediaResolution;
            this.AudioMetadata = audioMetadata;
            this.SpreadsheetMetadata = spreadsheetMetadata;
            this.MediaProcessing = mediaProcessing;
            this.DocumentMetadata = documentMetadata;
            this.InlineData = inlineData;
            this.FileData = fileData;
            this.VideoMetadata = videoMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponsePart" /> class.
        /// </summary>
        public FunctionResponsePart()
        {
        }

    }
}