
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequest? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Source? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Web? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TopCandidates? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResultCandidate? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseEnvironment? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseDisabledSafetyPolicie? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StringList? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponse? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponseToolType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageConfig? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListGeneratedFilesResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFile? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Schema? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SchemaType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadToFileSearchStoreRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomMetadata? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ChunkingConfig? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContentEmbedding? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbeddingUsageMetadata? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequests? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfig? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfigThinkingLevel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Permission? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionRole? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionGranteeType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningSnapshot? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListDocumentsResponse? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Document? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadata? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCount? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadataServiceTier? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfig? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ResponseFormatConfig? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TranslationConfig? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigResponseModalitie? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigMediaResolution? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechConfig? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfig? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AsyncBatchEmbedContentRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatch? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContextWindowCompressionConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SlidingWindow? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatus? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatusModelStage? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListOperationsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Operation? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageAuto? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseScheduling? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePart? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadata? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearch? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Interval? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchTypes? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseFileData? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormat? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormat? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormat? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SourceType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageHints? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContext? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LatLng? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolution? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolutionLevel? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VoiceConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PrebuiltVoiceConfig? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SemanticRetrieverChunk? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfig? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfigMode? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResult? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileResponse? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFile? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySetting? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingCategory? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingThreshold? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.MultiSpeakerVoiceConfig? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Status? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BidiGenerateContentSetup? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Tool? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SessionResumptionConfig? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.HistoryConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfig? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Content? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatDelivery? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatMimeType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContextMetadata? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Model? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Hyperparameters? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Dataset? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExamples? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchOutput? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponses? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearch? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFilesResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.File>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.File? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Maps? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PlaceAnswerSources? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFileType? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ReviewSnippet? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WhiteSpaceConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatImageSize? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatDelivery? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatMimeType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatAspectRatio? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeakerVoiceConfig? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Part? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Blob? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCode? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PartMediaProcessing? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoMetadata? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechMetadata? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCall? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscription? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResult? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCall? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileData? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCorporaResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Corpus? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListTunedModelsResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModel? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationMetadata? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationSource? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchEntryPoint? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContentUsageMetadata? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AttributionSourceId? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingPassageId? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedback? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedbackBlockReason? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRating? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomLongRunningOperation? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListEnvironmentsResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Environment>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Environment? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.McpServer? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecution? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleMaps? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearchRetrieval? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclaration? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListModelsResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Model>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WordInfo? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Image? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AuthToken? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImportFileRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListPermissionsResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputConfig? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfig? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfigTaskType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkCustomMetadata? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkStringList? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearchStore? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclarationBehavior? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningTask? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelSource? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelState? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputEmbedContentConfig? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequests? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCallToolType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchOutput? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponses? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentStatus? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkMode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFileState? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GetEnvironmentFilesResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRule? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRuleMode? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetection? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCodeLanguage? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFileSearchStoresResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Candidate? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfig? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfigMode? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageSearch? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoFileMetadata? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchState? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchStats? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunk? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievedContext? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileRequest? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCachedContentsResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CachedContent>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContent? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequestTaskType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalMetadata? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingAttribution? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingMetadata? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CandidateFinishReason? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchGenerateContentRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatch? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCountModality? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchStats? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchState? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Empty? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolConfig? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequestServiceTier? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormatMimeType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StreamableHttpTransport? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResultOutcome? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WebSearch? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingCategory? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingProbability? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfigMode? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseBlob? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSource? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileState? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExample? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePartMediaProcessing? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DocumentState? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? Type294 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Source>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Schema>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Document>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Operation>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EnvironmentFile>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Tool>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.File>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Corpus>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CitationSource>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Content>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Environment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.McpServer>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionDeclaration>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Model>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.WordInfo>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Permission>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Candidate>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Part>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EgressRule>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>? ListType50 { get; set; }
    }
}