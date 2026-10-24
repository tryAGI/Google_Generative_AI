
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
        public global::Google.Gemini.VoiceConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PrebuiltVoiceConfig? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Content? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequest? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.File>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.File? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Candidate? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatus? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedback? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadata? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechConfig? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.MultiSpeakerVoiceConfig? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCode? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCodeLanguage? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCall? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResultCandidate? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ReviewSnippet? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationMetadata? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationSource? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WordInfo? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingPassageId? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormat? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatDelivery? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatMimeType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearchStore? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContext? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LatLng? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolution? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolutionLevel? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Interval? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Dataset? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExamples? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingAttribution? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AttributionSourceId? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfigMode? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageAuto? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageHints? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModel? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelSource? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningTask? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelState? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRule? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkCustomMetadata? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkStringList? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoFileMetadata? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfig? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetection? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadToFileSearchStoreRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomMetadata? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ChunkingConfig? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseScheduling? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePart? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecution? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatch? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchState? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchOutput? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchStats? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputEmbedContentConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfig? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TranslationConfig? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Schema? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageConfig? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigResponseModalitie? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ResponseFormatConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigMediaResolution? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCount? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCountModality? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFileSearchStoresResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbeddingUsageMetadata? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoMetadata? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadataServiceTier? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExample? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GetEnvironmentFilesResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFile? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Environment? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Source? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkMode? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearchRetrieval? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfig? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Status? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormat? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormat? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContextWindowCompressionConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SlidingWindow? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSource? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileState? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type119 { get; set; }
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
        public global::Google.Gemini.CachedContent? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponseToolType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Hyperparameters? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponses? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeakerVoiceConfig? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageSearch? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContentUsageMetadata? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningSnapshot? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListGeneratedFilesResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFile? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SemanticRetrieverChunk? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AsyncBatchEmbedContentRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequests? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchTypes? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WebSearch? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Corpus? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatusModelStage? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PlaceAnswerSources? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfigThinkingLevel? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListPermissionsResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Permission? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequestTaskType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Document? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DocumentState? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SchemaType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchGenerateContentRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatch? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Model? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Operation? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolConfig? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalConfig? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfig? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.HistoryConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCall? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCallToolType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WhiteSpaceConfig? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRating? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedbackBlockReason? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionGranteeType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionRole? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListOperationsResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingMetadata? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchEntryPoint? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalMetadata? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunk? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SourceType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRuleMode? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclaration? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclarationBehavior? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AuthToken? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BidiGenerateContentSetup? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Part? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResult? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CandidateFinishReason? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContextMetadata? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListEnvironmentsResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Environment>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Image? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseBlob? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfigMode? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFileState? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResult? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResultOutcome? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.McpServer? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StreamableHttpTransport? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequests? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseDisabledSafetyPolicie? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseEnvironment? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputConfig? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchStats? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchOutput? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchState? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievedContext? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContentEmbedding? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileData? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleMaps? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Tool? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearch? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearch? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormatMimeType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfigMode? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomLongRunningOperation? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadata? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListDocumentsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Blob? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StringList? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatDelivery? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatImageSize? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatMimeType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatAspectRatio? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfigTaskType? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Empty? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponses? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFileType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImportFileRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Web? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileRequest? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListModelsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Model>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Maps? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySetting? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingCategory? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingThreshold? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscription? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SessionResumptionConfig? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFilesResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCorporaResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TopCandidates? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingProbability? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingCategory? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListTunedModelsResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechMetadata? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequestServiceTier? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PartMediaProcessing? Type292 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Content>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.File>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Candidate>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CitationSource>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EgressRule>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EnvironmentFile>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Source>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Permission>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Schema>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Operation>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Part>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Environment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.McpServer>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionDeclaration>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Document>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Model>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.WordInfo>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Tool>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Corpus>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>? ListType50 { get; set; }
    }
}