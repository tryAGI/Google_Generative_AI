
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
        public global::Google.Gemini.Model? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Interval? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ProactivityConfig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.McpServer? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StreamableHttpTransport? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AuthToken? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BidiGenerateContentSetup? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListEnvironmentsResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Environment>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Environment? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Permission? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionRole? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionGranteeType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfig? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfigMode? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoMetadata? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySetting? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingCategory? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingThreshold? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCall? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PrebuiltVoiceConfig? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscription? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WordInfo? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Document? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DocumentState? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomMetadata? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadata? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCount? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadataServiceTier? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkMode? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Source? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentStatus? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AttributionSourceId? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SemanticRetrieverChunk? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingPassageId? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SourceType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearch? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchTypes? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TranslationConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Status? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Part? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PartMediaProcessing? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCode? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCall? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolution? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Blob? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileData? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechMetadata? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResult? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.File>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.File? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WhiteSpaceConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRule? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRuleMode? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolutionLevel? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCountModality? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputConfig? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequests? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCorporaResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Corpus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadToFileSearchStoreRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ChunkingConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Content? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearchRetrieval? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecution? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeakerVoiceConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VoiceConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StringList? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFileSearchStoresResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearchStore? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseBlob? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchGenerateContentRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatch? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListPermissionsResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContent? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolConfig? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContentUsageMetadata? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Tool? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WebSearch? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCachedContentsResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CachedContent>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatus? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatusModelStage? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContentEmbedding? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbeddingUsageMetadata? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListTunedModelsResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModel? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AsyncBatchEmbedContentRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatch? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchOutput? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponses? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoFileMetadata? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExamples? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExample? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResult? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResultCandidate? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TopCandidates? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContextMetadata? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadata? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchState? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchOutput? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchStats? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListOperationsResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Operation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequests? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequest? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponseToolType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalMetadata? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipRequest? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResultOutcome? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFile? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFileState? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfig? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequestTaskType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleMaps? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Web? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormat? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatDelivery? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatMimeType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfig? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetection? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedback? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Candidate? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.MultiSpeakerVoiceConfig? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CandidateFinishReason? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingAttribution? Type181 { get; set; }
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
        public global::Google.Gemini.GroundingMetadata? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationMetadata? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedbackBlockReason? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCodeLanguage? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningSnapshot? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomLongRunningOperation? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GetEnvironmentFilesResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFile? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePart? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseScheduling? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchEntryPoint? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunk? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfigTaskType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileRequest? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContext? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCallToolType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearch? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclaration? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUse? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListDocumentsResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageAuto? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LatLng? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponses? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Image? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContextWindowCompressionConfig? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfig? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SessionResumptionConfig? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfig? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.HistoryConfig? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalConfig? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkCustomMetadata? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkStringList? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseFileData? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseEnvironment? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseDisabledSafetyPolicie? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Maps? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PlaceAnswerSources? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelSource? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFilesResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SlidingWindow? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningTask? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Dataset? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Hyperparameters? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationSource? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageSearch? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievedContext? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfigMode? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageConfig? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Schema? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SchemaType? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclarationBehavior? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ResponseFormatConfig? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormat? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormat? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListModelsResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Model>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelState? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechConfig? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigMediaResolution? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigResponseModalitie? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfig? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequestServiceTier? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormatMimeType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchStats? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatMimeType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatAspectRatio? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatImageSize? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatDelivery? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSource? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileState? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Empty? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageHints? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ReviewSnippet? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputEmbedContentConfig? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchState? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImportFileRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePartMediaProcessing? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFileType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfigMode? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfigThinkingLevel? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingCategory? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingProbability? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListGeneratedFilesResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>? Type295 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Environment>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.WordInfo>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Source>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.File>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Corpus>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Content>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Permission>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Tool>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Operation>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Candidate>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Part>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EnvironmentFile>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionDeclaration>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.McpServer>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Document>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CitationSource>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Schema>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Model>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EgressRule>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>? ListType50 { get; set; }
    }
}