
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
        public global::Google.Gemini.EmbedContentBatchOutput? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponses? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadToFileSearchStoreRequest? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ChunkingConfig? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomMetadata? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearchRetrieval? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfig? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFileSearchStoresResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearchStore? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormat? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TextResponseFormatMimeType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormat? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatMimeType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioResponseFormatDelivery? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkCustomMetadata? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunkStringList? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageSearch? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbeddingUsageMetadata? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCount? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModalityTokenCountModality? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Image? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolConfig? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfig? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalConfig? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationMetadata? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CitationSource? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SessionResumptionConfig? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfig? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageAuto? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LanguageHints? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscriptionConfigMode? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetection? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionEndOfSpeechSensitivity? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AutomaticActivityDetectionStartOfSpeechSensitivity? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResultCandidate? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PlaceAnswerSources? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ReviewSnippet? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Content? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsRequest? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LatLng? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCachedContentsResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.CachedContent>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContent? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TranslationConfig? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelSource? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListOperationsResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Operation>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Operation? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListEnvironmentsResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Environment>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Environment? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExamples? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningExample? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolution? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.V1mainMediaResolutionLevel? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentStatus? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Source? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentNetworkMode? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoMetadata? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AuthToken? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BidiGenerateContentSetup? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ResponseFormatConfig? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormat? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySetting? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingCategory? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetySettingThreshold? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchStats? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CountTokensResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFile? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EnvironmentFileType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Blob? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WhiteSpaceConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListGeneratedFilesResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFile? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedRequests? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Part? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCall? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechMetadata? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PartMediaProcessing? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponse? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileData? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCall? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResult? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AudioTranscription? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCode? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Status? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListModelsResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Model>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Model? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolResponseToolType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StringList? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRating? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingCategory? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SafetyRatingProbability? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.StreamableHttpTransport? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchOutput? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponses? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponsePart? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseBlob? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatch? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputConfig? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentBatchState? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchStats? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Web? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.File>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.File? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContextWindowCompressionConfig? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SlidingWindow? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentResponse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Hyperparameters? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeakerVoiceConfig? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VoiceConfig? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchEmbedContentsResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ContentEmbedding? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PrebuiltVoiceConfig? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CachedContentUsageMetadata? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionResponseScheduling? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.WordInfo>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WordInfo? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatus? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ModelStatusModelStage? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListFilesResponse? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileResponse? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TransferOwnershipResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InputEmbedContentConfig? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequests? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModel? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningTask? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TunedModelState? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Empty? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Corpus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingChunk? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievedContext? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Maps? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.LogprobsResult? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TopCandidates? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingMetadata? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchEntryPoint? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RetrievalMetadata? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileState? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSource? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.VideoFileMetadata? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.WebSearch? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfig? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ThinkingConfigThinkingLevel? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GetEnvironmentFilesResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EnvironmentFile>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SpeechConfig? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.MultiSpeakerVoiceConfig? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfig? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Schema? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigResponseModalitie? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerationConfigMediaResolution? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AttributionSourceId? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SemanticRetrieverChunk? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingPassageId? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatImageSize? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatMimeType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatDelivery? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImageResponseFormatAspectRatio? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.AsyncBatchEmbedContentRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatch? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Permission? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionRole? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PermissionGranteeType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FileSearch? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Tool? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GenerateContentRequestServiceTier? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListPermissionsResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Permission>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateEnvironmentRequestNetworkMode? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContext? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Candidate? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CandidateFinishReason? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlContextMetadata? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GroundingAttribution? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfig? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentConfigTaskType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleSearch? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SearchTypes? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Interval? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DynamicRetrievalConfigMode? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclaration? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionDeclarationBehavior? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfig? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.HistoryConfig? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ToolCallToolType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.EgressRule>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRule? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleMaps? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecution? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.McpServer? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CodeExecutionResultOutcome? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Dataset? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SourceType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentRequestTaskType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadata? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UrlMetadataUrlRetrievalStatus? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListDocumentsResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Document>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.Document? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CustomLongRunningOperation? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.BatchGenerateContentRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedback? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.PromptFeedbackBlockReason? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.SchemaType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Schema>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.InlinedEmbedContentRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.CreateFileRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentBatchState? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EmbedContentResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Part>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListCorporaResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.GeneratedFileState? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ListTunedModelsResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.EgressRuleMode? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.RegisterFilesRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadata? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UsageMetadataServiceTier? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseEnvironment? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ComputerUseDisabledSafetyPolicie? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.TuningSnapshot? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.DocumentState? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ImportFileRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.UploadEnvironmentFileResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.ExecutableCodeLanguage? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.FunctionCallingConfigMode? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>? Type292 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>? ListType2 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Content>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Operation>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Environment>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Source>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Model>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.File>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.WordInfo>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EnvironmentFile>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Tool>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Permission>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.EgressRule>? ListType34 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Document>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Schema>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Part>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Corpus>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.ComputerUseDisabledSafetyPolicie>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.Candidate>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>? ListType50 { get; set; }
    }
}