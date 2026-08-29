
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
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LatLng? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievedContext? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkCustomMetadata? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.File? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoFileMetadata? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSource? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Status? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileState? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRule? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AuthToken? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BidiGenerateContentSetup? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListModelsResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Model>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Model? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningTask? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Dataset? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Hyperparameters? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningSnapshot? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Candidate? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRating? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CandidateFinishReason? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingMetadata? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Content? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResult? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingAttribution? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationMetadata? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContextMetadata? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequest? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileData? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormat? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatDelivery? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatImageSize? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatMimeType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatAspectRatio? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatch? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchStats? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchState? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputConfig? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchOutput? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.File>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadata? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContentEmbedding? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalConfig? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePart? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseScheduling? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequests? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputEmbedContentConfig? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequests? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySetting? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfig? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolConfig? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Tool? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequestServiceTier? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContent? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContentUsageMetadata? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TopCandidates? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResultCandidate? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseBlob? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedback? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedbackBlockReason? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomLongRunningOperation? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImportFileRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomMetadata? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ChunkingConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StreamableHttpTransport? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContext? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearch? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearch? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearchRetrieval? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.McpServer? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecution? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclaration? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleMaps? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListTunedModelsResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModel? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Document? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DocumentState? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageAuto? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentResponse? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatus? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadata? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Source? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SourceType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Empty? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExample? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCachedContentsResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CachedContent>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelSource? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseDisabledSafetyPolicie? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseEnvironment? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfig? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetection? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolution? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolutionLevel? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigResponseModalitie? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Schema? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigMediaResolution? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TranslationConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechConfig? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ResponseFormatConfig? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Permission? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionGranteeType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionRole? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunk? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Web? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Maps? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Image? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageSearch? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageHints? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StringList? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCount? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCountModality? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchGenerateContentRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SessionResumptionConfig? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContextWindowCompressionConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.HistoryConfig? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResult? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResultOutcome? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingPassageId? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCorporaResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Corpus? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WhiteSpaceConfig? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkStringList? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbeddingUsageMetadata? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListDocumentsResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormat? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatDelivery? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatMimeType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SemanticRetrieverChunk? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponses? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Operation? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfig? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequestTaskType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PlaceAnswerSources? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ReviewSnippet? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListOperationsResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SlidingWindow? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponses? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfigMode? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfig? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AttributionSourceId? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoMetadata? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchStats? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormat? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfigTaskType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCall? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GetEnvironmentFilesResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFile? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingCategory? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingThreshold? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchOutput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchEntryPoint? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalMetadata? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclarationBehavior? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WebSearch? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatusModelStage? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Blob? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfig? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfigMode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponseToolType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingCategory? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingProbability? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatch? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchState? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Interval? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.MultiSpeakerVoiceConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeakerVoiceConfig? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExamples? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VoiceConfig? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearchStore? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFile? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFileState? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormatMimeType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchTypes? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Part? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelState? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFileSearchStoresResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListEnvironmentsResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Environment>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Environment? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PrebuiltVoiceConfig? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SchemaType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFilesResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfigMode? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadToFileSearchStoreRequest? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListPermissionsResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadataServiceTier? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCode? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCodeLanguage? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AsyncBatchEmbedContentRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCall? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCallToolType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListGeneratedFilesResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFileType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentStatus? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkMode? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfigThinkingLevel? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PartMediaProcessing? Type285 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EgressRule>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Model>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.File>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Content>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Tool>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.McpServer>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionDeclaration>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Candidate>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CitationSource>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Corpus>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Document>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Operation>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EnvironmentFile>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Part>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Environment>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Source>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Schema>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Permission>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>? ListType49 { get; set; }
    }
}